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
        Producto producto = new Producto();
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
    }
}
