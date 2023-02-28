using MySql.Data.MySqlClient;
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
    public partial class FromLogin : Form
    {
        //Variables de base de datos
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");//Conectarnos a la BD
        MySqlCommand comando;//Comando para la asociación de conexión
        MySqlDataReader dr;//Leer los datos
        public FromLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                //1.Conectanos
                con.Open();
                //2. Establecer sí existe el usuario con el comando select nombre, password, son iguales a las de la base de datos
                comando = new MySqlCommand($"SELECT nombre, password FROM usuarios WHERE nombre = '{txtUsuario.Text}' AND password = '{txtPassword.Text}'");
                //3. se establece conexión. 
                comando.Connection = con;
                //4.que se ejecute
                dr = comando.ExecuteReader();
                if (dr.Read())//para que leea 
                {   //Con esta sentencia mandamos al usuario ya sea al menú admin o al menú normal
                    if (txtUsuario.Text == "AngelDabnee" && txtPassword.Text == "AngelDabnee")//si es admin, nos mandará al menu de administrador
                    {
                        Form fromMenu = new FromMenu();
                        fromMenu.Show();
                    }
                    if (txtUsuario.Text != "AngelDabnee" && txtPassword.Text != "AngelDabnee")
                    {   //sino, nos mandará al menu del usuario. 
                        Form fromMenuUsuario = new FromMenuUsuario();
                        fromMenuUsuario.Show();
                    }

                }
                else
                {
                    MessageBox.Show("ERROR EN USUARIO Y/O CONTRASEÑA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void iconPictureBoxShow_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void iconPictureBoxNotShow_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
