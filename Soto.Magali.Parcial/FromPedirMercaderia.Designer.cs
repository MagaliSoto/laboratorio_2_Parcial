namespace Soto.Magali.Parcial
{
    partial class FormPedirMercaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedirMercaderia));
            listBoxMercaderia = new ListBox();
            numericUpDownCantidad = new NumericUpDown();
            buttonPedir = new Button();
            labelMercaderia = new Label();
            labelCantidad = new Label();
            buttonAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            SuspendLayout();
            // 
            // listBoxMercaderia
            // 
            listBoxMercaderia.BackColor = SystemColors.Window;
            listBoxMercaderia.FormattingEnabled = true;
            listBoxMercaderia.ItemHeight = 15;
            listBoxMercaderia.Items.AddRange(new object[] { "Dulce de leche", "Queso crema", "Galletita de vainilla", "Galletita de chocolate", "Chocolate", "Cafe", "Envoltorio", "Recipiente" });
            listBoxMercaderia.Location = new Point(12, 40);
            listBoxMercaderia.Name = "listBoxMercaderia";
            listBoxMercaderia.Size = new Size(120, 229);
            listBoxMercaderia.TabIndex = 0;
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(140, 40);
            numericUpDownCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 23);
            numericUpDownCantidad.TabIndex = 1;
            numericUpDownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonPedir
            // 
            buttonPedir.BackColor = Color.White;
            buttonPedir.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonPedir.FlatAppearance.BorderSize = 2;
            buttonPedir.FlatStyle = FlatStyle.Flat;
            buttonPedir.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPedir.Location = new Point(140, 205);
            buttonPedir.Name = "buttonPedir";
            buttonPedir.Size = new Size(120, 29);
            buttonPedir.TabIndex = 2;
            buttonPedir.Text = "Pedir";
            buttonPedir.UseVisualStyleBackColor = false;
            buttonPedir.Click += ButtonPedir_Click;
            // 
            // labelMercaderia
            // 
            labelMercaderia.BackColor = Color.Transparent;
            labelMercaderia.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMercaderia.ForeColor = Color.Crimson;
            labelMercaderia.Location = new Point(12, 9);
            labelMercaderia.Name = "labelMercaderia";
            labelMercaderia.Size = new Size(120, 28);
            labelMercaderia.TabIndex = 5;
            labelMercaderia.Text = "Mercaderia";
            labelMercaderia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCantidad
            // 
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidad.ForeColor = Color.Crimson;
            labelCantidad.Location = new Point(140, 9);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(120, 28);
            labelCantidad.TabIndex = 6;
            labelCantidad.Text = "Cantidad";
            labelCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.White;
            buttonAtras.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonAtras.FlatAppearance.BorderSize = 2;
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.Location = new Point(140, 240);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(120, 29);
            buttonAtras.TabIndex = 7;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += ButtonAtras_Click;
            // 
            // FormPedirMercaderia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(415, 308);
            ControlBox = false;
            Controls.Add(buttonAtras);
            Controls.Add(labelCantidad);
            Controls.Add(labelMercaderia);
            Controls.Add(buttonPedir);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(listBoxMercaderia);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPedirMercaderia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedir Mercaderia";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxMercaderia;
        private NumericUpDown numericUpDownCantidad;
        private Button buttonPedir;
        private Button buttonAtras;
        private Label labelMercaderia;
        private Label labelCantidad;
    }
}