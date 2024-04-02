using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Alamcen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '•';
        }

        // Método para verificar las credenciales en la base de datos
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            Conexion conexion = new Conexion(); // Crear una instancia de Conexion

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                // Ocultar el formulario de inicio de sesión actual (Login.cs)
                this.Hide();

                // Abrir el formulario principal (Pagina_Inicial)
                Pagina_Inicial form2 = new Pagina_Inicial();
                form2.FormClosed += (s, args) => this.Close(); // Cerrar Login.cs cuando Pagina_Inicial se cierre
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activar_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña entre '*' y '\0' (carácter nulo) para mostrar u ocultar
            if (Activar.Checked)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar contraseña
            }
            else
            {
                txtContraseña.PasswordChar = '*'; // Ocultar contraseña
            }
        }
    }
}
