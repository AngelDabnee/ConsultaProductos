using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Resultset;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;

//using System.Windows.Controls;
namespace consulta_productos
{
    public partial class FromCRUD : Form
    {
        //MysqlObject
        MySqlConnection con = new("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando;
        //Objeto para recibir datos del SELECT
        MySqlDataReader dr;//Para que pueda leer lo que tenemos en el txt. 
        int id = 0; //La utilizaremos para guardar los datos del datagrid y eliminarlos con el delete en la querry correspondiente.
                    //esta variable también funciona en modificar ya que, vamos a señalar en donde queremos modificar dependiendo del id
        

        public FromCRUD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPiBox_Click(object sender, EventArgs e)
        {
            //conectamos a la base de datos
            //definir el comando
            con.Open();
            //Definir el comando SELECT
            comando = new MySqlCommand("SELECT * FROM productos WHERE nombre='" + txtBuscador.Text + "'");
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
                    dGridProductos.Rows.Add(new object[] {dr.GetInt16("id"),
                                                          dr.GetString("nombre"),
                                                          dr.GetString("codigo_barras"),
                                                          dr.GetString("descripcion"),
                                                          dr.GetDouble("precio"),
                                                          dr.GetString("imagen") });//Con esto definimos las filas de nuestra tabla, según las características de esta

                }

            }
            else //Este es para si no tenemos el registro imprimir un mensaje donde no tenemos registros
            {
                MessageBox.Show("No se encontraron registros");
            }
            //CERRAMOS LA CONEXIÓN
            con.Close();

        }
        //Iniciaremos con el boton para añadir un nuevo producto
        private void iconPicBoxNew_Click(object sender, EventArgs e)
        {
            //Como deshabilitamos los txt para escribir, los habilitamos con un if 
            if (txtNombre.Enabled == false &&
                txtDescripcion.Enabled == false &&
                txtCodiBarra.Enabled == false &&
                txtPrecio.Enabled == false)
            {
                //Se habilitan y se limpian. 
                this.limpiarForm(true);
            }
        }
        //Comenzamos con la edición del boton para guardar. 
        private void iconPicBoxSave_Click(object sender, EventArgs e)
        {
            
            //1. Nos conectamos. 
            con.Open();
            //2.Crear el comando insert de la base de datos. 
            comando = new MySqlCommand("INSERT INTO productos (nombre, descripcion, codigo_barras, precio,imagen) " +
                     "VALUES('" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + txtCodiBarra.Text + "'," + txtPrecio.Text + ",'" + txtImagen.Text + "' )");
            //3. Conectar el comando con el con.
            comando.Connection = con;
            //Ejecutamos el insert con el ExecuteNonQuery. 
            int res = comando.ExecuteNonQuery();
            //datos fueron capturados correctamente o todos los datos se capturaron 
            //4- Validar que haya sido ejecutaDO CORRECTAMENTE
            if (res == 1)//Comparamos que sea 1, debido a que cuando hacemos los insert, cada insert es 1 linea agregada. 
            {
                //msg OK
                MessageBox.Show("PRODUCTO CAPTURADO CON ÉXITO");
                if (pictureBoxFoto.Image != null)
                {
                    pictureBoxFoto.Image.Save("..\\..\\..\\imagenesConsultaProducto\\" + txtImagen.Text);
                }
            }
            else
            {
                //msg OK
                MessageBox.Show("ERROR EN LA CAPTURA");
            }
            //5- cerrar CONEXION

            con.Close();
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromCRUD_Load(sender, e);//Se muestra un objeto. 
        }
        //Método para limpiar. 

