using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;


namespace Aerolinea
{
    internal class ConexionSQL
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private SqlCommand command;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        private bool estado;
        public bool Estado { get { return estado; } }

        //Struct que contiene las variables de la tabla Clientes
        public struct Cliente
        {
            public string DUI;
            public string Nombre;
            public string Apellido;
            public string Edad;
        }
        //Metodo que conecta con la base de datos
        public ConexionSQL()
        {
            cnn.ConnectionString = @"Provider=sqloledb; Data Source=local;Integrated Security=true;Initial catalog=Aerolinea;server=(local);UseAffectedRows=True";
            conexion cn1 = new conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn = new SqlConnection(sCn1);
            ConectarSQL();
        }
        private void ConectarSQL()
        {
            try
            {
                conn.Close();
                conn.Open();
                estado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conexion con SQL");
                estado = false;
            }
        }
        public void AgregarVertice(Nodo nodo,int SQLRow)
        {
            try
            {
                bool añadido=false;

                while (añadido!=true)
                {
                    conn.Close();
                    conn.Open();
                    if (!ExisteVertice(nodo.Nombre))
                    {
                        string insertarNodo;
                        insertarNodo = "INSERT INTO Vertice(Fila,Nombre,posX,posY)";
                        insertarNodo += "VALUES(@Fila,@Nombre,@posX,@posY)";
                        command = new SqlCommand(insertarNodo, conn);
                        command.Parameters.Add(new SqlParameter("@Fila", SqlDbType.Int));
                        command.Parameters["@Fila"].Value = SQLRow;
                        command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                        command.Parameters["@Nombre"].Value = nodo.Nombre;
                        command.Parameters.Add(new SqlParameter("@posX", SqlDbType.Int));
                        command.Parameters["@posX"].Value = nodo.PosX;
                        command.Parameters.Add(new SqlParameter("@posY", SqlDbType.Int));
                        command.Parameters["@posY"].Value = nodo.PosY;
                        command.ExecuteNonQuery();
                        añadido = true;
                    }
                    else
                    {
                        string eliminarCliente;
                        eliminarCliente = "DELETE FROM Vertice WHERE Nombre = @Nombre";
                        command = new SqlCommand(eliminarCliente, conn);
                        command.Parameters.AddWithValue("@Nombre", nodo.Nombre);
                        int affRows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
            }
        }
        public void AgregarArista(Nodo arista,int SQLRow)
        {
            try
            {
                bool añadido = false;

                while (añadido != true)
                {
                    conn.Close();
                    conn.Open();
                    if (!ExisteArista(arista.Nombre))
                    {
                        string insertarNodo;
                        insertarNodo = "INSERT INTO Aristas(Fila,Nombre,peso,VerticeAntecesor,VerticeAdyacente)";
                        insertarNodo += "VALUES(@Fila,@Nombre,@peso,@VerticeAntecesor,@VerticeAdyacente)";
                        command = new SqlCommand(insertarNodo, conn);
                        command.Parameters.Add(new SqlParameter("@Fila", SqlDbType.Int));
                        command.Parameters["@Fila"].Value = SQLRow;
                        command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                        command.Parameters["@Nombre"].Value = arista.Nombre;
                        command.Parameters.Add(new SqlParameter("@peso", SqlDbType.Int));
                        command.Parameters["@peso"].Value = arista.Peso;
                        command.Parameters.Add(new SqlParameter("@VerticeAntecesor", SqlDbType.VarChar));
                        command.Parameters["@VerticeAntecesor"].Value = arista.VerticeAntecesor.Nombre;
                        command.Parameters.Add(new SqlParameter("@VerticeAdyacente", SqlDbType.VarChar));
                        command.Parameters["@VerticeAdyacente"].Value = arista.VerticeAdyacente.Nombre;
                        command.ExecuteNonQuery();
                        añadido = true;
                    }
                    else
                    {
                        string eliminarCliente;
                        eliminarCliente = "DELETE FROM Aristas WHERE Nombre = @Nombre";
                        command = new SqlCommand(eliminarCliente, conn);
                        command.Parameters.AddWithValue("@Nombre", arista.Nombre);
                        int affRows = command.ExecuteNonQuery();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
            }
        }
        //Comprueba si existe un vertice con el mismo nombre en la base de datos
        public bool ExisteVertice(string Nombre)
        {
            string buscarVertice;
            buscarVertice = "SELECT Nombre FROM Vertice WHERE Nombre = @Nombre";
            command = new SqlCommand(buscarVertice, conn);
            command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            command.Parameters["@Nombre"].Value = Nombre;
            dr = command.ExecuteReader();
            if (!dr.Read())
            {
                dr.Close();
                return false;
            }
            dr.Close();
            return true;
        }
        //Comprueba si existe una arista con el mismo nombre en la base de datos
        public bool ExisteArista(string Nombre)
        {
            string buscarArista;
            buscarArista = "SELECT Nombre FROM Aristas WHERE Nombre = @Nombre";
            command = new SqlCommand(buscarArista, conn);
            command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            command.Parameters["@Nombre"].Value = Nombre;
            dr = command.ExecuteReader();
            if (!dr.Read())
            {
                dr.Close();
                return false;
            }
            dr.Close();
            return true;
        }
        //Eliminar vertice
        public void EliminarVertice(string NombreVertice)
        {
            try
            {
                if (ExisteVertice(NombreVertice))
                {
                    conn.Close();
                    conn.Open();
                    string eliminarCliente;
                    eliminarCliente = "DELETE FROM Vertice WHERE Nombre = @Nombre";
                    command = new SqlCommand(eliminarCliente, conn);
                    command.Parameters.AddWithValue("@Nombre", NombreVertice);
                    int affRows = command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL");
            }
        }
        //Eliminar arista
        public void EliminarArista(string NombreArista)
        {
            try
            {
                if (ExisteArista(NombreArista))
                {
                    conn.Close();
                    conn.Open();
                    string eliminarCliente;
                    eliminarCliente = "DELETE FROM Aristas WHERE Nombre = @Nombre";
                    command = new SqlCommand(eliminarCliente, conn);
                    command.Parameters.AddWithValue("@Nombre", NombreArista);
                    int affRows = command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL");
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            try
            {
                string modificarCliente;
                modificarCliente = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad WHERE DUI = @DUI";
                command = new SqlCommand(modificarCliente, conn);
                command.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                command.Parameters["@DUI"].Value = cliente.DUI;
                command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                command.Parameters["@Nombre"].Value = cliente.Nombre;
                command.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                command.Parameters["@Apellido"].Value = cliente.Apellido;
                command.Parameters.Add(new SqlParameter("@Edad", SqlDbType.VarChar));
                command.Parameters["@Edad"].Value = cliente.Edad;
                int affRow = command.ExecuteNonQuery();

                if (affRow > 0)
                    MessageBox.Show("Modificacion realizada con exito", "Modificar Cliente");
                else
                    MessageBox.Show("Cambios no realizados", "Modificar Cliente");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
            }
        }
        public Nodo GetNodo(int row)
        {
            try
            {
                Nodo nodo = new Nodo();
                conn.Close();
                conn.Open();
                string getNodo;
                getNodo = "SELECT * FROM Clientes";
                da = new SqlDataAdapter(getNodo, conn);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return nodo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable MostrarClientes()
        {
            string mostrarClientes;
            mostrarClientes = "SELECT * FROM Clientes";
            da = new SqlDataAdapter(mostrarClientes, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
