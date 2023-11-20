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
    public partial class FormSupervisorInicio : FormBase
    {
        private FormLogin formLogin;
        private FormInventario formInventario;

        /// <summary>
        /// Inicializa una nueva instancia de formSupervisorInicio
        /// </summary>
        public FormSupervisorInicio(FormLogin fromLogin,Inventario inventario)
        {
            InitializeComponent();
            this.formLogin = fromLogin;
            formInventario = new(this, inventario);
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver Operarios",
        /// muestra información de los operarios mediante un MessageBox.
        /// </summary>
        private async void ButtonVerOperarios_Click(object sender, EventArgs e)
        {
            Task<string> mensajeTask = Supervisor.VerInformacionOperarios();
            string mensaje = await mensajeTask;
            MessageBox.Show(mensaje);
        }

        private void ButtonLineaDeProduccion_Click(object sender, EventArgs e)
        {
            formLogin.formLineaDeProduccion.ActualizarConfiguracionesForm(formLogin.formLineaDeProduccion);
            formLogin.formLineaDeProduccion.Show();
            this.Hide();

            this.DetenerTemporizador();
            formLogin.formLineaDeProduccion.InicializarTemporizador();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver stockMercaderia",
        /// actualiza las cantidades de stock y muestra el formulario de inventario.
        /// </summary>
        private void ButtonVerStock_Click(object sender, EventArgs e)
        {
            formInventario.ActualizarConfiguracionesForm(formInventario);
            formInventario.ActulizarCantidades();
            formInventario.Show();
            this.Hide();
            
            this.DetenerTemporizador();
            formInventario.InicializarTemporizador();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Hide();
        }
    }
}

