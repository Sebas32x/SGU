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

                if (!int.TryParse(textBox3.Text, out int dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido (solo números).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox9.Text, out int altura))
                {
                    MessageBox.Show("Por favor, ingrese una altura de calle válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox4.Text, out int codigoPostal))
                {
                    MessageBox.Show("Por favor, ingrese un código postal válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione la Provincia, Partido y Localidad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int idProvincia = Convert.ToInt32(comboBox1.SelectedValue);
                int idLocalidad = Convert.ToInt32(comboBox2.SelectedValue);
                int idPartido = Convert.ToInt32(comboBox3.SelectedValue);


                ViviedaDTO dto = new ViviedaDTO
                {
                    Nombre = textBox1.Text.Trim(),
                    Apellido = textBox2.Text.Trim(),
                    DNI = dni,
                    Imagen_URL = textBox5.Text.Trim(),
                    Fecha_nac = dateTimePicker1.Value,
                    Calle = textBox10.Text.Trim(),
                    Altura = altura,
                    Piso = textBox8.Text.Trim(),
                    Depa = textBox7.Text.Trim(),
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
            comboBox1.DataSource = f.ObtenerProvincia();
            comboBox1.DisplayMember = "Nombre_prov";
            comboBox1.ValueMember = "Id_Provincia";


            comboBox2.DataSource = f.ObtenerLocalidad();
            comboBox2.DisplayMember = "Nombre_Local";
            comboBox2.ValueMember = "Id_Localidad";

            comboBox3.DataSource = f.ObtenerPartido();
            comboBox3.DisplayMember = "Nombre_partido";
            comboBox3.ValueMember = "Id_Partido";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
