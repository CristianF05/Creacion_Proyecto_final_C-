using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Alamcen
{
    public partial class Entrada_de_Inventario : Form
    {
        public Entrada_de_Inventario()
        {
            InitializeComponent();
        }

        private void Entrada_de_Inventario_Load(object sender, EventArgs e)
        {

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
    }
}
