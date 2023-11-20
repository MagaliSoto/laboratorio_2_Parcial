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
    /// Formulario usado como base para gestionar
    /// las configuraciones y tiempo en pantalla
    /// </summary>
    public partial class FormBase : Form
    {
        private System.Windows.Forms.Timer timer;

        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa un temporizador
        /// </summary>
        public void InicializarTemporizador()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000000000;
            timer.Tick += Timer_Tick;

            this.MouseMove += MouseMoveEvento;
            this.KeyDown += KeyDownEvento;

            timer.Start();
        }

        /// <summary>
        /// Evento encargado de mostrar un mensaje en pantalla
        /// si el usuario esta inactivo por mucho tiempo 
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            DialogResult respuesta = MessageBox.Show("¿Sigue ahí?", "Inactividad", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                ReiniciarTemporizador();
            }
            else
            {
                CerrarFormulariosActivos();
            }
        }

        /// <summary>
        /// Cierra todos los formularios abiertos
        /// </summary>
        public static void CerrarFormulariosActivos()
        {
            Form[] formulariosAbiertos = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form form in formulariosAbiertos)
            {
                if (form != null)
                {
                    form.Close();
                }
            }
        }

        /// <summary>
        /// En caso de que el usuario mueva el mause,
        /// se reinicia el temporizador que mide
        /// el tiempo en pantall
        /// </summary>
        private void MouseMoveEvento(object sender, MouseEventArgs e)
        {
            ReiniciarTemporizador();
        }

        /// <summary>
        /// En caso de que el usuario toque una tecla,
        /// se reinicia el temporizador que mide
        /// el tiempo en pantall
        /// </summary>
        private void KeyDownEvento(object sender, KeyEventArgs e)
        {
            ReiniciarTemporizador();
        }

        /// <summary>
        /// Detiene el temporizador
        /// </summary>
        public void DetenerTemporizador()
        {
            timer.Stop();
        }
       
        /// <summary>
        /// Reinicia el temporizador
        /// </summary>
        public void ReiniciarTemporizador()
        {
            DetenerTemporizador();
            timer.Start();
        }

        /// <summary>
        /// Modifica el color del fondo, del texto,
        /// y la fuente de este ultimo
        /// </summary>
        /// <param name="formulario">formulario que se modificara</param>
        public void ActualizarConfiguracionesForm(Form formulario)
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";

            FontConverter fontConverter = new();

            try
            {
                Dictionary<string, string> dic = Archivos<Dictionary<string, string>>.Leer_JSON(path + "configuraciones.json");

                foreach (Control control in formulario.Controls)
                {
                    if (control is Label label)
                    {
                        foreach (var kvp in dic)
                        {
                            string clave = kvp.Key;
                            string valor = kvp.Value;

                            if (!string.IsNullOrEmpty(valor))
                            {
                                switch (clave)
                                {
                                    case "Color texto:":
                                        label.ForeColor = Color.FromName(valor);
                                        break;

                                    case "Fuente:":
                                        label.Font = (Font)fontConverter.ConvertFromString(valor);
                                        break;

                                    case "Color fondo:":
                                        try
                                        {
                                            this.BackgroundImage = null;
                                            this.BackColor = Color.FromName(valor);
                                        }
                                        catch (Exception)
                                        {
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}