using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace consulta_productos
{
    public partial class FromConsulta : Form
    {
        //MysqlObject
        MySqlConnection con = new("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando;
        //Objeto para recibir datos del SELECT
        MySqlDataReader dr;//Para que pueda leer lo que tenemos en el txt. 
        public FromConsulta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void iconPicBoxShare_Click(object sender, EventArgs e)
        {
            //conectamos a la base de datos
            //definir el comando
            con.Open();
            //Definir el comando SELECT
            comando = new MySqlCommand("SELECT * FROM productos ORDER BY nombre ASC");
            //Ejecutamos el comando y guardamos el RESULTADO
            //asignamos la con al comando
            comando.Connection = con;
            //comando.EndExecuteNonQuery();//Para ejecutar INSERT, DELETE, UPDATE
            //comando.ExecuteScalar();//para ejecutar select con un solo campo
            dr = comando.ExecuteReader();
            //Pasamos el resultado al DATAGRID
            if (dr.HasRows)//creamos una condición para saber si tenemos registros en la bs
            {
                //Pasamos cada renglon al dataGrid
                while (dr.Read())//Aquí hacemos que se leean los datos, una vez que no haya que leer nos saldremos del registro.  
                {
                    var mystring = dr.GetString(0);
                    //id-nombre-codigobarra-descipcion-precio-imagen
                    // 0    1        2           3        4      5
                    dGridProductos.Rows.Add(new object[] {dr.GetInt16(0),
                                                          dr.GetString(1),
                                                          dr.GetString(2),
                                                          dr.GetString(3),
                                                          dr.GetDouble(4),
                                                          dr.GetString(5) });//Con esto definimos las filas de nuestra tabla, según las características de esta

                }
            }
            else //Este es para si no tenemos el registro imprimir un mensaje donde no tenemos registros
            {
                MessageBox.Show("No se encontraron registros");
            }
            //CERRAMOS LA CONEXIÓN
            con.Close();
        }

        private void butonConfigure_Click(object sender, EventArgs e)
        {
            Form fromCRUD = new FromCRUD();
            fromCRUD.Show();
        }

        private void FromConsulta_Load(object sender, EventArgs e)
        {
            {

                //Lo que haremos ahora será mostrar la base de datos, lo ordenaremos por pasos. 
                //Vamos a conectarnos para mostrar los productos que se encuentran en la base de datos. 
                //1. Conectarse. 
                con.Open();
                //2. Creamos el comando SELECT* para poder seleccionar todos los campos de nuestra base de datos
                comando = new MySqlCommand("SELECT * FROM productos ORDER BY nombre ASC");
                //3.Asociamos la conexión al comando. 
                comando.Connection = con;
                //4.Ejecutamos el comando command con una de sus variantes, (dataread = executeReader())
                dr = comando.ExecuteReader();
                //5. Mostramos en el GridView, para ello necesitamos saber si existen datos en los renglones. 
                if (dr.HasRows)
                {
                    dGridProductos.Rows.Clear();
                    //Leer y mostrar en el data
                    while (dr.Read())
                    {
                        //mostrar cada campo dentro un RENGLON del GridView
                        dGridProductos.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetDouble(4),
                                dr.GetString(5)
                            );
                    }
                }
                //6.Cerramos la conexión. 
                con.Close();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cerrar = new FromConsulta();
            this.Close();
        }
    }
}