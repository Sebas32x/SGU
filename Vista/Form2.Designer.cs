namespace Vista
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btn10VolverAtras = new Button();
            btnModificacion = new Button();
            btnRealizarBajaPersona = new Button();
            btnRealizarALtaPersona = new Button();
            label15 = new Label();
            label11 = new Label();
            txtDebeCambiarPassword = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtDiasValidezPassword = new TextBox();
            label8 = new Label();
            btnRealizarBajaUsuario = new Button();
            btnRealizarALtaUsuario = new Button();
            label7 = new Label();
            cmbNombresUsuarios = new ComboBox();
            cmbPermisos = new ComboBox();
            cmbRoles = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnSeccionRemoverRolPermiso = new Button();
            label1 = new Label();
            btnSeccionOtorgarRolPermiso = new Button();
            btnSeccionRegistrar = new Button();
            btnSeccionUserABM = new Button();
            panel1 = new Panel();
            cmbPersonas = new ComboBox();
            txtNombreUsuario = new TextBox();
            label2 = new Label();
            txtEstadoActividadUsuario = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn10VolverAtras
            // 
            btn10VolverAtras.Location = new Point(239, 36);
            btn10VolverAtras.Name = "btn10VolverAtras";
            btn10VolverAtras.Size = new Size(75, 23);
            btn10VolverAtras.TabIndex = 65;
            btn10VolverAtras.Text = "<-";
            btn10VolverAtras.UseVisualStyleBackColor = true;
            btn10VolverAtras.Click += button10_Click;
            // 
            // btnModificacion
            // 
            btnModificacion.BackColor = SystemColors.Highlight;
            btnModificacion.Location = new Point(670, 339);
            btnModificacion.Name = "btnModificacion";
            btnModificacion.Size = new Size(109, 37);
            btnModificacion.TabIndex = 64;
            btnModificacion.Text = "MODIFICACION";
            btnModificacion.UseVisualStyleBackColor = false;
            btnModificacion.Click += button9_Click;
            // 
            // btnRealizarBajaPersona
            // 
            btnRealizarBajaPersona.BackColor = SystemColors.Highlight;
            btnRealizarBajaPersona.Location = new Point(670, 281);
            btnRealizarBajaPersona.Name = "btnRealizarBajaPersona";
            btnRealizarBajaPersona.Size = new Size(93, 37);
            btnRealizarBajaPersona.TabIndex = 63;
            btnRealizarBajaPersona.Text = "BAJA";
            btnRealizarBajaPersona.UseVisualStyleBackColor = false;
            btnRealizarBajaPersona.Click += button8_Click;
            // 
            // btnRealizarALtaPersona
            // 
            btnRealizarALtaPersona.BackColor = SystemColors.Highlight;
            btnRealizarALtaPersona.Location = new Point(670, 234);
            btnRealizarALtaPersona.Name = "btnRealizarALtaPersona";
            btnRealizarALtaPersona.Size = new Size(93, 41);
            btnRealizarALtaPersona.TabIndex = 62;
            btnRealizarALtaPersona.Text = "ALTA";
            btnRealizarALtaPersona.UseVisualStyleBackColor = false;
            btnRealizarALtaPersona.Click += button7_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(268, 216);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 60;
            label15.Text = "Persona";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(290, 352);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 52;
            label11.Text = "Activo 0,1";
            // 
            // txtDebeCambiarPassword
            // 
            txtDebeCambiarPassword.Location = new Point(417, 311);
            txtDebeCambiarPassword.Name = "txtDebeCambiarPassword";
            txtDebeCambiarPassword.Size = new Size(100, 23);
            txtDebeCambiarPassword.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 293);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 50;
            label10.Text = "DebeCambiarPass";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 293);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 49;
            label9.Text = "DiasValidezPass";
            // 
            // txtDiasValidezPassword
            // 
            txtDiasValidezPassword.Location = new Point(280, 311);
            txtDiasValidezPassword.Name = "txtDiasValidezPassword";
            txtDiasValidezPassword.Size = new Size(100, 23);
            txtDiasValidezPassword.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 137);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 47;
            // 
            // btnRealizarBajaUsuario
            // 
            btnRealizarBajaUsuario.BackColor = SystemColors.Highlight;
            btnRealizarBajaUsuario.Location = new Point(603, 147);
            btnRealizarBajaUsuario.Name = "btnRealizarBajaUsuario";
            btnRealizarBajaUsuario.Size = new Size(150, 42);
            btnRealizarBajaUsuario.TabIndex = 46;
            btnRealizarBajaUsuario.Text = "BAJA";
            btnRealizarBajaUsuario.UseVisualStyleBackColor = false;
            btnRealizarBajaUsuario.Click += button6_Click;
            // 
            // btnRealizarALtaUsuario
            // 
            btnRealizarALtaUsuario.BackColor = SystemColors.Highlight;
            btnRealizarALtaUsuario.Location = new Point(603, 89);
            btnRealizarALtaUsuario.Name = "btnRealizarALtaUsuario";
            btnRealizarALtaUsuario.Size = new Size(150, 45);
            btnRealizarALtaUsuario.TabIndex = 45;
            btnRealizarALtaUsuario.Text = "ALTA";
            btnRealizarALtaUsuario.UseVisualStyleBackColor = false;
            btnRealizarALtaUsuario.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 83);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 44;
            label7.Text = "Usuario";
            // 
            // cmbNombresUsuarios
            // 
            cmbNombresUsuarios.FormattingEnabled = true;
            cmbNombresUsuarios.Location = new Point(258, 101);
            cmbNombresUsuarios.Name = "cmbNombresUsuarios";
            cmbNombresUsuarios.Size = new Size(121, 23);
            cmbNombresUsuarios.TabIndex = 43;
            // 
            // cmbPermisos
            // 
            cmbPermisos.FormattingEnabled = true;
            cmbPermisos.Location = new Point(259, 158);
            cmbPermisos.Name = "cmbPermisos";
            cmbPermisos.Size = new Size(121, 23);
            cmbPermisos.TabIndex = 42;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(414, 101);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(121, 23);
            cmbRoles.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 140);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 40;
            label5.Text = "Permiso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 83);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 39;
            label4.Text = "Roles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-27, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSeccionRemoverRolPermiso
            // 
            btnSeccionRemoverRolPermiso.BackColor = SystemColors.GradientActiveCaption;
            btnSeccionRemoverRolPermiso.Location = new Point(3, 192);
            btnSeccionRemoverRolPermiso.Name = "btnSeccionRemoverRolPermiso";
            btnSeccionRemoverRolPermiso.Size = new Size(243, 82);
            btnSeccionRemoverRolPermiso.TabIndex = 2;
            btnSeccionRemoverRolPermiso.Text = "Remo:Rol/Per";
            btnSeccionRemoverRolPermiso.UseVisualStyleBackColor = false;
            btnSeccionRemoverRolPermiso.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 27);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 37;
            label1.Text = "Usuario Administrador";
            // 
            // btnSeccionOtorgarRolPermiso
            // 
            btnSeccionOtorgarRolPermiso.BackColor = SystemColors.GradientInactiveCaption;
            btnSeccionOtorgarRolPermiso.Location = new Point(3, 122);
            btnSeccionOtorgarRolPermiso.Name = "btnSeccionOtorgarRolPermiso";
            btnSeccionOtorgarRolPermiso.Size = new Size(239, 80);
            btnSeccionOtorgarRolPermiso.TabIndex = 2;
            btnSeccionOtorgarRolPermiso.Text = "Otorgar:Rol/Per";
            btnSeccionOtorgarRolPermiso.UseVisualStyleBackColor = false;
            btnSeccionOtorgarRolPermiso.Click += button1_Click;
            // 
            // btnSeccionRegistrar
            // 
            btnSeccionRegistrar.BackColor = SystemColors.GradientActiveCaption;
            btnSeccionRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnSeccionRegistrar.Location = new Point(3, 270);
            btnSeccionRegistrar.Name = "btnSeccionRegistrar";
            btnSeccionRegistrar.Size = new Size(242, 95);
            btnSeccionRegistrar.TabIndex = 2;
            btnSeccionRegistrar.Text = "REGISTAR";
            btnSeccionRegistrar.UseVisualStyleBackColor = false;
            btnSeccionRegistrar.Click += button2_Click;
            // 
            // btnSeccionUserABM
            // 
            btnSeccionUserABM.Location = new Point(-5, 354);
            btnSeccionUserABM.Name = "btnSeccionUserABM";
            btnSeccionUserABM.Size = new Size(250, 92);
            btnSeccionUserABM.TabIndex = 37;
            btnSeccionUserABM.Text = "A/B/M user";
            btnSeccionUserABM.UseVisualStyleBackColor = true;
            btnSeccionUserABM.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnSeccionUserABM);
            panel1.Controls.Add(btnSeccionOtorgarRolPermiso);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSeccionRegistrar);
            panel1.Controls.Add(btnSeccionRemoverRolPermiso);
            panel1.Location = new Point(-9, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 446);
            panel1.TabIndex = 38;
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(268, 234);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 23);
            cmbPersonas.TabIndex = 66;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(430, 234);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 211);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 68;
            label2.Text = "nombre_usuario";
            // 
            // txtEstadoActividadUsuario
            // 
            txtEstadoActividadUsuario.Location = new Point(288, 370);
            txtEstadoActividadUsuario.Name = "txtEstadoActividadUsuario";
            txtEstadoActividadUsuario.Size = new Size(100, 23);
            txtEstadoActividadUsuario.TabIndex = 53;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(559, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 281);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 70;
            label3.Text = "Password";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(cmbPersonas);
            Controls.Add(btn10VolverAtras);
            Controls.Add(btnModificacion);
            Controls.Add(btnRealizarBajaPersona);
            Controls.Add(btnRealizarALtaPersona);
            Controls.Add(label15);
            Controls.Add(txtEstadoActividadUsuario);
            Controls.Add(label11);
            Controls.Add(txtDebeCambiarPassword);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtDiasValidezPassword);
            Controls.Add(label8);
            Controls.Add(btnRealizarBajaUsuario);
            Controls.Add(btnRealizarALtaUsuario);
            Controls.Add(label7);
            Controls.Add(cmbNombresUsuarios);
            Controls.Add(cmbPermisos);
            Controls.Add(cmbRoles);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn10VolverAtras;
        private Button btnModificacion;
        private Button btnRealizarBajaPersona;
        private Button btnRealizarALtaPersona;
        private Label label15;
        private Label label11;
        private TextBox txtDebeCambiarPassword;
        private Label label10;
        private Label label9;
        private TextBox txtDiasValidezPassword;
        private Label label8;
        private Button btnRealizarBajaUsuario;
        private Button btnRealizarALtaUsuario;
        private Label label7;
        private ComboBox cmbNombresUsuarios;
        private ComboBox cmbPermisos;
        private ComboBox cmbRoles;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnSeccionRemoverRolPermiso;
        private Label label1;
        private Button btnSeccionOtorgarRolPermiso;
        private Button btnSeccionRegistrar;
        private Button btnSeccionUserABM;
        private Panel panel1;
        private ComboBox cmbPersonas;
        private TextBox txtNombreUsuario;
        private Label label2;
        private TextBox txtEstadoActividadUsuario;
        private TextBox txtPassword;
        private Label label3;
    }
}