using Clases;
using System.Security.Cryptography.X509Certificates;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar el inicio de sesion.
    /// </summary>
    public partial class FormLogin : FormBase
    {
        internal Usuario? usuarioActual;
        internal List<Usuario>? listaOperarios;
        public FormLineaDeProduccion formLineaDeProduccion { get; set; }
        private Inventario inventarioCompartido;
        private FormSupervisorInicio formSupervisorInicio;
        private FormRegistro formRegistro;
        private FormConfiguracion formConfiguracion;

        /// <summary>
        /// Inicializa una nueva instancia de formLogin
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            inventarioCompartido = new();
            formRegistro = new(this);
            formConfiguracion = new(this);
            formSupervisorInicio = new(this, inventarioCompartido);
            formLineaDeProduccion = new(this, formSupervisorInicio, inventarioCompartido);
        }

        /// <summary>
        /// Manejador de eventos para el bot�n "Ingresar",
        /// verifica el ususario y contrase�a, mostrando el
        /// formulario correspondiente o un mensaje de error.
      ��///�</summary>
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxNombreDeUsuario.Text;
            string contrase�a = textBoxContrase�a.Text;

            if (usuario != "" && contrase�a != "")
            {
                usuarioActual = UsuarioDAO.Autenticar(usuario, contrase�a);
                DateTime creacion = UsuarioDAO.LeerAntiguedad(usuarioActual.Nombre);
                usuarioActual.Antiguedad = creacion;

                if (usuarioActual == null)
                {
                    MessageBox.Show("Usuario o contrase�a incorrectas");
                }
                else if(usuarioActual.Rol == "Operario")
                {
                    formLineaDeProduccion.ActualizarConfiguracionesForm(formLineaDeProduccion);
                    formLineaDeProduccion.Show();
                    this.Hide();
                    formLineaDeProduccion.InicializarTemporizador();
                }
                else if (usuarioActual.Rol == "Supervisor")
                {
                    formSupervisorInicio.ActualizarConfiguracionesForm(formSupervisorInicio);
                    formSupervisorInicio.Show();
                    this.Hide();
                    formSupervisorInicio.InicializarTemporizador();
                }
            }
            else
            {
                MessageBox.Show("Complete los datos para ingresar");
            }            
        }

        private void ButtonConfiguraciones_Click(object sender, EventArgs e)
        {
            formConfiguracion.Show();
            this.Hide();
            formConfiguracion.InicializarTemporizador();
        }   

        private void ButtonRegistro_Click(object sender, EventArgs e)
        {
            formRegistro.ActualizarConfiguracionesForm(formRegistro);
            formRegistro.Show();
            this.Hide();
            formRegistro.InicializarTemporizador();
        }
    }
}