using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Alamcen
{
    public partial class Crear_Producto : Form
    {
        private string connectionString = "Server=DESKTOP-HONFTB2;Database=Almacen;Integrated Security=true;"; // Reemplaza con tu cadena de conexión

        public Crear_Producto()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            // Cerrar todas las páginas abiertas excepto la página actual
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Pagina_Inicial paginaInicial = new Pagina_Inicial();

            // Mostrar la página Pagina_Inicial
            paginaInicial.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Crear_Producto CrearProducto = new Crear_Producto();

            // Mostrar la página Pagina_Inicial
            CrearProducto.Show();
        }

        private void btnProevedores_Click(object sender, EventArgs e)
        {

            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Proevedor proevedor = new Proevedor();

            // Mostrar la página Pagina_Inicial
            proevedor.Show();
        }

        // falta cambiar
        private void btnCrear_P_Click(object sender, EventArgs e)
        {

            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Pagina_Inicial paginaInicial = new Pagina_Inicial();

            // Mostrar la página Pagina_Inicial
            paginaInicial.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {

            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Entrada_de_Inventario entrada = new Entrada_de_Inventario();

            // Mostrar la página Pagina_Inicial
            entrada.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            // Ocultar la página actual
            this.Hide();

            // Crear una instancia de la página Pagina_Inicial
            Salida_de_inventario salida = new Salida_de_inventario();

            // Mostrar la página Pagina_Inicial
            salida.Show();
        }
        private byte[] ObtenerBytesDeImagen(string rutaArchivo)
        {
            try
            {
                // Verificar si la ruta de archivo es válida
                if (File.Exists(rutaArchivo))
                {
                    // Leer los bytes del archivo de imagen
                    return File.ReadAllBytes(rutaArchivo);
                }
                else
                {
                    MessageBox.Show("La imagen seleccionada no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bytes de la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto y la imagen
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string cantidadStock = txtCantidad.Text.Trim(); // Renombrado para que coincida con el nombre de la columna en la base de datos
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un valor de precio válido.", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sku = txtCodigo.Text.Trim(); // Renombrado para que coincida con el nombre de la columna en la base de datos
            string categoria = txtCategoria.Text;
            DateTime fechaVencimiento;
            if (!DateTime.TryParse(txtFecha_vencimiento.Text, out fechaVencimiento))
            {
                MessageBox.Show("Por favor, ingrese una fecha de vencimiento válida.", "Error de Fecha de Vencimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] imagen = ObtenerBytesDeImagen(txtImagen.Text); // Obtener los bytes de la imagen desde el TextBox

            // Establecer la consulta SQL para la inserción de datos
            string query = @"INSERT INTO Producto (Nombre, Descripcion, Cantidad_Stock, Precio, SKU, Categoria, Fecha_vencimiento, Imagen)
             VALUES (@Nombre, @Descripcion, @Cantidad_Stock, @Precio, @SKU, @Categoria, @Fecha_vencimiento, @Imagen)";

            // Crear y configurar el comando SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Asignar los parámetros
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Cantidad_Stock", cantidadStock);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@SKU", sku);
                command.Parameters.AddWithValue("@Categoria", categoria);
                command.Parameters.AddWithValue("@Fecha_vencimiento", fechaVencimiento);
                command.Parameters.AddWithValue("@Imagen", imagen);

                try
                {
                    // Abrir la conexión y ejecutar la consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Crear_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            // Crear un nuevo cuadro de diálogo para seleccionar archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer las propiedades del cuadro de diálogo
            openFileDialog.Title = "Seleccionar Imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Multiselect = false;

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado y mostrarla en el TextBox
                string rutaImagen = openFileDialog.FileName;
                txtImagen.Text = rutaImagen;
            }
        }
    }
}
