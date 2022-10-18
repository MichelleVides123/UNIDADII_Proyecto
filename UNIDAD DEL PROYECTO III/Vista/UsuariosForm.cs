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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        UsuarioDatos userDatos = new UsuarioDatos();
        string tipooperacion = string.Empty;
        Usuario user;

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void LlenarDataGrid()
        {
            UsuariosdataGridView.DataSource = await userDatos.DevolverListaAsync();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            habilitarcontroles();
            tipooperacion = "Nuevo";
        }

        private void habilitarcontroles()
        {
            codigoTextBox.Enabled = true;
            nombretextBox.Enabled = true;
            clavetextBox.Enabled = true;
            correotextBox.Enabled = true;
            rolcomboBox.Enabled = true;
            estadoactcheckBox.Enabled = true;
        }

        private void deshabilitarcontroles()
        {
            codigoTextBox.Enabled = false;
            nombretextBox.Enabled = false;
            clavetextBox.Enabled = false;
            correotextBox.Enabled = false;
            rolcomboBox.Enabled = false;
            estadoactcheckBox.Enabled = false;
        }

        private void limpiarcontroles()
        {
            codigoTextBox.Clear();
            nombretextBox.Clear();
            clavetextBox.Clear();
            correotextBox.Clear();
            rolcomboBox.Text = String.Empty;
            estadoactcheckBox.Checked = false;
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            deshabilitarcontroles();
            limpiarcontroles();
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            tipooperacion = "Moidficar";

            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {
                codigoTextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                nombretextBox.Text = UsuariosdataGridView.CurrentRow.Cells["nombre"].Value.ToString();
                clavetextBox.Text = UsuariosdataGridView.CurrentRow.Cells["clave"].Value.ToString();
                correotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["correo"].Value.ToString();
                rolcomboBox.Text = UsuariosdataGridView.CurrentRow.Cells["rol"].Value.ToString();
                estadoactcheckBox.Checked = Convert.ToBoolean(UsuariosdataGridView.CurrentRow.Cells["rol"].Value.ToString());
                habilitarcontroles();
                codigoTextBox.ReadOnly = true;
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void guardarbutton_Click(object sender, EventArgs e)
        {
            user = new Usuario();

            if (tipooperacion == "Nuevo")
            {
                if (codigoTextBox.Text == "")
                {
                    errorProvider1.SetError(codigoTextBox, "Ingrese un codigo");
                    codigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "Ingrese un nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(clavetextBox.Text))
                {
                    errorProvider1.SetError(clavetextBox, "Ingrese un clave");
                    clavetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "Ingrese un rol");
                    rolcomboBox.Focus();
                    return;
                }

                user.Codigo = codigoTextBox.Text;
                user.Nombre = nombretextBox.Text;
                user.Clave = clavetextBox.Text;
                user.Correo = correotextBox.Text;
                user.Rol = rolcomboBox.Text;
                user.EstadoActivo = estadoactcheckBox.Checked;

                bool inserto = await userDatos.InsertarAsync(user);

                if (inserto)
                {
                    LlenarDataGrid();
                    limpiarcontroles();
                    deshabilitarcontroles();
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (tipooperacion == "Modificar")
            {
                if (codigoTextBox.Text == "")
                {
                    errorProvider1.SetError(codigoTextBox, "Ingrese un codigo");
                    codigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "Ingrese un nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(clavetextBox.Text))
                {
                    errorProvider1.SetError(clavetextBox, "Ingrese un clave");
                    clavetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "Ingrese un rol");
                    rolcomboBox.Focus();
                    return;
                }

                user.Codigo = codigoTextBox.Text;
                user.Nombre = nombretextBox.Text;
                user.Clave = clavetextBox.Text;
                user.Correo = correotextBox.Text;
                user.Rol = rolcomboBox.Text;
                user.EstadoActivo = estadoactcheckBox.Checked;

                bool modifico = await userDatos.ActualizarAsync(user);

                if (modifico)
                {
                    LlenarDataGrid();
                    limpiarcontroles();
                    deshabilitarcontroles();
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private async void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await userDatos.EliminarAsync(UsuariosdataGridView.CurrentRow.Cells["codigo"].Value.ToString());
                if (elimino)
                {
                    LlenarDataGrid();
                    MessageBox.Show("Usuario Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
