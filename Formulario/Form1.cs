using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FFormulario : Form
    {
        public FFormulario()
        {
            InitializeComponent();
        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbestatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbhombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbmujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            string nombre = tbnombre.Text;
            string apellido = tbapellido.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string telefono = tbtelefono.Text;

            string gen = "";
            if (cbhombre.Checked)
            {
                gen = "hombre";
            }
            else if (cbmujer.Checked)
            {
                gen = "mujer";
            }
            string dat = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {gen}";
            string rut = "C:\\Users\\perez\\OneDrive\\Documentos\\tareas semestre 3\\Programacion Avanzada\\C#\\datosformulario.txt";
            bool ax = File.Exists(rut);
            using (StreamWriter writer = new StreamWriter(rut, true))
            {
                if (ax)
                {
                    writer.WriteLine("================================");
                }
                writer.WriteLine(dat);
            }
            MessageBox.Show("Datos guardados con exito:\r\n\n" + dat, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btcancerlar_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            cbhombre.Checked = false;
            cbmujer.Checked = false;
        }
    }
}