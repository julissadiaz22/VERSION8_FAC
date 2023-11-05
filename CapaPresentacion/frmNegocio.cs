using CapaEntidad;
using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write (imageBytes,0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }
        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                piclogo.Image = ByteToImage(byteimagen);
            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtNombre.Text = datos.Nombre;
            txtRUC.Text = datos.RUC;
            txtDireccion.Text = datos.Direccion;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if(oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    piclogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtNombre.Text,
                RUC = txtRUC.Text,
                Direccion = txtDireccion.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);
            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
