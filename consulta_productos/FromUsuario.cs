using FontAwesome.Sharp;
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
    public partial class FromUsuario : Form
    {
        //Variables de base de datos
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=productos_pdv;Uid=root;Pwd=;");//Conectarnos a la BD
        MySqlCommand comando;//Comando para la asociación de conexión
        MySqlDataReader dr;//Leer los datos
        int id = 0;//La inicializamos para utilizarla como una ID, dentro del programa y usarla en borrar o editar, etc. 
        public FromUsuario()
        {
            InitializeComponent();
        }

        private void iconPictureBoxAdd_Click(object sender, EventArgs e)
        {
            //Como deshabilitamos los txt para escribir, los habilitamos con un if 
            if (txtNombre.Enabled == false &&
                txtCorreo.Enabled == false &&
                txtPassword.Enabled == false &&
                txtConfirmarPassword.Enabled == false &&
                txtFoto.Enabled == false)
            {
                //Se habilitan y se limpian. 
                this.limpiarForm(true);
            }
        }
        private void iconPicBoxSave_Click(object sender, EventArgs e)
        {
            //guardar usuarios
            //validar contraseñas
            if (txtPassword.Text == txtConfirmarPassword.Text)
            {   //Haremos excepciones
                try
                {
                    //1. Conectarnos
                    con.Open();
                    //2.Crear el comando insert de la base de datos. 
                    comando = new MySqlCommand("INSERT INTO usuarios (nombre, password, correo,foto) " +
                             $"VALUES('{txtNombre.Text}','{txtPassword.Text}','{txtCorreo.Text}','{txtFoto.Text}')");
                    //3. Conectar el comando con el con.
                    comando.Connection = con;
                    //Ejecutamos el insert con el ExecuteNonQuery. 
                    int res = comando.ExecuteNonQuery();
                    //datos fueron capturados correctamente o todos los datos se capturaron 
                    //4- Validar que haya sido ejecutaDO CORRECTAMENTE
                    if (res == 1)//Comparamos que sea 1, debido a que cuando hacemos los insert, cada insert es 1 linea agregada. 
                    {
                        //msg OK
                        MessageBox.Show("USUARIO DADO DE ALTA");
                    }
                    else
                    {
                        //msg OK
                        MessageBox.Show("ERROR EN LA CAPTURA AL USUARIO");
                    }
                }
                catch (MySqlException mex)
                {
                    MessageBox.Show("Error 1 " + mex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar 2 " + ex.Message);
                }
                finally //Cerramos
                { 
                    con.Close(); 
                }
            }
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromUsuario_Load_1(sender,e);//Se muestra un objeto. 
        }
        //este nos ayuda a mostrar la contraseña, ya que su propiedad la pusimos en false, pues las activamos 
        private void iconPictureBoxShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtConfirmarPassword.UseSystemPasswordChar= false;
        }
        //dejamos desactivada o desactivamos la propiedad de password para que no se muestre la contraseña
        private void iconPictureBoxNotShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmarPassword.UseSystemPasswordChar= true;
        }
        //Para el edite y delet, vamos a necesitar el evento click y que se muestre en txt los datos
        private void dGridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
            //En cada campo, de la tabla, en la variable creada, en la celda de la posición del campo
            txtNombre.Text = dGridUsuarios.Rows[celdas].Cells[1].Value.ToString();
            txtPassword.Text = dGridUsuarios.Rows[celdas].Cells[2].Value.ToString();
            txtCorreo.Text = dGridUsuarios.Rows[celdas].Cells[3].Value.ToString();
            txtFoto.Text = dGridUsuarios.Rows[celdas].Cells[4].Value.ToString();
            this.id = int.Parse((dGridUsuarios.Rows[celdas].Cells[0].Value.ToString()));//Convertimos para no tener error de tipos de dato
                                                                      //Además de esto, esta la usamos, para pasar los datos del producto
                                                                      //y eliminarlos sin afectar TODOS los datos de la tabla
        }
        //Funcionalidad del boton edit
        private void iconPicBoxEdit_Click(object sender, EventArgs e)
        {
            //1.Conectarse
            con.Open();
            //2.Creamos la querry para actualizar los campos a los que nosotros queremos. 
            comando = new MySqlCommand($"UPDATE usuarios SET nombre = '{txtNombre.Text}',password = '{txtPassword.Text}',correo = '{txtCorreo.Text}', foto = '{txtFoto.Text}' WHERE id = '{this.id}' ");
            MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE");
            //3.Ejecutamos la conexion
            comando.Connection = con;
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos conexión
            con.Close();
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromUsuario_Load_1(sender, e);//Se muestra un objeto.

        }
        //Método para eliminar usuarios
        private void iconPicBoxDelet_Click(object sender, EventArgs e)
        {
            con.Open();
            comando = new MySqlCommand("DELETE FROM usuarios WHERE id = " + this.id);
            comando.Connection = con;
            comando.ExecuteNonQuery();
            try
            {   //Aquí, estamos intentando eliminar los productos en el renglon donde está, con el index es el valor que tiene
                dGridUsuarios.Rows.RemoveAt(this.dGridUsuarios.CurrentRow.Index);
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
            }
            catch(Exception) //Si llegasemos a tener una falla al eliminar el producto
            {
                MessageBox.Show("ERROR AL ELIMINAR EL PRODUCTO");
            }
            con.Close();
            //vamos a limpiar los texto y deshabilitarlos
            this.limpiarForm(false);
            //Recargamos el fform
            this.FromUsuario_Load_1(sender, e);//Se muestra un objeto.
        }
        //Programamos el buscador de usuarios
        private void iconPiBox_Click(object sender, EventArgs e)
        {
            //conectamos a la base de datos
            //definir el comando
            con.Open();
            //Definir el comando SELECT
            comando = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + txtBuscador.Text + "'");
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
                    dGridUsuarios.Rows.Add(new object[] {dr.GetInt16(0),
                                                          dr.GetString(1),
                                                          dr.GetString(2),
                                                          dr.GetString(3),
                                                          dr.GetString(4) });//Con esto definimos las filas de nuestra tabla, según las características de esta
                }

            }
            else //Este es para si no tenemos el registro imprimir un mensaje donde no tenemos registros
            {
                MessageBox.Show("No se encontraron registros");
            }
            //CERRAMOS LA CONEXIÓN
            con.Close();
        }
        //Definición metodos
        //Método para cargar los datos. en load
        //Método para limpiar y habilitar txt
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtCorreo.Enabled = true;
                txtCorreo.Clear();
                txtPassword.Enabled = true;
                txtPassword.Clear();
                txtConfirmarPassword.Enabled = true;
                txtConfirmarPassword.Clear();
                txtFoto.Enabled = true;
                txtFoto.Clear();
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtCorreo.Enabled = false;
                txtCorreo.Clear();
                txtPassword.Enabled = false;
                txtPassword.Clear();
                txtConfirmarPassword.Enabled = false;
                txtConfirmarPassword.Clear();
                txtFoto.Enabled = false;
                txtFoto.Clear();
            }
        }

        private void FromUsuario_Load_1(object sender, EventArgs e)
        {

            //Lo que haremos ahora será mostrar la base de datos, lo ordenaremos por pasos. 
            //Vamos a conectarnos para mostrar los productos que se encuentran en la base de datos. 
            //1. Conectarse. 
            con.Open();
            //2. Creamos el comando SELECT* para poder seleccionar todos los campos de nuestra base de datos
            comando = new MySqlCommand("SELECT * FROM usuarios ORDER BY nombre ASC");
            //3.Asociamos la conexión al comando. 
            comando.Connection = con;
            //4.Ejecutamos el comando command con una de sus variantes, (dataread = executeReader())
            dr = comando.ExecuteReader();
            //5. Mostramos en el GridView, para ello necesitamos saber si existen datos en los renglones. 
            if (dr.HasRows)
            {
                dGridUsuarios.Rows.Clear();
                //Leer y mostrar en el data
                while (dr.Read())
                {
                    //mostrar cada campo dentro un RENGLON del GridView
                    dGridUsuarios.Rows.Add(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(3),
                            dr.GetString(2),
                            dr.GetString(4)
                        );
                }
            }
            //6.Cerramos la conexión. 
            con.Close();
        }
    }

}
