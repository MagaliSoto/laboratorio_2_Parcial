namespace Soto.Magali.Parcial
{
    partial class FormLineaDeProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLineaDeProduccion));
            listBoxProducto = new ListBox();
            listBoxMercaderia = new ListBox();
            listBoxCantidad = new ListBox();
            labelMercaderia = new Label();
            labelCantidad = new Label();
            labelProducto = new Label();
            buttonProducir = new Button();
            labelCantidadAProducir = new Label();
            numericUpDownCantidadAProducir = new NumericUpDown();
            buttonAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadAProducir).BeginInit();
            SuspendLayout();
            // 
            // listBoxProducto
            // 
            listBoxProducto.FormattingEnabled = true;
            listBoxProducto.ItemHeight = 15;
            listBoxProducto.Items.AddRange(new object[] { "Conito", "Chocotorta" });
            listBoxProducto.Location = new Point(24, 46);
            listBoxProducto.Name = "listBoxProducto";
            listBoxProducto.Size = new Size(120, 34);
            listBoxProducto.TabIndex = 0;
            listBoxProducto.SelectedIndexChanged += ListBoxProducto_SelectedIndexChanged_1;
            // 
            // listBoxMercaderia
            // 
            listBoxMercaderia.BackColor = SystemColors.Window;
            listBoxMercaderia.FormattingEnabled = true;
            listBoxMercaderia.ItemHeight = 15;
            listBoxMercaderia.Location = new Point(150, 46);
            listBoxMercaderia.Name = "listBoxMercaderia";
            listBoxMercaderia.SelectionMode = SelectionMode.None;
            listBoxMercaderia.Size = new Size(120, 229);
            listBoxMercaderia.TabIndex = 7;
            // 
            // listBoxCantidad
            // 
            listBoxCantidad.FormattingEnabled = true;
            listBoxCantidad.ItemHeight = 15;
            listBoxCantidad.Location = new Point(276, 46);
            listBoxCantidad.Name = "listBoxCantidad";
            listBoxCantidad.SelectionMode = SelectionMode.None;
            listBoxCantidad.Size = new Size(120, 139);
            listBoxCantidad.TabIndex = 12;
            // 
            // labelMercaderia
            // 
            labelMercaderia.BackColor = Color.Transparent;
            labelMercaderia.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMercaderia.ForeColor = Color.Crimson;
            labelMercaderia.Location = new Point(148, 15);
            labelMercaderia.Name = "labelMercaderia";
            labelMercaderia.Size = new Size(120, 28);
            labelMercaderia.TabIndex = 6;
            labelMercaderia.Text = "Mercaderia";
            labelMercaderia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCantidad
            // 
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidad.ForeColor = Color.Crimson;
            labelCantidad.Location = new Point(276, 18);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(120, 28);
            labelCantidad.TabIndex = 11;
            labelCantidad.Text = "Cantidad";
            labelCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProducto
            // 
            labelProducto.BackColor = Color.Transparent;
            labelProducto.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProducto.ForeColor = Color.Crimson;
            labelProducto.Location = new Point(24, 15);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(120, 28);
            labelProducto.TabIndex = 10;
            labelProducto.Text = "Producto";
            labelProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProducir
            // 
            buttonProducir.BackColor = Color.White;
            buttonProducir.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonProducir.FlatAppearance.BorderSize = 2;
            buttonProducir.FlatStyle = FlatStyle.Flat;
            buttonProducir.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProducir.Location = new Point(276, 249);
            buttonProducir.Name = "buttonProducir";
            buttonProducir.Size = new Size(120, 29);
            buttonProducir.TabIndex = 9;
            buttonProducir.Text = "Producir";
            buttonProducir.UseVisualStyleBackColor = false;
            buttonProducir.Click += ButtonProducir_Click;
            // 
            // labelCantidadAProducir
            // 
            labelCantidadAProducir.BackColor = Color.Transparent;
            labelCantidadAProducir.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidadAProducir.ForeColor = Color.Crimson;
            labelCantidadAProducir.Location = new Point(24, 83);
            labelCantidadAProducir.Name = "labelCantidadAProducir";
            labelCantidadAProducir.Size = new Size(120, 45);
            labelCantidadAProducir.TabIndex = 14;
            labelCantidadAProducir.Text = "Cantidad a producir";
            labelCantidadAProducir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownCantidadAProducir
            // 
            numericUpDownCantidadAProducir.Location = new Point(24, 131);
            numericUpDownCantidadAProducir.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownCantidadAProducir.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantidadAProducir.Name = "numericUpDownCantidadAProducir";
            numericUpDownCantidadAProducir.Size = new Size(120, 23);
            numericUpDownCantidadAProducir.TabIndex = 15;
            numericUpDownCantidadAProducir.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.White;
            buttonAtras.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonAtras.FlatAppearance.BorderSize = 2;
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.Location = new Point(24, 249);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(120, 29);
            buttonAtras.TabIndex = 16;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += ButtonAtras_Click;
            // 
            // FormLineaDeProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(545, 296);
            ControlBox = false;
            Controls.Add(buttonAtras);
            Controls.Add(numericUpDownCantidadAProducir);
            Controls.Add(labelCantidadAProducir);
            Controls.Add(listBoxCantidad);
            Controls.Add(labelCantidad);
            Controls.Add(labelProducto);
            Controls.Add(buttonProducir);
            Controls.Add(listBoxMercaderia);
            Controls.Add(labelMercaderia);
            Controls.Add(listBoxProducto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLineaDeProduccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Linea de Produccion";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadAProducir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProducto;
        private ListBox listBoxMercaderia;
        private ListBox listBoxCantidad;
        private Label labelMercaderia;
        private Label labelCantidad;
        private Label labelProducto;
        private Label labelCantidadAProducir;
        private Button buttonProducir;
        private Button buttonAtras;
        private NumericUpDown numericUpDownCantidadAProducir;
    }
}