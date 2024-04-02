using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_Alamcen
{
    class Conexion
    {
        public static SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Server=DESKTOP-HONFTB2;Database=Almacen;Integrated Security=true;");
                MessageBox.Show("Conectado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR:" + e.Message, "ERROR INESPERADO", MessageBoxButtons.OK);
            }
        }

        public bool VerificarCredenciales(string usuario, string contraseña)
        {
            string connectionString = "Server=DESKTOP-HONFTB2;Database=Almacen;Integrated Security=true;";

            string query = "SELECT COUNT(*) FROM login WHERE usuario = @Usuario AND contraseña = @Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar credenciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}