        private void FromCRUD_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }


        //Nos guiaremos a como usualmente se usa una modificación de campos(donde buscamos el producto y lo editamos desde sus propiedades
        //), para ello
        //Vamos a seleccionar el campo que queremos modificar de la tabla, en esto nos vamos a los enventos
        //Que tiene nuestra tabla de donde mostramos lo resultados, en ella vamos a asignar el cambio para poder modificar
        private void dGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)//El evento se llama e
        {
            //Este rowIndex, es para que cuando le doy click en el evento del data grid, fuera de los renglones no me de el error, mejor dicho no me deje
            if (e.RowIndex >= 0)
            {
                
                int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
                //En cada campo, de la tabla, en la variable creada, en la celda de la posición del campo
                txtNombre.Text = dGridProductos.Rows[celdas].Cells[1].Value.ToString();
                txtDescripcion.Text = dGridProductos.Rows[celdas].Cells[2].Value.ToString();
                txtCodiBarra.Text = dGridProductos.Rows[celdas].Cells[3].Value.ToString();
                txtPrecio.Text = dGridProductos.Rows[celdas].Cells[4].Value.ToString();
                txtImagen.Text = dGridProductos.Rows[celdas].Cells[5].Value.ToString();
                pictureBoxFoto.ImageLocation = "..\\..\\..\\imagenesConsultaProducto\\" + txtImagen.Text;//Con esto me mostrará la imagen en el picture box dependiendo de la ruta
                this.id = (int)dGridProductos.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                          //Además de esto, esta la usamos, para pasar los datos del producto
                                                                          //y eliminarlos sin afectar TODOS los datos de la tabla
           
            }
        }
        //Daremos funcionalidad a la query
        private void iconPicBoxEdit_Click(object sender, EventArgs e)
        {
            
            //1.Conectarse
            con.Open();
            //2.Creamos la querry para actualizar los campos a los que nosotros queremos. 
            comando = new MySqlCommand("UPDATE productos SET " +
                "nombre = '" + txtNombre.Text + "'," +
                "descripcion = '" + txtDescripcion.Text + "'," +
                "codigo_barras = '" + txtCodiBarra.Text + "'," +
                "precio = '" + txtPrecio.Text + "'," +
                "imagen = '" + txtImagen.Text + "'" +
                "WHERE id = '" + this.id + "';");
            //3.Ejecutamos la conexion
            comando.Connection = con;
            //Ejecutamso el comando
            int res = comando.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
                if (pictureBoxFoto.Image != null)
                {
                    File.Delete("..\\..\\..\\imagenesConsultaProducto\\" + txtImagen.Text);
                    pictureBoxFoto.Image.Save("..\\..\\..\\imagenesConsultaProducto\\" + txtImagen.Text);
                }
            }
            else
            {
                MessageBox.Show("ERROR AL MODIFICAR");
            }
            //Cerramos conexión
            con.Close();
            this.limpiarForm(true);
            this.cargarDatos();
        }
        private void iconPicBoxDelet_Click(object sender, EventArgs e)
        {
            //Daremos funcionalidad al boton de DELETE
            //1. Conectarse
            con.Open();
            //2.Crear el comando para borrar los datos. 
            comando = new MySqlCommand("DELETE FROM productos WHERE id = " + this.id);//Aquí como guardamos los datos, podemos modificarlos
            //3. Ejecutamos la conexión
            comando.Connection = con;
            //4.Usamos el comando necesario
            int res = comando.ExecuteNonQuery();
            //BORRAR
            if (res == 1)
            {
                try
                {   //Aquí, estamos intentando eliminar los productos en el renglon donde está, con el index es el valor que tiene
                    dGridProductos.Rows.RemoveAt(this.dGridProductos.CurrentRow.Index);
                    MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                    if (pictureBoxFoto.Image != null)
                    {
                        File.Delete("..\\..\\..\\imagenesConsultaProducto\\" + txtImagen.Text);
                    }
                }
                catch //Si llegasemos a tener una falla al eliminar el producto
                {
                    MessageBox.Show("ERROR AL ELIMINAR EL PRODUCTO");
                }
            }
            //cerramos la conexión
            con.Close();
            //Limpiamos el txt
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromCRUD_Load(sender, e);//Se muestra un objeto. 
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtDescripcion.Enabled = true;
                txtDescripcion.Clear();
                txtCodiBarra.Enabled = true;
                txtCodiBarra.Clear();
                txtPrecio.Enabled = true;
                txtPrecio.Clear();
                txtImagen.Clear();
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtDescripcion.Enabled = false;
                txtDescripcion.Clear();
                txtCodiBarra.Enabled = false;
                txtCodiBarra.Clear();
                txtPrecio.Enabled = false;
                txtPrecio.Clear();
                txtImagen.Clear();
            }
        }
        private void cargarDatos()
        {
            if (con.State == ConnectionState.Closed)
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
                                dr.GetInt32("id"),
                                dr.GetString("nombre"),
                                dr.GetString("codigo_barras"),
                                dr.GetString("descripcion"),
                                dr.GetDouble("precio"),
                                dr.GetString("imagen")
                            );
                    }
                }
                //6.Cerramos la conexión. 
                con.Close();
            }
        }
        //Con este hacemos que se nos muestre el dialogo para poder usarlo
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = openDialogProtImagen.ShowDialog();
            //cargar el archivo
            if (res == DialogResult.OK)
            {
                pictureBoxFoto.Image = new Bitmap(openDialogProtImagen.FileName);
                //crear un nombre unico
                DateTime dtNombre = DateTime.Now;
                string nombreImg = "prod_" + dtNombre.Ticks + ".png";
                txtImagen.Text = nombreImg;
            }
            //por si le da click en cerrar. 
            else { }
        }
        //método para guardar la imagen. 
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cerrar = new FromCRUD();
            this.Close();
        }
    }
}
