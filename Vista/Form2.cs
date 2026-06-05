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
            btnRealizarALtaUsuario.Visible = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Ocultar();

            UsuariosABM a = new UsuariosABM();
            cmbPersonas.DataSource = a.ObtenerPersonas();
            cmbPersonas.DisplayMember = "Nombre";
            cmbPersonas.ValueMember = "Id_Persona";

            OrtorgarRol_Permis f = new OrtorgarRol_Permis();
            cmbRoles.DataSource = f.ObtenerRoles();
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "Id_Rol";

            cmbPermisos.DataSource = f.ObtenerPermisos();
            cmbPermisos.DisplayMember = "Descripcion";
            cmbPermisos.ValueMember = "Id_Permisos";

            // USUARIOS
            cmbNombresUsuarios.DataSource = f.ObtenerUsuarios();
            cmbNombresUsuarios.DisplayMember = "user_name";
            cmbNombresUsuarios.ValueMember = "Id_usuario";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbNombresUsuarios.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }
                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un rol");
                    return;
                }
                if (cmbPermisos.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un permiso");
                    return;
                }

                PermRolDTO dto = new PermRolDTO()
                {
                    Id_usuario = Convert.ToInt32(cmbNombresUsuarios.SelectedValue),
                    Id_Rol = Convert.ToInt32(cmbRoles.SelectedValue),
                    Id_Permisos = Convert.ToInt32(cmbPermisos.SelectedValue)
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


            cmbRoles.Visible = true;
            cmbPermisos.Visible = true;
            cmbNombresUsuarios.Visible = true;
        }

        private void Ocultar()
        {

            cmbRoles.Visible = false;
            cmbPermisos.Visible = false;
            cmbNombresUsuarios.Visible = false;
            cmbPersonas.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;



            txtNombreUsuario.Visible = false;
            txtPassword.Visible = false;
            txtDiasValidezPassword.Visible = false;
            txtDebeCambiarPassword.Visible = false;
            txtEstadoActividadUsuario.Visible = false;




            label15.Visible = false;

            btnRealizarALtaUsuario.Visible = false;
            btnRealizarBajaUsuario.Visible = false;
            btnRealizarALtaPersona.Visible = false;
            btnRealizarBajaPersona.Visible = false;
            btnModificacion.Visible = false;
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

            txtNombreUsuario.Visible = true;
            txtDiasValidezPassword.Visible = true;
            txtDebeCambiarPassword.Visible = true;
            txtEstadoActividadUsuario.Visible = true;
            cmbNombresUsuarios.Visible = true;

            btnRealizarBajaPersona.Visible = true;
            btnModificacion.Visible = true;
            btnRealizarALtaPersona.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoria1();
            btnRealizarBajaUsuario.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNombresUsuarios.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }
                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un rol");
                    return;
                }
                if (cmbPermisos.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un permiso");
                    return;
                }

                PermRolDTO dto = new PermRolDTO()
                {
                    Id_usuario = Convert.ToInt32(cmbNombresUsuarios.SelectedValue),
                    Id_Rol = Convert.ToInt32(cmbRoles.SelectedValue),
                    Id_Permisos = Convert.ToInt32(cmbPermisos.SelectedValue)
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
            txtNombreUsuario.Visible = true;
            cmbRoles.Visible = true;
            cmbPersonas.Visible = true;
            txtPassword.Visible = true;
            label3.Visible = true;
            label2.Visible = true;




        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersonas.SelectedValue == null || cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná una persona y un rol");
                    return;
                }

                if (!int.TryParse(txtDiasValidezPassword.Text, out int diasValidezPass))
                {
                    MessageBox.Show("Ingrese un número válido para los días de validez.");
                    return;
                }


                ABMuser dto = new ABMuser()
                {
                    Id_Persona = Convert.ToInt32(cmbPersonas.SelectedValue),
                    Id_Rol = Convert.ToInt32(cmbRoles.SelectedValue),

                    user_name = txtNombreUsuario.Text.Trim(),
                    Password = txtPassword.Text.Trim(),

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
                if (cmbNombresUsuarios.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario");
                    return;
                }

                ABMuser dto = new ABMuser()
                {
                    user_name = cmbNombresUsuarios.Text

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
                if (cmbNombresUsuarios.SelectedValue == null || cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná un usuario y rol");
                    return;
                }

                ABMuser dto = new ABMuser()
                {
                    user_name = cmbNombresUsuarios.Text,
                    Id_Rol = Convert.ToInt32(cmbRoles.SelectedValue)

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
