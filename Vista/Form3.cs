using Logica;
using Sistema.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtNumeroDniPersona.Text, out int dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido (solo números).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAlturaDomicilio.Text, out int altura))
                {
                    MessageBox.Show("Por favor, ingrese una altura de calle válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox4.Text, out int codigoPostal))
                {
                    MessageBox.Show("Por favor, ingrese un código postal válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (cmbProvincias.SelectedValue == null || cmbLocalidades.SelectedValue == null || cmbPartidos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione la Provincia, Partido y Localidad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int idProvincia = Convert.ToInt32(cmbProvincias.SelectedValue);
                int idLocalidad = Convert.ToInt32(cmbLocalidades.SelectedValue);
                int idPartido = Convert.ToInt32(cmbPartidos.SelectedValue);


                ViviedaDTO dto = new ViviedaDTO
                {
                    Nombre = txtNombrePersona.Text.Trim(),
                    Apellido = txtApellidoPersona.Text.Trim(),
                    DNI = dni,
                    Imagen_URL = txtImagenUrlPersona.Text.Trim(),
                    Fecha_nac = dtmFechaNacimiento.Value,
                    Calle = txtNombreCalleDomicilio.Text.Trim(),
                    Altura = altura,
                    Piso = txtPisoDomicilio.Text.Trim(),
                    Depa = txtDepartamentoDomicilio.Text.Trim(),
                    Codigo_Postal = codigoPostal,
                    Id_Provincia = idProvincia,
                    Id_Localidad = idLocalidad,
                    Id_Partido = idPartido
                };


                Registrar registrar = new Registrar();
                registrar.RegiPersonas(dto);

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Registrar f = new Registrar();
            cmbProvincias.DataSource = f.ObtenerProvincia();
            cmbProvincias.DisplayMember = "Nombre_prov";
            cmbProvincias.ValueMember = "Id_Provincia";


            cmbLocalidades.DataSource = f.ObtenerLocalidad();
            cmbLocalidades.DisplayMember = "Nombre_Local";
            cmbLocalidades.ValueMember = "Id_Localidad";

            cmbPartidos.DataSource = f.ObtenerPartido();
            cmbPartidos.DisplayMember = "Nombre_partido";
            cmbPartidos.ValueMember = "Id_Partido";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
