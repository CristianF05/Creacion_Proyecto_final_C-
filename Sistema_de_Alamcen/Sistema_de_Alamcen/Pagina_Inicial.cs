using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_Alamcen
{
    public partial class Pagina_Inicial : Form
    {
        private string connectionString = "Server=DESKTOP-HONFTB2;Database=Almacen;Integrated Security=true;";

        // Clase Producto
        public class Producto
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string SKU { get; set; }
            public string Categoria { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad_Stock { get; set; }
            public string Unidad_Medida { get; set; }
            public DateTime? Fecha_Vencimiento { get; set; }
        }

        public Pagina_Inicial()
        {
            InitializeComponent();
        }

        private void Pagina_Inicial_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
