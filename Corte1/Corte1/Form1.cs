using Corte1.Clases;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro = new Registro();
        private Operacion operacion = new Operacion();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Registro de edades - SSMS";
            CargarCiudades();
        }

        private void CargarCiudades()
        {
            cmbCiudad.Items.Add("Managua");
            cmbCiudad.Items.Add("Granada");
            cmbCiudad.Items.Add("León");
            cmbCiudad.Items.Add("Matagalpa");
            cmbCiudad.Items.Add("Chinandega");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string ciudad = cmbCiudad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(apellidos) && ciudad != null)
            {
                Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
                registro.AgregarPersona(nuevaPersona);
                MessageBox.Show("Persona agregada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            if (registro.TotalPersonas() > 0)
            {
                // Obtener la última persona agregada (como ejemplo)
                Persona ultimaPersona = registro.ObtenerPersona(registro.TotalPersonas() - 1);
                int edad = operacion.CalcularEdad(ultimaPersona);
                bool mayorDeEdad = operacion.EsMayorDeEdad(ultimaPersona);

                string mensaje = $"{ultimaPersona.Nombres} {ultimaPersona.Apellidos} tiene {edad} años y es " +
                                 (mayorDeEdad ? "mayor de edad." : "menor de edad.");
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
