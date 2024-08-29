using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = tbNombre.Text;
            string Apellidos = tbApellidos.Text;
            string Edad = tbEdad.Text;
            string Estatura = tbEstatura.Text;
            string Telefono = tbTelefono.Text;

            //Obtener el genero seleccionado

            string Genero = "";
            if (rbHombre.Checked)
            {
                Genero = "Hombre";

            }

            else if (rbMujer.Checked)
            {
                Genero = "Mujer";
            }

            //Crear una cadena de los datos
            string datos = $"Nombres: {Nombre}\r\n Apellidos: {Apellidos}\r\n  Telefono: {Telefono}\r\n  Estatura: {Estatura}\r\n  Edad: {Edad}\r\n  Genero: {Genero}";
            string rutaArchivos = "C:/Users/feres/OneDrive/Documentos/PracticaFormulario.txt";
            //string rutaA = "";
            bool archExiste = File.Exists(rutaArchivos);

            using (StreamWriter writer = new StreamWriter(rutaArchivos, true))
            {
                if (archExiste)
                {
                    writer.WriteLine(datos);


                }

                MessageBox.Show("Datos guardados con exito:\n\n" + datos, " Infomacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
