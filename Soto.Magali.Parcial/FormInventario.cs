using Clases;
using Soto.Magali.Parcial;
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
    public partial class FormInventario : FormBase
    {
        private List<Mercaderia> stockMercaderia;
        private FormPedirMercaderia formPedirMercaderia;
        private FormSupervisorInicio formSupervisorInicio;
        private List<Label> listaLablelsTexto;
        private List<Label> listaLablelsCantidad;

        /// <summary>
        /// Inicializa una nueva instancia de formInventario
        /// </summary>
        /// <param name="inventario">inventario compartido con mercaderias</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        public FormInventario(FormSupervisorInicio formSupervisorInicio,Inventario inventario)
        {
            InitializeComponent();
            stockMercaderia = inventario.Leer();
            formPedirMercaderia = new(this, inventario);
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
        public async void ActulizarCantidades()
        {
            stockMercaderia = InventarioDAO.LeerMercaderias();

            int i = 0;
            foreach (var label in listaLablelsCantidad)
            {
                label.ForeColor = Color.DeepPink;
                string nombre = stockMercaderia[i].Nombre;
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
            formPedirMercaderia.ActualizarConfiguracionesForm(formPedirMercaderia);
            formPedirMercaderia.Show();
            this.Hide();

            formPedirMercaderia.InicializarTemporizador();
            this.DetenerTemporizador();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formSupervisorInicio.Show();
            this.Hide();

            this.DetenerTemporizador();
        }
    }
}
