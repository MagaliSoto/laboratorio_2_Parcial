using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar la mercaderia.
    /// </summary>
    public partial class FormPedirMercaderia : Form
    {
        private FormInventario formInventario;
        private List<Mercaderia> stockMercaderia;
        
        /// <summary>
        /// Inicializa una nueva instancia de FormPedirMercaderia
        /// </summary>
        public FormPedirMercaderia(Inventario inventarioCompartido, FormInventario formInventario)
        {
            InitializeComponent();
            this.formInventario = formInventario;
            stockMercaderia = inventarioCompartido.StockMercaderia;
        }

        /// <summary>
        /// Manejador de eventos para el botón "Pedir",
        /// permite al usuario realizar un pedido de mercadería 
        /// y actualiza el inventario compartido.
        /// </summary>    
        private void ButtonPedir_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericUpDownCantidad.Value;
            string mercaderiaSeleccionada = "";

            if (listBoxMercaderia.SelectedItem != null)
            {
                mercaderiaSeleccionada = listBoxMercaderia.SelectedItem.ToString().ToLower();
            }
            else
            {
                MessageBox.Show("Para proceder debe seleccionar la mercadería deseada.\n" +
                    "O presione el botón 'Atras'");
            }

            foreach (Mercaderia mercaderia in stockMercaderia)
            {
                if (mercaderia.Nombre == mercaderiaSeleccionada)
                {
                    if (100 < mercaderia.Cantidad + cantidad)
                    {
                        MessageBox.Show("El maximo de mercaderia a tener en stock es 100\n" +
                            "Ingrese una Cantidad menor");
                    }
                    else
                    {
                        mercaderia.Cantidad += cantidad;
                        MessageBox.Show($"Se agrego {cantidad} de {mercaderia.Nombre}");
                    }
                }
            }

        }

        /// <summary>
        /// Manejador de eventos para el botón "Atras",
        /// actualiza las cantidades en el inventario compartido
        /// y muestra el formulario de inventario.
        /// </summary>
        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formInventario.ActulizarCantidades();
            formInventario.Show();
            this.Hide();
        }
    }
}
