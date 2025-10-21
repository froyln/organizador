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

namespace Organizador_rework
{
    public partial class frmOrganizador : Form
    {
        string path = "";
        public frmOrganizador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = false;
            openFileDialog.FileName = "Selecciona una carpeta";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(openFileDialog.FileName);
                textBox1.Text = folderPath;
                path = folderPath;
            }
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            if (cboOrganizacion.Text.Length == 0)
            {
                MessageBox.Show("Selecciona un tipo de organización.");
                return;
            }

            if (path.Length == 0)
            {
                MessageBox.Show("Selecciona una carpeta.");
                return;
            }

            Organizaciones org = new Organizaciones();
            switch (cboOrganizacion.SelectedIndex)
            {
                case 0:
                    org.OrganizarPorExtension(path);
                    break;
                case 1:
                    org.OrganizarPorFecha(path);
                    break;
                case 2:
                    org.OrganizarPorAño(path);
                    break;
                case 3:
                    org.OrganizarPorLetra(path);
                    break;
                case 4:
                    org.OrganizarPorTamaño(path);
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo de organización válido.");
                    break;
            }
        }
    }
}
