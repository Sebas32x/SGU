namespace Vista
{
    partial class Form3
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
            textBox4 = new TextBox();
            label11 = new Label();
            cmbPartidos = new ComboBox();
            label13 = new Label();
            dtmFechaNacimiento = new DateTimePicker();
            btnVolverAtras = new Button();
            cmbLocalidades = new ComboBox();
            label12 = new Label();
            cmbProvincias = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDepartamentoDomicilio = new TextBox();
            txtPisoDomicilio = new TextBox();
            txtAlturaDomicilio = new TextBox();
            txtNombreCalleDomicilio = new TextBox();
            btnRegistrar = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtImagenUrlPersona = new TextBox();
            txtNumeroDniPersona = new TextBox();
            txtApellidoPersona = new TextBox();
            txtNombrePersona = new TextBox();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(456, 383);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 63;
            textBox4.Text = "txtCodigoPostalDomicilio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(363, 383);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 62;
            label11.Text = "CodigPostal";
            // 
            // cmbPartidos
            // 
            cmbPartidos.FormattingEnabled = true;
            cmbPartidos.Location = new Point(452, 340);
            cmbPartidos.Name = "cmbPartidos";
            cmbPartidos.Size = new Size(121, 23);
            cmbPartidos.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(389, 339);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 60;
            label13.Text = "partido";
            // 
            // dtmFechaNacimiento
            // 
            dtmFechaNacimiento.Location = new Point(36, 275);
            dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            dtmFechaNacimiento.Size = new Size(232, 23);
            dtmFechaNacimiento.TabIndex = 59;
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Location = new Point(32, 19);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(65, 31);
            btnVolverAtras.TabIndex = 58;
            btnVolverAtras.Text = "<-";
            btnVolverAtras.UseVisualStyleBackColor = true;
            btnVolverAtras.Click += button2_Click;
            // 
            // cmbLocalidades
            // 
            cmbLocalidades.FormattingEnabled = true;
            cmbLocalidades.Location = new Point(456, 259);
            cmbLocalidades.Name = "cmbLocalidades";
            cmbLocalidades.Size = new Size(121, 23);
            cmbLocalidades.TabIndex = 57;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(376, 294);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 56;
            label12.Text = "provincia";
            // 
            // cmbProvincias
            // 
            cmbProvincias.FormattingEnabled = true;
            cmbProvincias.Location = new Point(452, 294);
            cmbProvincias.Name = "cmbProvincias";
            cmbProvincias.Size = new Size(121, 23);
            cmbProvincias.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 212);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 54;
            label6.Text = "dto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(376, 259);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 53;
            label7.Text = "Localidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 164);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 52;
            label8.Text = "piso";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 111);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 51;
            label9.Text = "altura";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 70);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 50;
            label10.Text = "Dom calle";
            // 
            // txtDepartamentoDomicilio
            // 
            txtDepartamentoDomicilio.Location = new Point(452, 204);
            txtDepartamentoDomicilio.Name = "txtDepartamentoDomicilio";
            txtDepartamentoDomicilio.Size = new Size(125, 23);
            txtDepartamentoDomicilio.TabIndex = 49;
            // 
            // txtPisoDomicilio
            // 
            txtPisoDomicilio.Location = new Point(452, 156);
            txtPisoDomicilio.Name = "txtPisoDomicilio";
            txtPisoDomicilio.Size = new Size(125, 23);
            txtPisoDomicilio.TabIndex = 48;
            // 
            // txtAlturaDomicilio
            // 
            txtAlturaDomicilio.Location = new Point(452, 108);
            txtAlturaDomicilio.Name = "txtAlturaDomicilio";
            txtAlturaDomicilio.Size = new Size(125, 23);
            txtAlturaDomicilio.TabIndex = 47;
            // 
            // txtNombreCalleDomicilio
            // 
            txtNombreCalleDomicilio.Location = new Point(452, 67);
            txtNombreCalleDomicilio.Name = "txtNombreCalleDomicilio";
            txtNombreCalleDomicilio.Size = new Size(125, 23);
            txtNombreCalleDomicilio.TabIndex = 46;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(646, 367);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(123, 64);
            btnRegistrar.TabIndex = 45;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 253);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 44;
            label4.Text = "Fecha_nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 204);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 43;
            label5.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 159);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 42;
            label3.Text = "Imagen_Url";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 103);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 41;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 65);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // txtImagenUrlPersona
            // 
            txtImagenUrlPersona.Location = new Point(109, 159);
            txtImagenUrlPersona.Name = "txtImagenUrlPersona";
            txtImagenUrlPersona.Size = new Size(125, 23);
            txtImagenUrlPersona.TabIndex = 39;
            // 
            // txtNumeroDniPersona
            // 
            txtNumeroDniPersona.Location = new Point(109, 201);
            txtNumeroDniPersona.Name = "txtNumeroDniPersona";
            txtNumeroDniPersona.Size = new Size(125, 23);
            txtNumeroDniPersona.TabIndex = 38;
            // 
            // txtApellidoPersona
            // 
            txtApellidoPersona.Location = new Point(109, 103);
            txtApellidoPersona.Name = "txtApellidoPersona";
            txtApellidoPersona.Size = new Size(125, 23);
            txtApellidoPersona.TabIndex = 37;
            // 
            // txtNombrePersona
            // 
            txtNombrePersona.Location = new Point(109, 62);
            txtNombrePersona.Name = "txtNombrePersona";
            txtNombrePersona.Size = new Size(125, 23);
            txtNombrePersona.TabIndex = 36;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label11);
            Controls.Add(cmbPartidos);
            Controls.Add(label13);
            Controls.Add(dtmFechaNacimiento);
            Controls.Add(btnVolverAtras);
            Controls.Add(cmbLocalidades);
            Controls.Add(label12);
            Controls.Add(cmbProvincias);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtDepartamentoDomicilio);
            Controls.Add(txtPisoDomicilio);
            Controls.Add(txtAlturaDomicilio);
            Controls.Add(txtNombreCalleDomicilio);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImagenUrlPersona);
            Controls.Add(txtNumeroDniPersona);
            Controls.Add(txtApellidoPersona);
            Controls.Add(txtNombrePersona);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label11;
        private ComboBox cmbPartidos;
        private Label label13;
        private DateTimePicker dtmFechaNacimiento;
        private Button btnVolverAtras;
        private ComboBox cmbLocalidades;
        private Label label12;
        private ComboBox cmbProvincias;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDepartamentoDomicilio;
        private TextBox txtPisoDomicilio;
        private TextBox txtAlturaDomicilio;
        private TextBox txtNombreCalleDomicilio;
        private Button btnRegistrar;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtImagenUrlPersona;
        private TextBox txtNumeroDniPersona;
        private TextBox txtApellidoPersona;
        private TextBox txtNombrePersona;
    }
}