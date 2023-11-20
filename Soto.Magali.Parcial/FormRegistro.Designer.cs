namespace Soto.Magali.Parcial
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            textBoxContraseña = new TextBox();
            textBoxNombreDeUsuario = new TextBox();
            labelRegistrarUsuario = new Label();
            labelContraseña = new Label();
            labelNombreDeUsuario = new Label();
            buttonRegistrar = new Button();
            buttonAtras = new Button();
            listBoxRol = new ListBox();
            labelRol = new Label();
            buttonMostrarUsuarios = new Button();
            SuspendLayout();
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(451, 197);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(156, 23);
            textBoxContraseña.TabIndex = 10;
            // 
            // textBoxNombreDeUsuario
            // 
            textBoxNombreDeUsuario.Location = new Point(451, 158);
            textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            textBoxNombreDeUsuario.Size = new Size(156, 23);
            textBoxNombreDeUsuario.TabIndex = 9;
            // 
            // labelRegistrarUsuario
            // 
            labelRegistrarUsuario.BackColor = Color.Transparent;
            labelRegistrarUsuario.Font = new Font("Sitka Text", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRegistrarUsuario.ForeColor = Color.PaleVioletRed;
            labelRegistrarUsuario.Location = new Point(12, 79);
            labelRegistrarUsuario.Name = "labelRegistrarUsuario";
            labelRegistrarUsuario.Size = new Size(719, 39);
            labelRegistrarUsuario.TabIndex = 8;
            labelRegistrarUsuario.Text = "Registro de usuario";
            labelRegistrarUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelContraseña
            // 
            labelContraseña.BackColor = Color.Transparent;
            labelContraseña.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.ForeColor = Color.Crimson;
            labelContraseña.Location = new Point(127, 186);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(180, 39);
            labelContraseña.TabIndex = 7;
            labelContraseña.Text = "Contraseña";
            labelContraseña.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombreDeUsuario
            // 
            labelNombreDeUsuario.BackColor = Color.Transparent;
            labelNombreDeUsuario.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreDeUsuario.ForeColor = Color.Crimson;
            labelNombreDeUsuario.Location = new Point(127, 147);
            labelNombreDeUsuario.Name = "labelNombreDeUsuario";
            labelNombreDeUsuario.Size = new Size(180, 39);
            labelNombreDeUsuario.TabIndex = 6;
            labelNombreDeUsuario.Text = "Nombre de usuario";
            labelNombreDeUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.White;
            buttonRegistrar.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonRegistrar.FlatAppearance.BorderSize = 2;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrar.ForeColor = SystemColors.ControlText;
            buttonRegistrar.Location = new Point(451, 284);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(156, 31);
            buttonRegistrar.TabIndex = 11;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += ButtonRegistrar_Click;
            // 
            // buttonAtras
            // 
            buttonAtras.BackColor = Color.White;
            buttonAtras.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonAtras.FlatAppearance.BorderSize = 2;
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.ForeColor = SystemColors.ControlText;
            buttonAtras.Location = new Point(289, 284);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(156, 31);
            buttonAtras.TabIndex = 12;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = false;
            buttonAtras.Click += ButtonAtras_Click;
            // 
            // listBoxRol
            // 
            listBoxRol.FormattingEnabled = true;
            listBoxRol.ItemHeight = 15;
            listBoxRol.Items.AddRange(new object[] { "supervisor", "operario" });
            listBoxRol.Location = new Point(451, 230);
            listBoxRol.Name = "listBoxRol";
            listBoxRol.Size = new Size(156, 34);
            listBoxRol.TabIndex = 13;
            // 
            // labelRol
            // 
            labelRol.BackColor = Color.Transparent;
            labelRol.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRol.ForeColor = Color.Crimson;
            labelRol.Location = new Point(127, 225);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(180, 39);
            labelRol.TabIndex = 14;
            labelRol.Text = "Puesto";
            labelRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonMostrarUsuarios
            // 
            buttonMostrarUsuarios.BackColor = Color.White;
            buttonMostrarUsuarios.FlatAppearance.BorderColor = Color.PaleVioletRed;
            buttonMostrarUsuarios.FlatAppearance.BorderSize = 2;
            buttonMostrarUsuarios.FlatStyle = FlatStyle.Flat;
            buttonMostrarUsuarios.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMostrarUsuarios.ForeColor = SystemColors.ControlText;
            buttonMostrarUsuarios.Location = new Point(127, 284);
            buttonMostrarUsuarios.Name = "buttonMostrarUsuarios";
            buttonMostrarUsuarios.Size = new Size(156, 31);
            buttonMostrarUsuarios.TabIndex = 15;
            buttonMostrarUsuarios.Text = "Mostrar usuarios";
            buttonMostrarUsuarios.UseVisualStyleBackColor = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(743, 415);
            Controls.Add(buttonMostrarUsuarios);
            Controls.Add(labelRol);
            Controls.Add(listBoxRol);
            Controls.Add(buttonAtras);
            Controls.Add(buttonRegistrar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxNombreDeUsuario);
            Controls.Add(labelRegistrarUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(labelNombreDeUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxContraseña;
        private TextBox textBoxNombreDeUsuario;
        private Label labelRegistrarUsuario;
        private Label labelContraseña;
        private Label labelNombreDeUsuario;
        private Button buttonRegistrar;
        private Button buttonAtras;
        private ListBox listBoxRol;
        private Label labelRol;
        private Button buttonMostrarUsuarios;
    }
}