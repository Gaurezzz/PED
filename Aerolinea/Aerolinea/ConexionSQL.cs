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
        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                string insertarCliente;
                insertarCliente = "INSERT INTO Clientes(DUI,Nombre,Apellido,Edad)";
                insertarCliente += "VALUES(@Dui,@nombre,@apellido,@edad)";
                command = new SqlCommand(insertarCliente, conn);
                command.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                command.Parameters["@DUI"].Value = cliente.DUI;
                command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                command.Parameters["@Nombre"].Value = cliente.Nombre;
                command.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                command.Parameters["@Apellido"].Value = cliente.Apellido;
                command.Parameters.Add(new SqlParameter("@Edad", SqlDbType.VarChar));
                command.Parameters["@Edad"].Value = cliente.Edad;
                command.ExecuteNonQuery();
                MessageBox.Show("Añadido Exitosamente", "Cliente Agregado");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
            }
        }
        public void EliminarCliente(string DUI)
        {
            try
            {
                string eliminarCliente;
                eliminarCliente = "DELETE FROM Clientes WHERE DUI = @DUI";
                command = new SqlCommand(eliminarCliente, conn);
                command.Parameters.AddWithValue("@DUI", DUI);
                int affRows = command.ExecuteNonQuery();
                MessageBox.Show("Elimnado Exitosamente\n" + "Filas Afectadas {affRows}", "Eliminacion Exitosa");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
            }
        }
        public void BuscarCliente(string DUI, out Cliente cliente)
        {
            cliente = new Cliente();
            try
            {
                string buscarCliente;
                buscarCliente = "SELECT DUI,Nombre,Apellido,Edad FROM Clientes WHERE DUI = @DUI";
                command = new SqlCommand(buscarCliente, conn);
                command.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                command.Parameters["@DUI"].Value=DUI;
                dr=command.ExecuteReader();
                if (dr.Read())
                {
                    cliente.Nombre = dr["Nombre"].ToString();
                    cliente.Apellido = dr["Apellido"].ToString();
                    cliente.Edad = dr["Edad"].ToString();
                }
                else
                    MessageBox.Show("No exite cliente con el DUI ingresado", "Cliente no encontrado");
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                conn.Close();
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
