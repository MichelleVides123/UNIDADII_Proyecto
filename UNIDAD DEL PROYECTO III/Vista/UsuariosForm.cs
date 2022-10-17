using Datos;
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

        
    }
}
