namespace Soto.Magali.Parcial
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelBienvenidos = new Label();
            labelNombreDeUsuario = new Label();
            labelContraseña = new Label();
            labelIniciarSesion = new Label();
            textBoxNombreDeUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonIngresar = new Button();
            buttonConfiguraciones = new Button();
            buttonRegistro = new Button();
            SuspendLayout();
            // 
            // labelBienvenidos
            // 
            labelBienvenidos.BackColor = Color.Transparent;
            labelBienvenidos.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBienvenidos.ForeColor = Color.PaleVioletRed;
            labelBienvenidos.Location = new Point(87, 55);
            labelBienvenidos.Name = "labelBienvenidos";
            labelBienvenidos.Size = new Size(562, 39);
            labelBienvenidos.TabIndex = 0;
            labelBienvenidos.Text = "BIENVENIDOS A LA PASTELERIA";
            labelBienvenidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNombreDeUsuario
            // 
            labelNombreDeUsuario.BackColor = Color.Transparent;
            labelNombreDeUsuario.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreDeUsuario.ForeColor = Color.Crimson;
            labelNombreDeUsuario.Location = new Point(127, 186);
            labelNombreDeUsuario.Name = "labelNombreDeUsuario";
            labelNombreDeUsuario.Size = new Size(180, 39);
            labelNombreDeUsuario.TabIndex = 1;
            labelNombreDeUsuario.Text = "Nombre de usuario";
            labelNombreDeUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelContraseña
            // 
            labelContraseña.BackColor = Color.Transparent;
            labelContraseña.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.ForeColor = Color.Crimson;
            labelContraseña.Location = new Point(127, 238);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(180, 39);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña";
            labelContraseña.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.BackColor = Color.Transparent;
            labelIniciarSesion.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelIniciarSesion.ForeColor = Color.PaleVioletRed;
            labelIniciarSesion.Location = new Point(87, 112);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(562, 39);
            labelIniciarSesion.TabIndex = 3;
            labelIniciarSesion.Text = "Iniciar sesión";
            labelIniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNombreDeUsuario
            // 
            textBoxNombreDeUsuario.Location = new Point(429, 197);
            textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            textBoxNombreDeUsuario.Size = new Size(156, 23);
            textBoxNombreDeUsuario.TabIndex = 4;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(429, 249);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(156, 23);
            textBoxContraseña.TabIndex = 5;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.White;
            buttonIngresar.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonIngresar.FlatAppearance.BorderSize = 2;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngresar.ForeColor = SystemColors.ControlText;
            buttonIngresar.Location = new Point(429, 302);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(156, 31);
            buttonIngresar.TabIndex = 6;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += ButtonIngresar_Click;
            // 
            // buttonConfiguraciones
            // 
            buttonConfiguraciones.BackColor = Color.White;
            buttonConfiguraciones.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonConfiguraciones.FlatAppearance.BorderSize = 2;
            buttonConfiguraciones.FlatStyle = FlatStyle.Flat;
            buttonConfiguraciones.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfiguraciones.ForeColor = SystemColors.ControlText;
            buttonConfiguraciones.Location = new Point(105, 302);
            buttonConfiguraciones.Name = "buttonConfiguraciones";
            buttonConfiguraciones.Size = new Size(156, 31);
            buttonConfiguraciones.TabIndex = 7;
            buttonConfiguraciones.Text = "Configuraciones";
            buttonConfiguraciones.UseVisualStyleBackColor = false;
            buttonConfiguraciones.Click += ButtonConfiguraciones_Click;
            // 
            // buttonRegistro
            // 
            buttonRegistro.BackColor = Color.White;
            buttonRegistro.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonRegistro.FlatAppearance.BorderSize = 2;
            buttonRegistro.FlatStyle = FlatStyle.Flat;
            buttonRegistro.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistro.ForeColor = SystemColors.ControlText;
            buttonRegistro.Location = new Point(267, 302);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(156, 31);
            buttonRegistro.TabIndex = 8;
            buttonRegistro.Text = "Registrar";
            buttonRegistro.UseVisualStyleBackColor = false;
            buttonRegistro.Click += ButtonRegistro_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(718, 401);
            Controls.Add(buttonRegistro);
            Controls.Add(buttonConfiguraciones);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxNombreDeUsuario);
            Controls.Add(labelIniciarSesion);
            Controls.Add(labelContraseña);
            Controls.Add(labelNombreDeUsuario);
            Controls.Add(labelBienvenidos);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenidos;
        private Label labelNombreDeUsuario;
        private Label labelContraseña;
        private Label labelIniciarSesion;
        private TextBox textBoxNombreDeUsuario;
        private TextBox textBoxContraseña;
        private Button buttonIngresar;
        private Button buttonConfiguraciones;
        private Button buttonRegistro;
    }
}