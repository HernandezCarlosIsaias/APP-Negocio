using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIST_STOCK
{
    public partial class pantallaPrincipal : Form
    {
        public pantallaPrincipal()
        {
            InitializeComponent();
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            agregarProducto formProducto = new agregarProducto();
            formProducto.Show();
        }
    }
}
