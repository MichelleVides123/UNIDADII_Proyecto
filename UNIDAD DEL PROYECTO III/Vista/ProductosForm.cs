using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class imagenProductosForm : Form
    {
        public imagenProductosForm()
        {
            InitializeComponent();
        }

        ProductoDatos proDatos = new ProductoDatos();
        Producto producto;
        string tipooperacion = string.Empty;

        private void imagenProductosForm_Load(object sender, EventArgs e)
        {
            LenarPtoductos();
        }

        private async void LenarPtoductos()
        {
            productodataGridView.DataSource = await proDatos.DevolverListaAsync();

        }

        private void HabilitarControles()
        {
            codigotextBox.Enabled = true;
            descripciontextBox.Enabled = true;
            preciotextBox.Enabled = true;
            existenciatextBox.Enabled = true;
            fechadateTimePicker.Enabled = true;
            pictureBox1.Enabled = true;
            adjuntarbutton.Enabled = true;
        }

        private void LimpiararControles()
        {
            codigotextBox.Clear();
            descripciontextBox.Clear();
            preciotextBox.Clear();
            existenciatextBox.Clear();
            fechadateTimePicker.Value = DateTime.Now;
            pictureBox1.Image = null;
        }
        private void DesabilitarControles()
        {
            codigotextBox.Enabled = false;
            descripciontextBox.Enabled = false;
            preciotextBox.Enabled = false;
            existenciatextBox.Enabled = false;
            fechadateTimePicker.Enabled = false;
            pictureBox1.Enabled = false;
            adjuntarbutton.Enabled = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            tipooperacion = "Nuevo";
            HabilitarControles();
        }

        private async void guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigotextBox.Text))
            {
                errorProvider1.SetError(codigotextBox, "Ingrese el codigo");
                codigotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(descripciontextBox.Text))
            {
                errorProvider1.SetError(descripciontextBox, "Ingrese una descripcion");
                descripciontextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(preciotextBox.Text))
            {
                errorProvider1.SetError(preciotextBox, "Ingrese un precio");
                preciotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(existenciatextBox.Text))
            {
                errorProvider1.SetError(existenciatextBox, "Ingrese una existencia");
                existenciatextBox.Focus();
                return;
            }
            producto = new Producto();
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                producto.Imagen = ms.GetBuffer();
            }
            else
            {
                producto.Imagen = null;
            }

            //producto.Codigo = Convert.ToInt32(codigotextBox.Text);
            producto.Descripcion = descripciontextBox.Text;
            producto.Existencia = Convert.ToInt32(existenciatextBox.Text);
            producto.Precio = Convert.ToDecimal(preciotextBox.Text);
            producto.FechaCreacion = fechadateTimePicker.Value;

            if (tipooperacion == "Nuevo")
            {
                bool inserto = await proDatos.InsertarAsync(producto);
                if (inserto)
                {
                    LenarPtoductos();
                    LimpiararControles();
                    DesabilitarControles();
                    MessageBox.Show("Producto Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (tipooperacion == "Modificar")
            {
                bool modifico = await proDatos.ActualizarAsync(producto);
                if (modifico)
                {
                    LenarPtoductos();
                    LimpiararControles();
                    DesabilitarControles();
                    MessageBox.Show("Producto Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void adjuntarbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }

        }

        private async void modificarbutton_Click(object sender, EventArgs e)
        {
            if (productodataGridView.SelectedRows.Count > 0)
            {
                tipooperacion = "Modificar";
                HabilitarControles();
                codigotextBox.ReadOnly = true;
                codigotextBox.Text = productodataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                descripciontextBox.Text = productodataGridView.CurrentRow.Cells["descripcion"].Value.ToString();
                existenciatextBox.Text = productodataGridView.CurrentRow.Cells["existencia"].Value.ToString();
                preciotextBox.Text = productodataGridView.CurrentRow.Cells["precio"].Value.ToString();
                fechadateTimePicker.Value = Convert.ToDateTime(productodataGridView.CurrentRow.Cells["Codigo"].Value);

                byte[] imagenDeBaseDatos = await proDatos.SeleccionarImagen(productodataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (imagenDeBaseDatos.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(imagenDeBaseDatos);
                    pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }

            }
            else
            {
                MessageBox.Show("seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private async void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (productodataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await proDatos.EliminarAsync(productodataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    LenarPtoductos();
                    MessageBox.Show("Producto eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void existenciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void preciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')> -1)
            {
                e.Handled = true;
            }
        }
    }
}
