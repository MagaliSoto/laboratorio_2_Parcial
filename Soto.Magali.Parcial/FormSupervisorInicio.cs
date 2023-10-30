using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar el inicio del supervisor.
    /// </summary>
    public partial class FormSupervisorInicio : Form
    {
        private FormLogin formLogin;
        private FormInventario formInventario;

        /// <summary>
        /// Inicializa una nueva instancia de FormSupervisorInicio
        /// </summary>
        public FormSupervisorInicio(Inventario inventarioCompartido, FormLogin fromLogin)
        {
            InitializeComponent();
            this.formLogin = fromLogin;
            formInventario = new(inventarioCompartido, this);
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver Operarios",
        /// muestra información de los operarios mediante un MessageBox.
        /// </summary>
        private void ButtonVerOperarios_Click(object sender, EventArgs e)
        {
            string mensaje = Supervisor.VerInformacionOperarios(formLogin.listaOperarios);
            MessageBox.Show(mensaje);
        }

        private void ButtonLineaDeProduccion_Click(object sender, EventArgs e)
        {
            formLogin.formLineaDeProduccion.Show();
            this.Hide();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver stockMercaderia",
        /// actualiza las cantidades de stock y muestra el formulario de inventario.
        /// </summary>
        private void ButtonVerStock_Click(object sender, EventArgs e)
        {
            formInventario.ActulizarCantidades();
            formInventario.Show();
            this.Hide();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Hide();
        }
    }
}

