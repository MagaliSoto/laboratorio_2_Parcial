using Biblioteca;
using System;
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
        public string mensaje;

        /// <summary>
        ///  Inicializa una nueva instancia de FormLineaDeProduccion
        /// </summary>
        /// <param name="inventarioCompartido">inventario compartido con mercaderias</param>
        /// <param name="formLogin">formulario de inicio de sesion</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        public FormLineaDeProduccion(Inventario inventarioCompartido, FormLogin formLogin,
            FormSupervisorInicio formSupervisorInicio)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.inventarioCompartido = inventarioCompartido;
            this.formSupervisorInicio = formSupervisorInicio;
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Producir"
        /// produce el producto seleccionado por el usuario.
        /// </summary>
        private void ButtonProducir_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = "";
            decimal cantidadAProducirDecimal = numericUpDownCantidadAProducir.Value;
            int cantidadAProducir = (int)cantidadAProducirDecimal;

            if (listBoxProducto.SelectedItem != null)
            {
                productoSeleccionado = listBoxProducto.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Para proceder debe seleccionar el producto deseada.\n" +
                    "O presione el botón 'Atras'");
            }

            if (productoSeleccionado == "Conito")
            {
                Producto conito = new(productoSeleccionado, inventarioCompartido.DulceDeLeche,
                    inventarioCompartido.Chocolate,
                    inventarioCompartido.GalletitasDeVanilla, inventarioCompartido.Envoltorio);

                if (conito.CrearProducto(cantidadAProducir, out mensaje))
                {
                    formProcesoCrearProducto = new(this, conito.Mensajes);
                    formProcesoCrearProducto.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else if (productoSeleccionado == "Chocotorta")
            {
                Producto chocotorta = new(productoSeleccionado, inventarioCompartido.DulceDeLeche,
                    inventarioCompartido.QuesoCrema, inventarioCompartido.GalletitiasDeChocolate,
                    inventarioCompartido.Cafe, inventarioCompartido.Recipiente);
                chocotorta.CrearProducto(cantidadAProducir, out mensaje);

                if (chocotorta.CrearProducto(cantidadAProducir, out mensaje))
                {
                    formProcesoCrearProducto = new(this, chocotorta.Mensajes);
                    formProcesoCrearProducto.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
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

            string[] conitoMercaderia = {"Dulce de leche","Chocolate",
                "Galletita de vainilla","Envoltorio"};
            string[] conitoCantidad = { "20", "15", "1", "1" };

            string[] chocotortaMercaderia = {"Dulce de leche","Queso crema",
                "Galletita de chocolate","Cafe","Recipiente"};
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
            if (formLogin.usuarioActual.rol == "Supervisor")
            {
                formSupervisorInicio.Show();
                this.Hide();
            }
            else if (formLogin.usuarioActual.rol == "Operario")
            {
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
