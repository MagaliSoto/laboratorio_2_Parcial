namespace Soto.Magali.Parcial
{
    partial class FormProcesoCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcesoCrearProducto));
            label1 = new Label();
            labelPasosParaCrearProducto = new Label();
            SuspendLayout();
            // 
            // labelColorTexto
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(173, 66);
            label1.Name = "labelColorTexto";
            label1.Size = new Size(240, 30);
            label1.TabIndex = 0;
            label1.Text = "Creando el producto...";
            // 
            // labelPasosParaCrearProducto
            // 
            labelPasosParaCrearProducto.BackColor = Color.Transparent;
            labelPasosParaCrearProducto.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelPasosParaCrearProducto.ForeColor = Color.PaleVioletRed;
            labelPasosParaCrearProducto.ImageAlign = ContentAlignment.TopCenter;
            labelPasosParaCrearProducto.Location = new Point(127, 127);
            labelPasosParaCrearProducto.Name = "labelPasosParaCrearProducto";
            labelPasosParaCrearProducto.Size = new Size(323, 127);
            labelPasosParaCrearProducto.TabIndex = 1;
            labelPasosParaCrearProducto.Text = "Este proceso puede tardar unos minutos";
            labelPasosParaCrearProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formProcesoCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(562, 374);
            ControlBox = false;
            Controls.Add(labelPasosParaCrearProducto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formProcesoCrearProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antiguedad del producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelPasosParaCrearProducto;
    }
}