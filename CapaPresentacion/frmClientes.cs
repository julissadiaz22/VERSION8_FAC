using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, texto = "No activo" });

            cboEstado.DisplayMember = "texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listRol = new CN_Rol().Listar();

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, texto = columna.HeaderText });
                }
            }

            cboBusqueda.DisplayMember = "texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            //Mostrar todos los usuarios
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdCliente, item.Documento, item.NombreCompleto, item.Correo, item.Telefono,
              
                item.Estado == true ?1 :0,
                item.Estado == true ? "Activo" : "No Activo",
            });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente objcliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,


            };

            if (objcliente.IdCliente == 0)
            {
                int idusuariogenerado = new CN_Cliente().Registrar(objcliente, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", txtId.Text, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text, txtTelefono.Text,
             

                ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).texto.ToString()
            });

                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Cliente().Editar(objcliente, out mensaje);

                if (resultado == true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];

                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                  
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).texto.ToString();

                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cboEstado.SelectedIndex = 0;

            txtDocumento.Focus();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {

                if (MessageBox.Show("¿Esta seguro que desea eliminar el Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objcliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtId.Text)

                    };
                    bool respuesta = new CN_Cliente().Eliminar(objcliente, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)

                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtId.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                    

                    

                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))

                        row.Visible = true;

                    else

                        row.Visible = false;

                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

            foreach (DataGridViewRow row in dgvdata.Rows)
            {


                row.Visible = true;


            }
        }
    }
}
