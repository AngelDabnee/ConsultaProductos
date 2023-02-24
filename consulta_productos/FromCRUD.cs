using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using System.Data;
using System.Diagnostics.Metrics;
using System.Windows.Controls;

namespace consulta_productos
{
    public partial class FromCRUD : Form
    {
        //MysqlObject
        MySqlConnection con = new("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");
        MySqlCommand comando;
        //Objeto para recibir datos del SELECT
        MySqlDataReader dr;//Para que pueda leer lo que tenemos en el txt. 
        int idcelds;//Lo usaremos para la edici�n. Se llenar� cuando le demos click a una celda
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
            if (dr.HasRows)//creamos una condici�n para saber si tenemos registros en la bs
            {
                //Pasamos cada renglon al dataGrid
                while (dr.Read())//Aqu� hacemos que se leean los datos, una vez que no haya que leer nos saldremos del registro.  
                {
                    var mystring = dr.GetString(0);
                    //id-nombre-codigobarra-descipcion-precio-imagen
                    // 0    1        2           3        4      5
                    dGridProductos.Rows.Add(new object[] {dr.GetInt16(0),
                                                          dr.GetString(1),
                                                          dr.GetString(2),
                                                          dr.GetString(3),
                                                          dr.GetDouble(4),
                                                          dr.GetString(5) });//Con esto definimos las filas de nuestra tabla, seg�n las caracter�sticas de esta
                }

            }
            else //Este es para si no tenemos el registro imprimir un mensaje donde no tenemos registros
            {
                MessageBox.Show("No se encontraron registros");
            }
            //CERRAMOS LA CONEXI�N
            con.Close();

        }
        //Iniciaremos con el boton para a�adir un nuevo producto
        private void iconPicBoxNew_Click(object sender, EventArgs e)
        {
            //Como deshabilitamos los txt para escribir, los habilitamos con un if 
            if (txtNombre.Enabled == false &&
                txtDescripcion.Enabled == false &&
                txtCodiBarra.Enabled == false &&
                txtPrecio.Enabled == false &&
                txtImagen.Enabled == false)
            {
                //Se habilitan y se limpian. 
                this.limpiarForm(true);
            }
        }
        //Comenzamos con la edici�n del boton para guardar. 
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
                MessageBox.Show("PRODUCTO CAPTURADO CON �XITO");
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
        //M�todo para limpiar. 

        private void FromCRUD_Load(object sender, EventArgs e)
        {
            
                //Lo que haremos ahora ser� mostrar la base de datos, lo ordenaremos por pasos. 
                //Vamos a conectarnos para mostrar los productos que se encuentran en la base de datos. 
                //1. Conectarse. 
                con.Open();
                //2. Creamos el comando SELECT* para poder seleccionar todos los campos de nuestra base de datos
                comando = new MySqlCommand("SELECT * FROM productos ORDER BY nombre ASC");
                //3.Asociamos la conexi�n al comando. 
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
                //6.Cerramos la conexi�n. 
                con.Close();
        }


        //Nos guiaremos a como usualmente se usa una modificaci�n de campos(donde buscamos el producto y lo editamos desde sus propiedades
        //), para ello
        //Vamos a seleccionar el campo que queremos modificar de la tabla, en esto nos vamos a los enventos
        //Que tiene nuestra tabla de donde mostramos lo resultados, en ella vamos a asignar el cambio para poder modificar
        private void dGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)//El evento se llama e
        {
            int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
            //En cada campo, de la tabla, en la variable creada, en la celda de la posici�n del campo
            txtNombre.Text = dGridProductos.Rows[celdas].Cells[1].Value.ToString();
            txtDescripcion.Text = dGridProductos.Rows[celdas].Cells[2].Value.ToString();
            txtCodiBarra.Text = dGridProductos.Rows[celdas].Cells[3].Value.ToString();
            txtPrecio.Text = dGridProductos.Rows[celdas].Cells[4].Value.ToString();
            txtImagen.Text = dGridProductos.Rows[celdas].Cells[5].Value.ToString();
            idcelds = (int)dGridProductos.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
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
                "WHERE id = '" + idcelds + "';");
            //3.Ejecutamos la conexion
            comando.Connection = con;
            //Ejecutamso el comando
            dr = comando.ExecuteReader();
            //Cerramos conexi�n
            con.Close();
        }
        private void iconPicBoxDelet_Click(object sender, EventArgs e)
        {
            //Daremos funcionalidad al boton de DELETE
            //1. Conectarse
            con.Open();
            //2.Crear el comando para borrar los datos. 
            comando = new MySqlCommand("DELETE FROM productos WHERE id = id");
            //3. Ejecutamos la conexi�n
            comando.Connection = con;
            //4.Usamos el comando necesario
            comando.ExecuteNonQuery();
            //BORRAR
            try
            {   //Aqu�, estamos intentando eliminar los productos en el renglon donde est�, con el index es el valor que tiene
                dGridProductos.Rows.RemoveAt(this.dGridProductos.CurrentRow.Index);
                MessageBox.Show("PRODUCTO ELIMINADO CON �XITO");
            }
            catch //Si llegasemos a tener una falla al eliminar el producto
            {
                MessageBox.Show("ERROR AL ELIMINAR EL PRODUCTO");
            }
            con.Close();
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
                txtImagen.Enabled = true;
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
                txtImagen.Enabled = false;
                txtImagen.Clear();
            }
        }

        private void iconPicAplicar_Click(object sender, EventArgs e)
        {            //1. Nos conectamos. 
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
                MessageBox.Show("BORRADO Y GUARDADO CON �XITO");
            }
            else
            {
                //msg OK
                MessageBox.Show("ERROREN BORRAR Y GUARDADO");
            }
            //5- cerrar CONEXION
            con.Close();
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromCRUD_Load(sender, e);//Se muestra un objeto.

        }
    }
}