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
    public partial class FromMenu : Form
    {
        public FromMenu()
        {
            InitializeComponent();
        }

        private void buttonAdminUsers_Click(object sender, EventArgs e)
        {
            Form fromUsuario = new FromUsuario();
            fromUsuario.Show();
        }

        private void buttonEditProductos_Click(object sender, EventArgs e)
        {
            Form fromCRUD = new FromCRUD();
            fromCRUD.Show();
        }

        private void buttonBuscarProductos_Click(object sender, EventArgs e)
        {
            Form fromConsulta = new FromConsulta();
            fromConsulta.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cerrar = new FromMenu();
            this.Close();
        }

        private void administradorDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form abrir = new FromUsuario();
            this.Show();
        }

        private void editarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editar = new FromCRUD();
            this.Show();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form buscar = new FromConsulta();
            this.Show();
        }
    }
}
