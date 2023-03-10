using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consulta_productos
{
    public partial class FromMenuUsuario : Form
    {
        public FromMenuUsuario()
        {
            InitializeComponent();
        }

        private void buttonEditProductos_Click(object sender, EventArgs e)
        {
            Form fromCRUD = new FromCRUD();
            fromCRUD.Show();

        }
        private void buttonBuscarProductos_Click_1(object sender, EventArgs e)
        {
            Form fromConsulta = new FromConsulta();
            fromConsulta.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cerrar = new FromMenuUsuario();
            this.Close();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form buscarProducto = new FromConsulta();
            this.Show();
        }

        private void editarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editar = new FromCRUD();
            this.Show();
        }
    }
}
