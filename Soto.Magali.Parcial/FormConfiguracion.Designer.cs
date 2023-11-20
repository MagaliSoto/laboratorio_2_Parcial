namespace Soto.Magali.Parcial
{
    partial class FormConfiguracion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            labelFuente = new Label();
            labelConfiguraciones = new Label();
            labelColorTexto = new Label();
            labelFondo = new Label();
            inventarioBindingSource = new BindingSource(components);
            buttonAtras = new Button();
            buttonGuardar = new Button();
            listBoxFuentes = new ListBox();
            listBoxColorTexto = new ListBox();
            listBoxFondos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelFuente
            // 
            labelFuente.BackColor = Color.Transparent;
            labelFuente.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuente.ForeColor = Color.Crimson;
            labelFuente.Location = new Point(133, 106);
            labelFuente.Name = "labelFuente";
            labelFuente.Size = new Size(142, 31);
            labelFuente.TabIndex = 12;
            labelFuente.Text = "Fuente";
            labelFuente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConfiguraciones
            // 
            labelConfiguraciones.BackColor = Color.Transparent;
            labelConfiguraciones.Font = new Font("Sitka Text", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelConfiguraciones.ForeColor = Color.PaleVioletRed;
            labelConfiguraciones.Location = new Point(12, 39);
            labelConfiguraciones.Name = "labelConfiguraciones";
            labelConfiguraciones.Size = new Size(710, 39);
            labelConfiguraciones.TabIndex = 13;
            labelConfiguraciones.Text = "Configuraciones";
            labelConfiguraciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelColorTexto
            // 
            labelColorTexto.BackColor = Color.Transparent;
            labelColorTexto.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelColorTexto.ForeColor = Color.Crimson;
            labelColorTexto.Location = new Point(307, 106);
            labelColorTexto.Name = "labelColorTexto";
            labelColorTexto.Size = new Size(142, 31);
            labelColorTexto.TabIndex = 15;
            labelColorTexto.Text = "Color texto";
            labelColorTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFondo
            // 
            labelFondo.BackColor = Color.Transparent;
            labelFondo.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFondo.ForeColor = Color.Crimson;
            labelFondo.Location = new Point(480, 106);
            labelFondo.Name = "labelFondo";
            labelFondo.Size = new Size(142, 31);
            labelFondo.TabIndex = 17;
            labelFondo.Text = "Fondo";
            labelFondo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventarioBindingSource
            // 
            inventarioBindingSource.DataSource = typeof(Clases.Inventario);
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.White;
            buttonAtras.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonAtras.FlatAppearance.BorderSize = 2;
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.Location = new Point(313, 331);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(136, 29);
            buttonAtras.TabIndex = 19;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += ButtonAtras_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.White;
            buttonGuardar.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonGuardar.FlatAppearance.BorderSize = 2;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(486, 331);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(136, 29);
            buttonGuardar.TabIndex = 18;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += ButtonGuardar_Click;
            // 
            // listBoxFuentes
            // 
            listBoxFuentes.FormattingEnabled = true;
            listBoxFuentes.ItemHeight = 15;
            listBoxFuentes.Location = new Point(133, 140);
            listBoxFuentes.Name = "listBoxFuentes";
            listBoxFuentes.Size = new Size(142, 154);
            listBoxFuentes.TabIndex = 20;
            // 
            // listBoxColorTexto
            // 
            listBoxColorTexto.FormattingEnabled = true;
            listBoxColorTexto.ItemHeight = 15;
            listBoxColorTexto.Location = new Point(307, 140);
            listBoxColorTexto.Name = "listBoxColorTexto";
            listBoxColorTexto.Size = new Size(142, 154);
            listBoxColorTexto.TabIndex = 21;
            // 
            // listBoxFondos
            // 
            listBoxFondos.FormattingEnabled = true;
            listBoxFondos.ItemHeight = 15;
            listBoxFondos.Location = new Point(480, 140);
            listBoxFondos.Name = "listBoxFondos";
            listBoxFondos.Size = new Size(142, 154);
            listBoxFondos.TabIndex = 22;
            // 
            // formConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(734, 414);
            Controls.Add(listBoxFondos);
            Controls.Add(listBoxColorTexto);
            Controls.Add(listBoxFuentes);
            Controls.Add(buttonAtras);
            Controls.Add(buttonGuardar);
            Controls.Add(labelFondo);
            Controls.Add(labelColorTexto);
            Controls.Add(labelConfiguraciones);
            Controls.Add(labelFuente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formConfiguracion";
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelConfiguraciones;
        private Label labelFuente;
        private Label labelColorTexto;
        private Label labelFondo;
        private Button buttonAtras;
        private Button buttonGuardar;
        private BindingSource inventarioBindingSource;
        private ListBox listBoxFuentes;
        private ListBox listBoxColorTexto;
        private ListBox listBoxFondos;
    }
}