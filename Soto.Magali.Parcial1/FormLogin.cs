using Biblioteca;
using System.Security.Cryptography.X509Certificates;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar el inicio de sesion.
    /// </summary>
    public partial class FormLogin : Form
    {
        private Inventario inventarioCompartido;
        internal Usuario usuarioActual;
        internal FormLineaDeProduccion formLineaDeProduccion;
        private FormSupervisorInicio formSupervisorInicio;
        internal List<Usuario> listaOperarios = new();

        /// <summary>
        /// Inicializa una nueva instancia de FormLogin
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            inventarioCompartido = new Inventario();
            formSupervisorInicio = new(inventarioCompartido, this);
            formLineaDeProduccion = new(inventarioCompartido, this, formSupervisorInicio);
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ingresar",
        /// verifica el ususario y contraseña, mostrando el
        /// formulario correspondiente o un mensaje de error.
        /// </summary>
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxNombreDeUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (Operario.EsUsuarioValido(usuario, contraseña, listaOperarios,
                out usuarioActual))
            {
                formLineaDeProduccion.Show();
                this.Hide();
            }
            else if (Supervisor.EsSupervisorValido(usuario, contraseña,
                out usuarioActual))
            {
                formSupervisorInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Supervisor",
        /// establece los valores de el usuario y la contraseña
        /// del supervisor
        /// </summary>
        private void ButtonSupervisor_Click(object sender, EventArgs e)
        {
            textBoxNombreDeUsuario.Text = "supervisor1";
            textBoxContraseña.Text = "12345";
        }

        /// <summary>
        /// Manejador de eventos para el botón "Supervisor",
        /// establece los valores de el usuario y la contraseña
        /// del operario
        /// </summary>
        private void ButtonOperario_Click(object sender, EventArgs e)
        {
            textBoxNombreDeUsuario.Text = "operario1";
            textBoxContraseña.Text = "12345";
        }
    }
}