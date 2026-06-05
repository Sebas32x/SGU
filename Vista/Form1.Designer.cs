namespace Vista
{
    partial class Form1
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
            linkLabel1 = new LinkLabel();
            btnIniciarSesion = new Button();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(456, 229);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Se olvido la contraseña?";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            btnIniciarSesion.Location = new Point(301, 259);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(192, 29);
            btnIniciarSesion.TabIndex = 11;
            btnIniciarSesion.Text = "INICIAR SESION";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += button1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(301, 203);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(192, 23);
            txtContraseña.TabIndex = 10;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(301, 162);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(192, 23);
            txtNombreUsuario.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 206);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 8;
            label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 170);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "USUARIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnIniciarSesion;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private Label label2;
        private Label label1;
    }
}
