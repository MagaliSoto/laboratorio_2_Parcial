using Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar la linea de produccion
    /// de los productos.
    /// </summary>
    public partial class FormLineaDeProduccion : Form
    {
        private Inventario inventarioCompartido;
        private FormLogin formLogin;
        private FormSupervisorInicio formSupervisorInicio;
        private FormProcesoCrearProducto formProcesoCrearProducto;
        private FabricasProducto fabricasProductos;

        public string mensajeError;

        /// <summary>
        ///  Inicializa una nueva instancia de FormLineaDeProduccion
        /// </summary>
        /// <param name="inventarioCompartido">inventario compartido con mercaderias</param>
        /// <param name="formLogin">formulario de inicio de sesion</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        public FormLineaDeProduccion(
            Inventario inventarioCompartido, 
            FormLogin formLogin,
            FormSupervisorInicio formSupervisorInicio
        )
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.inventarioCompartido = inventarioCompartido;
            this.formSupervisorInicio = formSupervisorInicio;
            fabricasProductos = new();
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Producir"
        /// produce el producto seleccionado por el usuario,
        /// mostrando un mensaje de error en caso de no poder
        /// hacerse.
        /// </summary>
        private void ButtonProducir_Click(object sender, EventArgs e)
        {
            string productoSeleccionado;
            int cantidadAProducir = (int)numericUpDownCantidadAProducir.Value;

            if (listBoxProducto.SelectedItem != null)
            {
                productoSeleccionado = listBoxProducto.SelectedItem.ToString();

                FabricaProducto fabricaProducto = fabricasProductos.listadoFabricas[productoSeleccionado];
                mensajeError = fabricaProducto.Fabricar(inventarioCompartido, cantidadAProducir);

                if (mensajeError == "")
                {
                    formProcesoCrearProducto = new(this, fabricaProducto.PasosProduccion);
                    formProcesoCrearProducto.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                MessageBox.Show("Para proceder debe seleccionar el producto deseada.\n" +
                    "O presione el botón 'Atras'");
            }
        }

        /// <summary>
        /// Maneja el evento de selección de un producto en el ListBox,
        /// actualiza las listBox de mercaderías y cantidades segun 
        /// el producto seleccionado.
        /// </summary>
        private void ListBoxProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBoxMercaderia.Items.Clear();
            listBoxCantidad.Items.Clear();

            string productoSeleccionado = listBoxProducto.SelectedItem.ToString();

            string[] conitoMercaderia = {
                "Dulce de leche",
                "Chocolate",
                "Galletita de vainilla",
                "Envoltorio"
            };
            string[] conitoCantidad = { "15", "15", "1", "1" };

            string[] chocotortaMercaderia = {
                "Dulce de leche",
                "Queso crema",
                "Galletita de chocolate",
                "Cafe",
                "Recipiente"
            };
            string[] chocotortaCantidad = { "20", "20", "10", "15", "1" };

            if (productoSeleccionado == "Conito")
            {
                listBoxMercaderia.Items.AddRange(conitoMercaderia);
                listBoxCantidad.Items.AddRange(conitoCantidad);
            }
            else if (productoSeleccionado == "Chocotorta")
            {
                listBoxMercaderia.Items.AddRange(chocotortaMercaderia);
                listBoxCantidad.Items.AddRange(chocotortaCantidad);
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Atras",
        /// regresa al formulario correspondiente segun el rol del usuario.
        /// </summary>
        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            if (formLogin.usuarioActual.Rol == "Supervisor")
            {
                formSupervisorInicio.Show();
                this.Hide();
            }
            else if (formLogin.usuarioActual.Rol == "Operario")
            {
                formLogin.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Ver productos",
        /// muestra un formulario modal con los productos creados y
        /// la cantidad que haya de estos
        /// </summary>
        private void ButtonVerProductos_Click(object sender, EventArgs e)
        {
            string mensajeProductos = "PRODUCTOS:";
            if (inventarioCompartido.StockProductos.Any())
            {
                foreach (var producto in inventarioCompartido.StockProductos)
                {
                    mensajeProductos += $"\nNombre: {producto.Key.Nombre}\tCantidad: {producto.Value}";
                }
            }
            else
            {
                mensajeProductos = "No hay productos en el sistema";
            }
            MessageBox.Show(mensajeProductos);
        }
    }
}
