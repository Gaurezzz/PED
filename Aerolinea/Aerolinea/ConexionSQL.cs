using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;


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
            try
            {
                cnn.ConnectionString = @"Provider=sqloledb; Data Source=local;Integrated Security=true;Initial catalog=Aerolinea;server=(local);UseAffectedRows=True";
                conexion cn1 = new conexion();
                cn1.conec();
                sCn1 = cn1.cadena;
                conn = new SqlConnection(sCn1);
                //conn.Open();
                MessageBox.Show("Conexion Exitosa", "Conecion con SQL");
            }
            catch
            {
                MessageBox.Show("Conexion Fallida", "Conecion con SQL");
            }
        }

        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                conn.Open();
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
                MessageBox.Show("Añadido Exitosamente","Cliente Agregado");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void EliminarCliente(string DUI)
        {
            conn.Open();
            try
            {
                string eliminarCliente;
                eliminarCliente = "DELETE FROM Clientes WHERE DUI = @DUI";
                command = new SqlCommand(eliminarCliente, conn);
                command.Parameters.AddWithValue("@DUI", DUI);
                int affRows = command.ExecuteNonQuery();
                MessageBox.Show("Elimnado Exitosamente\n" + $"Filas Afectadas {affRows}", "Eliminacion Exitosa");
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void BuscarCliente(string DUI, out Cliente cliente)
        {
            cliente = new Cliente();
            conn.Open();
            try
            {
                string buscarCliente;
                buscarCliente = "SELECT DUI,Nombre,Apellido,Edad FROM Clientes WHERE DUI = " + DUI;
                da = new SqlDataAdapter(buscarCliente, conn);
                DataSet ds = new DataSet();
                int r = da.Fill(ds, "Clientes");

                if (r == 0)
                    MessageBox.Show("No se encontro el cliente", "Buscar Cliente");

                cliente.Nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                cliente.Apellido = ds.Tables[0].Rows[0]["Apellido"].ToString();
                cliente.Edad = ds.Tables[0].Rows[0]["Edad"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarCliente(Cliente cliente)
        {
            conn.Open();
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
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
