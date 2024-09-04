using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string Nombres = tbNombres.Text;
            string Apellidos = tbApellidos.Text;
            string Edad = tbEdad.Text;
            string Telefono = tbTelefono.Text;
            string Estatura = tbEstatura.Text;

            string Genero = "";
            if(rbHombre.Checked)
            {
                Genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                Genero = "Mujer";
            }

            string datos = $"Nombres: {Nombres}\r\nApellidos: {Apellidos}\r\nEstatura: {Estatura}cm\r\nEdad: {Edad} anios\r\nGenero: {Genero}";

            string rutaArchivo = "C:/Users/52918/OneDrive/Imágenes/guarda_datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if(archivoExiste)
                {
                    writer.WriteLine(datos);
                }
            }

            MessageBox.Show("Los Datos se guardaron con exito\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lbEstatura_Click(object sender, EventArgs e)
        {

        }

        private void lbTelfefono_Click(object sender, EventArgs e)
        {

        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
