using Biblioteca;
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
    public partial class FormInventario : Form
    {
        private Inventario inventarioCompartido;
        private List<Mercaderia> listaMercaderias = new();
        private FormPedirMercaderia formPedirMercaderia;
        private FormSupervisorInicio formSupervisorInicio;

        /// <summary>
        /// Inicializa una nueva instancia de FormInventario
        /// </summary>
        /// <param name="inventario">inventario compartido con mercaderias</param>
        /// <param name="formSupervisorInicio">formulario de inicio del supervisor</param>
        public FormInventario(Inventario inventario, FormSupervisorInicio formSupervisorInicio)
        {
            InitializeComponent();
            inventarioCompartido = inventario;
            formPedirMercaderia = new(inventarioCompartido, this);
            this.formSupervisorInicio = formSupervisorInicio;

            labelDulceDeLeche.Text = inventarioCompartido.DulceDeLeche.GetNombre();
            labelQuesoCrema.Text = inventarioCompartido.QuesoCrema.GetNombre();
            labelGalletasDeVainilla.Text = inventarioCompartido.GalletitasDeVanilla.GetNombre();
            labelGalletasDeChocolate.Text = inventarioCompartido.GalletitiasDeChocolate.GetNombre();
            labelChocolate.Text = inventarioCompartido.Chocolate.GetNombre();
            labelCafe.Text = inventarioCompartido.Cafe.GetNombre();
            labelEnvoltorio.Text = inventarioCompartido.Envoltorio.GetNombre();
            labelRecipiente.Text = inventarioCompartido.Recipiente.GetNombre();

            listaMercaderias.Add(inventarioCompartido.DulceDeLeche);
            listaMercaderias.Add(inventarioCompartido.QuesoCrema);
            listaMercaderias.Add(inventarioCompartido.GalletitasDeVanilla);
            listaMercaderias.Add(inventarioCompartido.GalletitiasDeChocolate);
            listaMercaderias.Add(inventarioCompartido.Chocolate);
            listaMercaderias.Add(inventarioCompartido.Cafe);
            listaMercaderias.Add(inventarioCompartido.Envoltorio);
            listaMercaderias.Add(inventarioCompartido.Recipiente);
        }

        /// <summary>
        /// Actualiza las cantidades de mercaderia y los colores 
        /// de los labels en el formulalrio
        /// </summary>
        public void ActulizarCantidades()
        {
            labelCantidadDulceDeLeche.Text = inventarioCompartido.DulceDeLeche.Cantidad.ToString();
            labelCantidadQuesoCrema.Text = inventarioCompartido.QuesoCrema.Cantidad.ToString();
            labelCantidadGalletasDeVainilla.Text = inventarioCompartido.GalletitasDeVanilla.Cantidad.ToString();
            labelCantidadGalletasDeChocolate.Text = inventarioCompartido.GalletitiasDeChocolate.Cantidad.ToString();
            labelCantidadChocolate.Text = inventarioCompartido.Chocolate.Cantidad.ToString();
            labelCantidadCafe.Text = inventarioCompartido.Cafe.Cantidad.ToString();
            labelCantidadEnvoltorio.Text = inventarioCompartido.Envoltorio.Cantidad.ToString();
            labelCantidadRecipiente.Text = inventarioCompartido.Recipiente.Cantidad.ToString();

            labelDulceDeLeche.ForeColor = Color.DeepPink;
            labelCantidadDulceDeLeche.ForeColor = Color.DeepPink;
            labelQuesoCrema.ForeColor = Color.DeepPink;
            labelCantidadQuesoCrema.ForeColor = Color.DeepPink;
            labelGalletasDeVainilla.ForeColor = Color.DeepPink;
            labelCantidadGalletasDeVainilla.ForeColor = Color.DeepPink;
            labelGalletasDeChocolate.ForeColor = Color.DeepPink;
            labelCantidadGalletasDeChocolate.ForeColor = Color.DeepPink;
            labelChocolate.ForeColor = Color.DeepPink;
            labelCantidadChocolate.ForeColor = Color.DeepPink;
            labelCafe.ForeColor = Color.DeepPink;
            labelCantidadCafe.ForeColor = Color.DeepPink;
            labelEnvoltorio.ForeColor = Color.DeepPink;
            labelCantidadEnvoltorio.ForeColor = Color.DeepPink;
            labelRecipiente.ForeColor = Color.DeepPink;
            labelCantidadRecipiente.ForeColor = Color.DeepPink;

            foreach (Mercaderia mercaderia in listaMercaderias)
            {
                if (mercaderia.Cantidad <= 0)
                {
                    switch (mercaderia.GetNombre().ToLower())
                    {
                        case "dulce de leche":
                            labelDulceDeLeche.ForeColor = Color.Red;
                            labelCantidadDulceDeLeche.ForeColor = Color.Red;
                            break;
                        case "queso crema":
                            labelQuesoCrema.ForeColor = Color.Red;
                            labelCantidadQuesoCrema.ForeColor = Color.Red;
                            break;
                        case "galletita de vainilla":
                            labelGalletasDeVainilla.ForeColor = Color.Red;
                            labelCantidadGalletasDeVainilla.ForeColor = Color.Red;
                            break;
                        case "galletita de chocolate":
                            labelGalletasDeChocolate.ForeColor = Color.Red;
                            labelCantidadGalletasDeChocolate.ForeColor = Color.Red;
                            break;
                        case "chocolate":
                            labelChocolate.ForeColor = Color.Red;
                            labelCantidadChocolate.ForeColor = Color.Red;
                            break;
                        case "cafe":
                            labelCafe.ForeColor = Color.Red;
                            labelCantidadCafe.ForeColor = Color.Red;
                            break;
                        case "envoltorio":
                            labelEnvoltorio.ForeColor = Color.Red;
                            labelCantidadEnvoltorio.ForeColor = Color.Red;
                            break;
                        case "recipiente":
                            labelRecipiente.ForeColor = Color.Red;
                            labelCantidadRecipiente.ForeColor = Color.Red;
                            break;

                    }
                }
                
            }

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            formPedirMercaderia.Show();
            this.Hide();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            formSupervisorInicio.Show();
            this.Hide();
        }
    }
}
