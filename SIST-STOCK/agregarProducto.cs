using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace SIST_STOCK
{
    public partial class agregarProducto : Form
    {
        public agregarProducto()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();

            nuevoArticulo.Nombre = textBoxNombre.Text;
            nuevoArticulo.Stock = Convert.ToInt32(textBoxStock.Text);
            nuevoArticulo.Caracteristica = textBoxCaracteristica.Text;
            nuevoArticulo.Precio = Convert.ToDouble(textBoxPrecio.Text);

            Marca nuevaMarca = new Marca();
            nuevaMarca.Nombre = textBoxMarca.Text;
            nuevoArticulo.Marca = nuevaMarca;

            // Asignar la categoría correspondiente
            nuevoArticulo.Categoria = /* Asigna la categoría aquí */;

            // Aquí puedes proceder a guardar el nuevoArticulo en una base de datos, lista, etc.
            // Ejemplo: ListaArticulos.Add(nuevoArticulo);
        }
    }
}
