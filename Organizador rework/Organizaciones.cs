using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Organizador_rework
{
    public class Organizaciones
    {
        public void OrganizarPorExtension(string path)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Error: Esta ruta de archivos no existe.");
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
            
            MessageBox.Show("Archivos organizados por extension.");
        }
        public void OrganizarPorFecha(string path)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Error: Esta ruta de archivos no existe.");
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

            MessageBox.Show("Archivos organizados por fecha de creacion.");
        }
        public void OrganizarPorAño(string path)
        {
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

            MessageBox.Show("Archivos organizados por año.");
        }
        public void OrganizarPorLetra(string path)
        {
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
            MessageBox.Show("Archivos organizados por letra inicial.");
        }
        public void OrganizarPorTamaño(string path)
        {
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

            MessageBox.Show("Archivos organizados por tamaño.");
        }
    }
}
