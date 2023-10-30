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
    /// Formulario para visualizar y gestionar el inventario con mercaderias.
    /// </summary>
    public partial class FormInventario : Form
    {
        private List<Mercaderia> stockMercaderia = new();
        private FormPedirMercaderia formPedirMercaderia;
        private FormSupervisorInicio formSupervisorInicio;
        private List<Label> listaLablelsTexto = new();
        private List<Label> listaLablelsCantidad = new();

        /// <summary>
        /// Inicializa una nueva instancia de FormInventario
        /// </summary>
        /// <param name="inventario">inventario compartido con mercaderias</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        public FormInventario(Inventario inventario, FormSupervisorInicio formSupervisorInicio)
        {
            InitializeComponent();
            stockMercaderia = inventario.StockMercaderia;
            formPedirMercaderia = new(inventario, this);
            this.formSupervisorInicio = formSupervisorInicio;

            listaLablelsTexto = [
                labelDulceDeLeche, 
                labelQuesoCrema, 
                labelGalletasDeVainilla,
                labelGalletasDeChocolate, 
                labelChocolate, 
                labelCafe,
                labelEnvoltorio, 
                labelRecipiente
            ];

            listaLablelsCantidad = [
                labelCantidadDulceDeLeche,
                labelCantidadQuesoCrema,
                labelCantidadGalletasDeVainilla,
                labelCantidadGalletasDeChocolate,
                labelCantidadChocolate,
                labelCantidadCafe,
                labelCantidadEnvoltorio,
                labelCantidadRecipiente
            ];

            int i = 0;
            foreach (var label in listaLablelsTexto)
            {
                label.Text = stockMercaderia[i].Nombre;
                i += 1;
            }

        }

        /// <summary>
        /// Actualiza las cantidades de mercaderia y los colores 
        /// de los labels en el formulalrio
        /// </summary>
        public void ActulizarCantidades()
        {
            int i = 0;
            foreach (var label in listaLablelsCantidad)
            {
                label.ForeColor = Color.DeepPink;
                label.Text = stockMercaderia[i].Cantidad.ToString();
                i += 1;
            }

            foreach (var label in listaLablelsTexto)
            {
                label.ForeColor = Color.DeepPink;
            }

            foreach (var label in listaLablelsCantidad)
            {
                int cantidad = int.Parse(label.Text);
                if (cantidad <= 0)
                {
                    label.ForeColor = Color.Red;
                    int iCantidad = listaLablelsCantidad.IndexOf(label);

                    for (int ii = 0; ii < listaLablelsTexto.Count; ii++)
                    {
                        if (iCantidad == ii)
                        {
                            listaLablelsTexto[ii].ForeColor = Color.Red;
                        }
                    }
                }
            }

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            formPedirMercaderia.Show();
            this.Hide();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formSupervisorInicio.Show();
            this.Hide();
        }
    }
}
