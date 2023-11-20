using Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar el registro de usuarios.
    /// </summary>
    public partial class FormRegistro : FormBase
    {
        private FormLogin formLogin;
        private delegate Task<string> RegistroUsuario
            (string usuario, string contraseña, object rol, string ruta);
        private string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";

        /// <summary>
        /// Inicializa una nueva instancia de FormRegistro
        /// </summary>
        public FormRegistro(FormLogin formLogin)
        {
            this.formLogin = formLogin;
            InitializeComponent();
        }

        /// <summary>
        /// Guarda los datos del usuario en la base de datos
        /// </summary>
        private async void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxNombreDeUsuario.Text;
            string contraseña = textBoxContraseña.Text;
            object rolSeleccionado = listBoxRol.SelectedItem;

            RegistroUsuario registrarUsuarioDelegate = new (Usuario.RegistrarUsuario);
            Task<string> mensajeTask = registrarUsuarioDelegate( usuario,contraseña, rolSeleccionado, ruta);
            string mensaje = await mensajeTask;
            MessageBox.Show(mensaje);
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Hide();
            this.DetenerTemporizador();
        }
    }
}
