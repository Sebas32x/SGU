using System.Data;
using Logica;
using Sistema.DTOs;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Comprobacion de espacios o valor null en los textbox:
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Login f = new Login();

            LoginDTO credencialesDeSesion = new LoginDTO()
            {
                user_name = txtNombreUsuario.Text.Trim(),
                password = txtContraseña.Text.Trim()
            };


            bool loginExitoso = f.Login1(credencialesDeSesion);

            if (loginExitoso)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
