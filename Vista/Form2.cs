using Logica;
using Sistema.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Vista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoria1();
            button5.Visible = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Ocultar();

            UsuariosABM a = new UsuariosABM();
            comboBox4.DataSource = a.ObtenerPersonas();
            comboBox4.DisplayMember = "Nombre";
            comboBox4.ValueMember = "Id_Persona";

            OrtorgarRol_Permis f = new OrtorgarRol_Permis();
            comboBox1.DataSource = f.ObtenerRoles();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Rol";

            comboBox2.DataSource = f.ObtenerPermisos();
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Id_Permisos";

            // USUARIOS
            comboBox3.DataSource = f.ObtenerUsuarios();
            comboBox3.DisplayMember = "user_name";
            comboBox3.ValueMember = "Id_usuario";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un rol");
                    return;
                }
                if (comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un permiso");
                    return;
                }

                PermRolDTO dto = new PermRolDTO()
                {
                    Id_usuario = Convert.ToInt32(comboBox3.SelectedValue),
                    Id_Rol = Convert.ToInt32(comboBox1.SelectedValue),
                    Id_Permisos = Convert.ToInt32(comboBox2.SelectedValue)
                };

                BajaRoles f = new BajaRoles();
                f.Baja2(dto);
                MessageBox.Show("Guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            categoria2();
        }

        private void categoria1()
        {


            label4.Visible = true;
            label5.Visible = true;

            label7.Visible = true;


            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
        }

        private void Ocultar()
        {

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;



            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;




            label15.Visible = false;

            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void categoria2()
        {



            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            label4.Visible = true;
            label15.Visible = true;
            label7.Visible = true;

            textBox1.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            comboBox3.Visible = true;

            button8.Visible = true;
            button9.Visible = true;
            button7.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoria1();
            button6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un rol");
                    return;
                }
                if (comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un permiso");
                    return;
                }

                PermRolDTO dto = new PermRolDTO()
                {
                    Id_usuario = Convert.ToInt32(comboBox3.SelectedValue),
                    Id_Rol = Convert.ToInt32(comboBox1.SelectedValue),
                    Id_Permisos = Convert.ToInt32(comboBox2.SelectedValue)
                };

                OrtorgarRol_Permis f = new OrtorgarRol_Permis();
                f.Otorgar(dto);
                MessageBox.Show("Guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoria2();
            textBox1.Visible = true;
            comboBox1.Visible = true;
            comboBox4.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            label2.Visible = true;




        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.SelectedValue == null || comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná una persona y un rol");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int diasValidezPass))
                {
                    MessageBox.Show("Ingrese un número válido para los días de validez.");
                    return;
                }


                ABMuser dto = new ABMuser()
                {
                    Id_Persona = Convert.ToInt32(comboBox4.SelectedValue),
                    Id_Rol = Convert.ToInt32(comboBox1.SelectedValue),

                    user_name = textBox1.Text.Trim(),
                    Password = textBox2.Text.Trim(),

                    DiasValidezPass = diasValidezPass,
                    DebeCambiarPass = true,



                };

                UsuariosABM f = new UsuariosABM();

                if (f.ALTA(dto))
                {
                    MessageBox.Show("Guardado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }

                ABMuser dto = new ABMuser()
                {
                    user_name = comboBox3.Text

                };

                UsuariosABM f = new UsuariosABM();

                if (f.BAJA(dto))
                {
                    MessageBox.Show("Se pudo dar de baja correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null || comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario y rol");
                    return;
                }

                ABMuser dto = new ABMuser()
                {
                    user_name = comboBox3.Text,
                    Id_Rol = Convert.ToInt32(comboBox1.SelectedValue)

                };

                UsuariosABM f = new UsuariosABM();

                if (f.Modificacion(dto))
                {
                    MessageBox.Show("Se pudo modificar correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
