using EncriptandoTexto;
using EncryptDoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PruebaDeExamen
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            DescripcionBotones();


        }

        private void DescripcionBotones()
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnCancelar, "Volver Atrás");
            toolTip.SetToolTip(btnEncriptarFolder, "Ecriptar Carpeta");
            toolTip.SetToolTip(btndesencriptarFolder, "Desencriptar Carpeta");
            toolTip.SetToolTip(btnencrypFolder, "Encriptar/Desencriptar Carpeta");
            toolTip.SetToolTip(btnEncryptText, "Encriptar/Desencriptar Texto");
            toolTip.SetToolTip(btnSearch, "Seleccionar Carpeta");
            toolTip.SetToolTip(btnClear, "Volver Atrás");
            toolTip.SetToolTip(btnEncriptar, "Ecriptar Texto");
            toolTip.SetToolTip(btnDesencriptar, "Desencriptar Texto");
        }

        private void LimpiarControles()
        {
            txtFolder.Clear();
            txtText.Clear();
            tbcontrol.SelectedTab = tbpageWelcome;

        }
        private void btnencryp_Click(object sender, EventArgs e)
        {
            txtText.Clear();
            tbcontrol.SelectedTab = tbpageFolder;
        }

        private void btnDesencryp_Click(object sender, EventArgs e)
        {
            txtFolder.Clear();
            tbcontrol.SelectedTab = tbpageText;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            DialogResult result = folderBrowserDialog.ShowDialog();
            txtFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnEncriptarFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtFolder.Text))
                {
                    string[] archivos = Directory.GetFiles(txtFolder.Text);
                    foreach (var archivo in archivos)
                    {
                        Encrypt.EncryptFile(archivo, archivo + ".exe", "SeguridadInformaticaUnivalle");
                        File.Delete(archivo);
                                              
                    }
                    txtFolder.Clear();
                    MessageBox.Show("Carpeta Encriptada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Carpeta no Encontrada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void btndesencriptarFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtFolder.Text))
                {
                    string[] archivos = Directory.GetFiles(txtFolder.Text);
                    foreach (var archivo in archivos)
                    {
                        string ArchivoSinExtencion = Path.GetFileNameWithoutExtension(archivo);
                        Encrypt.DecryptFile(archivo, Path.Combine(txtFolder.Text, ArchivoSinExtencion), "SeguridadInformaticaUnivalle");
                        File.Delete(archivo);                     
                                           
                    }
                    txtFolder.Clear();
                    MessageBox.Show("Carpeta Desencriptada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Carpeta no Encontrada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception Error)
            { MessageBox.Show(Error.Message); }
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtText.Text))
            {
                txtText.Text = Encripty.Encrypt(txtText.Text);
                MessageBox.Show("Información Encriptada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Ingrese el Texto", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtText.Text))
            {
                txtText.Text = Encripty.Decrypt(txtText.Text);
                MessageBox.Show("Información Desencriptada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Ingrese el Texto", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
