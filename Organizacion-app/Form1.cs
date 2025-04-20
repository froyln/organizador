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

namespace Organizacion_app
{
    public partial class Organizador : Form
    {
        int clicks = 0;
        string path;
        public Organizador() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void extension_button_click(object sender, EventArgs e) {
            if (path == null || path == " ")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: No hay directorio seleccionado";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            if (!Directory.Exists(path))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: Esta ruta de archivos no existe";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            foreach (var i in Directory.GetFiles(path).ToList())
            {
                string extension = Path.GetExtension(i);
                string nombre = Path.GetFileName(i);
                string carpeta = Path.Combine(path, extension.Replace(".", ""));
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                File.Move(i, Path.Combine(carpeta, nombre));
            }

            textBox1.ForeColor = Color.Green;
            textBox1.Text = "Archivos organizados por extension";
            clicks = 0;
        }

        private void fecha_button_click(object sender, EventArgs e) {
            if (path == null || path == " ")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: No hay directorio seleccionado";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            if (!Directory.Exists(path))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: Esta ruta de archivos no existe";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            foreach (var i in Directory.GetFiles(path).ToList())
            {
                string fecha = File.GetLastWriteTime(i).ToString("yyyy-MM-dd");
                string nombre = Path.GetFileName(i);
                string carpeta = Path.Combine(path, fecha);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                File.Move(i, Path.Combine(carpeta, nombre));
            }

            textBox1.ForeColor = Color.Green;
            textBox1.Text = "Archivos organizados por fecha de creacion.";
            clicks = 0;
        }

        private void año_button_click(object sender, EventArgs e) {
            if (path == null || path == " ")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: No hay directorio seleccionado";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            if (!Directory.Exists(path))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: Esta ruta de archivos no existe";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            foreach (var i in Directory.GetFiles(path).ToList())
            {
                string fecha = File.GetLastWriteTime(i).ToString("yyyy");
                string nombre = Path.GetFileName(i);
                string carpeta = Path.Combine(path, fecha);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                File.Move(i, Path.Combine(carpeta, nombre));
            }

            textBox1.ForeColor = Color.Green;
            textBox1.Text = "Archivos organizados por año";
            clicks = 0;
        }

        private void letra_button_click(object sender, EventArgs e) {
            if (path == null || path == " ")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: No hay directorio seleccionado";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            if (!Directory.Exists(path))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: Esta ruta de archivos no existe";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            foreach (var i in Directory.GetFiles(path).ToList())
            {
                string letra = Path.GetFileName(i).Substring(0, 1).ToUpper();
                string nombre = Path.GetFileName(i);
                string carpeta = Path.Combine(path, letra);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                File.Move(i, Path.Combine(carpeta, nombre));
            }

            textBox1.ForeColor = Color.Green;
            textBox1.Text = "Archivos organizados por su primera letra";
            clicks = 0;
        }

        private void tamaño_button_click(object sender, EventArgs e) {
            if (path == null || path == " ")
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: No hay directorio seleccionado";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            if (!Directory.Exists(path))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Error: Esta ruta de archivos no existe";
                clicks = 0;
                //textBox1.ForeColor = Color.Black;
                return;
            }

            var archivos = Directory.GetFiles(path).Select(f => new FileInfo(f)).OrderBy(f => f.Length).ToList();

            foreach (var archivo in archivos)
            {
                string tamaño = (archivo.Length / (1024.0 * 1024.0)).ToString("F2") + "MB";
                string nombre = archivo.Name;
                string carpeta = Path.Combine(path, tamaño);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                File.Move(archivo.FullName, Path.Combine(carpeta, nombre));
            }

            textBox1.ForeColor = Color.Green;
            textBox1.Text = "Archivos organizados por tamaño";
            clicks = 0;
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            
        }

        private void textBox1_Click(object sender, EventArgs e) {
            if (clicks == 0)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            clicks++;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {
                direccion_marcador.Text = "Direccion actual: "+textBox1.Text;
                path = textBox1.Text;
            }
        }

        private void buscar_button_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                textBox1.ForeColor = Color.Black;
                dialog.Description = "Selecciona una carpeta";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.SelectedPath;
                    path = dialog.SelectedPath;
                    direccion_marcador.Text = path;
                }
            }
        }
    }
}
