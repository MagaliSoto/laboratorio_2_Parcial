using Soto.Magali.Parcial;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Soto.Magali.Parcial
{
    public partial class FormProcesoCrearProducto : FormBase
    {
        private int mensajeActualIndex;
        private List<string> listaProcesos;
        private FormLineaDeProduccion formLineaDeProduccion;

        public delegate void ProcesoCrearProductoCompletado(object sender, EventArgs e);
        public event ProcesoCrearProductoCompletado ProcesoProductoCompletado;

        public FormProcesoCrearProducto(
            FormLineaDeProduccion formLineaDeProduccion,
            List<string> listaProcesos
        )
        {
            InitializeComponent();
            mensajeActualIndex = 0;
            this.listaProcesos = listaProcesos;
            this.formLineaDeProduccion = formLineaDeProduccion;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

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

                OnProcesoCrearProductoCompletado();

                formLineaDeProduccion.Show();
                this.Close();
                formLineaDeProduccion.InicializarTemporizador();
            }
        }

        protected virtual void OnProcesoCrearProductoCompletado()
        {
            ProcesoProductoCompletado?.Invoke(this, EventArgs.Empty);
        }
    }
}