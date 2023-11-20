using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar las 
    /// configuraciones de la aplicacion
    /// </summary>
    public partial class FormConfiguracion : FormBase
    {
        private FormLogin formLogin;
        private Dictionary<string, string> listaConfiguraciones;
        private string? productoSeleccionado;

        /// <summary>
        /// Inicializa una nueva instancia de FormConfiguracion
        /// </summary>
        /// <param name="formSupervisorInicio">formulario de inicio de sesion</param>
        public FormConfiguracion(FormLogin formLogin)
        {
            this.formLogin = formLogin;
            listaConfiguraciones = new();
            InitializeComponent();

            InstalledFontCollection installedFonts = new();

            FontFamily[] fontFamilies = installedFonts.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                listBoxFuentes.Items.Add(fontFamily.Name);
            }
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                listBoxColorTexto.Items.Add(color.Name);
                listBoxFondos.Items.Add(color.Name);
            }

            listaConfiguraciones["Color fondo:"] = "";
            listaConfiguraciones["Fuente:"] = "";
            listaConfiguraciones["Color texto:"] = "";
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            DetenerTemporizador();
            this.Hide();
        }

        /// <summary>
        /// Guarda las configuraciones elegidas
        /// en un archivo.json
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (listBoxFuentes.SelectedItem != null)
            {
                productoSeleccionado = listBoxFuentes.SelectedItem.ToString();
                listaConfiguraciones["Fuente:"] = productoSeleccionado;
            }
            if (listBoxColorTexto.SelectedItem != null)
            {
                productoSeleccionado = listBoxColorTexto.SelectedItem.ToString();
                listaConfiguraciones["Color texto:"] = productoSeleccionado;
            }
            if (listBoxFondos.SelectedItem != null)
            {
                productoSeleccionado = listBoxFondos.SelectedItem.ToString();
                listaConfiguraciones["Color fondo:"] = productoSeleccionado;
            }

            string pathNuevo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
            Archivos<Dictionary<string, string>>.Escribir_JSON(pathNuevo + "configuraciones.json", listaConfiguraciones);

            this.ActualizarConfiguracionesForm(this);
            formLogin.ActualizarConfiguracionesForm(formLogin);
        }
    }
}
