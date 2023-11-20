namespace Soto.Magali.Parcial
{
    partial class FormSupervisorInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupervisorInicio));
            labelMenuPrincipal = new Label();
            labelPreguntaAccion = new Label();
            buttonVerOperarios = new Button();
            buttonVerStock = new Button();
            buttonLineaDeProduccion = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // labelMenuPrincipal
            // 
            labelMenuPrincipal.BackColor = Color.Transparent;
            labelMenuPrincipal.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMenuPrincipal.ForeColor = Color.PaleVioletRed;
            labelMenuPrincipal.Location = new Point(70, 31);
            labelMenuPrincipal.Name = "labelMenuPrincipal";
            labelMenuPrincipal.Size = new Size(267, 39);
            labelMenuPrincipal.TabIndex = 1;
            labelMenuPrincipal.Text = "MENU PRINCIPAL";
            labelMenuPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPreguntaAccion
            // 
            labelPreguntaAccion.BackColor = Color.Transparent;
            labelPreguntaAccion.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPreguntaAccion.ForeColor = Color.PaleVioletRed;
            labelPreguntaAccion.Location = new Point(47, 95);
            labelPreguntaAccion.Name = "labelPreguntaAccion";
            labelPreguntaAccion.Size = new Size(636, 39);
            labelPreguntaAccion.TabIndex = 4;
            labelPreguntaAccion.Text = "¿Que accion desea realizar?";
            labelPreguntaAccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonVerOperarios
            // 
            buttonVerOperarios.BackColor = Color.White;
            buttonVerOperarios.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonVerOperarios.FlatAppearance.BorderSize = 2;
            buttonVerOperarios.FlatStyle = FlatStyle.Flat;
            buttonVerOperarios.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVerOperarios.Location = new Point(153, 163);
            buttonVerOperarios.Name = "buttonVerOperarios";
            buttonVerOperarios.Size = new Size(149, 52);
            buttonVerOperarios.TabIndex = 5;
            buttonVerOperarios.Text = "Ver operarios \r\nregistrados";
            buttonVerOperarios.UseVisualStyleBackColor = false;
            buttonVerOperarios.Click += ButtonVerOperarios_Click;
            // 
            // buttonVerStock
            // 
            buttonVerStock.BackColor = Color.White;
            buttonVerStock.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonVerStock.FlatAppearance.BorderSize = 2;
            buttonVerStock.FlatStyle = FlatStyle.Flat;
            buttonVerStock.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVerStock.Location = new Point(427, 163);
            buttonVerStock.Name = "buttonVerStock";
            buttonVerStock.Size = new Size(149, 52);
            buttonVerStock.TabIndex = 6;
            buttonVerStock.Text = "Ver stockMercaderia";
            buttonVerStock.UseVisualStyleBackColor = false;
            buttonVerStock.Click += ButtonVerStock_Click;
            // 
            // buttonLineaDeProduccion
            // 
            buttonLineaDeProduccion.BackColor = Color.White;
            buttonLineaDeProduccion.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonLineaDeProduccion.FlatAppearance.BorderSize = 2;
            buttonLineaDeProduccion.FlatStyle = FlatStyle.Flat;
            buttonLineaDeProduccion.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLineaDeProduccion.Location = new Point(153, 262);
            buttonLineaDeProduccion.Name = "buttonLineaDeProduccion";
            buttonLineaDeProduccion.Size = new Size(149, 52);
            buttonLineaDeProduccion.TabIndex = 7;
            buttonLineaDeProduccion.Text = "Gestionar linea\r\nde productos";
            buttonLineaDeProduccion.UseVisualStyleBackColor = false;
            buttonLineaDeProduccion.Click += ButtonLineaDeProduccion_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.White;
            buttonSalir.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonSalir.FlatAppearance.BorderSize = 2;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.Location = new Point(427, 262);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(149, 52);
            buttonSalir.TabIndex = 8;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += ButtonSalir_Click;
            // 
            // formSupervisorInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(736, 413);
            ControlBox = false;
            Controls.Add(buttonSalir);
            Controls.Add(buttonLineaDeProduccion);
            Controls.Add(buttonVerStock);
            Controls.Add(buttonVerOperarios);
            Controls.Add(labelPreguntaAccion);
            Controls.Add(labelMenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formSupervisorInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Label labelMenuPrincipal;
        private Label labelPreguntaAccion;
        private Button buttonVerOperarios;
        private Button buttonVerStock;
        private Button buttonLineaDeProduccion;
        private Button buttonSalir;
    }
}