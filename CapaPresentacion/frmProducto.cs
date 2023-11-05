using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, texto = "No activo" });

            cboEstado.DisplayMember = "texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;


            List<Categoria> listacatagoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacatagoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, texto = item.Descripcion });
            }

            cbocategoria.DisplayMember = "texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;

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
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {
                dgvdata.Rows.Add(new object[] { 
                "",
                item.IdProducto,
                item.Codigo,
                item.Nombre,
                item.Descripcion,
                item.oCategoria.IdCategoria,
                item.oCategoria.Descripcion,
                item.Stock,
                item.PrecioCompra,
                item.PrecioVenta,
                item.Estado == true ?1 :0,
                item.Estado == true ? "Activo" : "No Activo",
            });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
               
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,


            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { 
                        "",
                        idgenerado,
                        txtCodigo.Text,
                        txtNombre.Text,
                        txtDescripcion.Text,
                ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbocategoria.SelectedItem).texto.ToString(),
                "0",
                "0.00",
                "0.00",
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
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado == true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];

                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).texto.ToString();

                   
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
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbocategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtCodigo.Focus();


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
                    txtCodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
                  

                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {

                if (MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtId.Text)

                    };
                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos a exportar","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach(DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.HeaderText != string.Empty  && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                             
                        }) ; 
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto {0}.xlsx", DateTime.Now.ToString("ddMMyyyHHmmss"));
                saveFile.Filter = "Excel files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch 
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }


                }

            
            }

        }
    }
}
