using Soto.Magali.Parcial;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    /// <summary>
    /// Formulario para visualizar y gestionar proceso
    /// de creacion de productos,
    /// </summary>
    public partial class FormProcesoCrearProducto : Form
    {
        private int mensajeActualIndex = 0;
        private List<string> listaProcesos;
        private FormLineaDeProduccion formLineaDeProduccion;

        /// <summary>
        /// Inicializa una nueva instancia del FormProcesoCrearProducto y configura 
        /// un temporizador para mostrar mensajes con una diferencia de 3 segundos.
        /// </summary>
        /// <param name="formLineaDeProduccion">formulario linea de produccion.</param>
        /// <param name="listaProcesos">lista de mensajes a mostrar.</param>
        public FormProcesoCrearProducto(
            FormLineaDeProduccion formLineaDeProduccion, 
            List<string> listaProcesos
        )
        {
            InitializeComponent();

            this.listaProcesos = listaProcesos;
            this.formLineaDeProduccion = formLineaDeProduccion;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Maneja el evento Tick del temporizador,
        /// muestra los mensajes de listaProcesos con una diferencia de 
        /// 3 segundos y vuelve al formulario de linea de produccion 
        /// cuando se han mostrado todos los mensajes.
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mensajeActualIndex < listaProcesos.Count)
            {
                labelPasosParaCrearProducto.Text = listaProcesos[mensajeActualIndex];
                mensajeActualIndex++;
            }
            else
            {
                ((System.Windows.Forms.Timer)sender).Stop();

                formLineaDeProduccion.Show();
                this.Close();
            }
        }
    }
}