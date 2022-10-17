using Datos;
using System.Diagnostics;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(usuarioTextBox, "Ingrese un codigo de usuario");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (clavetextBox.Text == String.Empty)
            {
                errorProvider1.SetError(clavetextBox, "Ingrese una clave");
                clavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos usuarioDatos = new UsuarioDatos();
            bool valido = await usuarioDatos.LoginAsync(usuarioTextBox.Text, clavetextBox.Text);

            if (valido)
            {
                
                Menu formulario = new Menu();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}