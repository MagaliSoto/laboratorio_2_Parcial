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
    public partial class FormLineaDeProduccion : FormBase
    {
        private FormLogin formLogin;
        private FormSupervisorInicio formSupervisorInicio;
        private FormProcesoCrearProducto? formProcesoCrearProducto;
        private FabricasProducto fabricasProductos;
        private Inventario inventarioCompartido;
        public string? mensajeError;

        /// <summary>
        ///  Inicializa una nueva instancia de formLineaDeProduccion
        /// </summary>
        /// <param name="formLogin">formulario de inicio de sesion</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        /// <param name="inventario">inventario comprartido</param>
        public FormLineaDeProduccion(
            FormLogin formLogin,
            FormSupervisorInicio formSupervisorInicio,
            Inventario inventario
        )
        {
            InitializeComponent();
            fabricasProductos = new();

            this.formLogin = formLogin;
            this.formSupervisorInicio = formSupervisorInicio;
            inventarioCompartido = inventario;
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Producir"
        /// produce el producto seleccionado por el usuario,
        /// mostrando un mensaje de error en caso de no poder
        /// hacerse.
        /// </summary>
        private void ButtonProducir_Click(object sender, EventArgs e)
        {
            string? productoSeleccionado;
            int cantidadAProducir = (int)numericUpDownCantidadAProducir.Value;

            if (listBoxProducto.SelectedItem != null)
            {
                productoSeleccionado = listBoxProducto.SelectedItem.ToString();

                FabricaProducto fabricaProducto = fabricasProductos.listadoFabricas[productoSeleccionado];
                mensajeError = fabricaProducto.Fabricar(inventarioCompartido, cantidadAProducir, 0);

                if (mensajeError == "")
                {
                    formProcesoCrearProducto = new FormProcesoCrearProducto(this, fabricaProducto.PasosProduccion);

                    formProcesoCrearProducto.ProcesoProductoCompletado += ProcesoCrearProductoCompletado;

                    formProcesoCrearProducto.ActualizarConfiguracionesForm(formProcesoCrearProducto);
                    formProcesoCrearProducto.Show();
                    this.Hide();

                    this.DetenerTemporizador();
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

        private void ProcesoCrearProductoCompletado(object sender, EventArgs e)
        {
            MessageBox.Show("Producto creado");
        }

        /// <summary>
        /// Maneja el evento de selección de un producto en el ListBox,
        /// actualiza las listBox de mercaderías y cantidades segun 
        /// el producto seleccionado.
        /// </summary>
        private void ListBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMercaderia.Items.Clear();
            listBoxCantidad.Items.Clear();

            string? productoSeleccionado = listBoxProducto.SelectedItem.ToString();

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

                this.DetenerTemporizador();
            }
            else if (formLogin.usuarioActual.Rol == "Operario")
            {
                formLogin.Show();
                this.Hide();

                this.DetenerTemporizador();
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

            List<Producto> listaProductos = InventarioDAO.LeerProductos();

            if (listaProductos.Count != 0)                
            {
                foreach (var producto in listaProductos)
                {
                    mensajeProductos += $"\nNombre: {producto.Nombre}\tCantidad: {producto.Cantidad}";
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
