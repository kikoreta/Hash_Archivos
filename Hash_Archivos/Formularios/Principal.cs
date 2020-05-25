using System;
using System.Drawing;
using System.Windows.Forms;
using Hash_Archivos.Codigo;

namespace Hash_Archivos.Formularios {

    public partial class Principal : Form {

        public Entidades.Archivo Archivo;

        public Principal() => InitializeComponent();

        private void BtnArchivo_Click(object sender, EventArgs e) {

            ReiniciarFondos();
            LimbiarTb();

            var dialogo = new OpenFileDialog();

            if (dialogo.ShowDialog() != DialogResult.OK) return;

            tbArchivo.Text = dialogo.FileName;

            Archivo = Funciones.LlenarArchivo(dialogo.FileName);

            if (Archivo == null) {
                MessageBox.Show($"Archivo no encontrado: {Archivo.Ruta}");

                return;
            }

            LlenarHash();
        }

        private void LlenarHash() {
            Entidades.Archivo archivo = Funciones.GenerarHash(Archivo);
            tbMD5.Text    = archivo.Md5;
            tbSHA1.Text   = archivo.Sha1;
            tbSHA256.Text = archivo.Sha256;
        }

        private void TbHash_TextChanged(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(tbHash.Text)) {
                tbHash.BackColor = Color.White;

                return;
            }

            if (string.IsNullOrWhiteSpace(tbArchivo.Text)) return;

            string hash = tbHash.Text;

            ReiniciarFondos();

            if (hash.Equals(Archivo.Md5)) {
                tbMD5.BackColor  = Color.LightGreen;
                tbHash.BackColor = Color.LightGreen;
            }
            else if (hash.Equals(Archivo.Sha1)) {
                tbSHA1.BackColor = Color.LightGreen;
                tbHash.BackColor = Color.LightGreen;
            }

            else if (hash.Equals(Archivo.Sha256)) {
                tbSHA256.BackColor = Color.LightGreen;
                tbHash.BackColor   = Color.LightGreen;
            }

            else { tbHash.BackColor = Color.Red; }
        }

        private void ReiniciarFondos() {
            tbMD5.BackColor    = Color.White;
            tbSHA1.BackColor   = Color.White;
            tbSHA256.BackColor = Color.White;
            tbHash.BackColor   = Color.White;
        }

        private void LimbiarTb() {
            tbMD5.Text    = "";
            tbSHA1.Text   = "";
            tbSHA256.Text = "";
            tbHash.Text   = "";
        }

    }

}