using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class Base_de_Datos : Form
    {
        ConexionSQL ConexionSQL;
        ConexionSQL.Cliente cliente = new ConexionSQL.Cliente();
        public Base_de_Datos()
        {
            InitializeComponent();
            Conectar();
        }
        public void Conectar()
        {
            ConexionSQL = new ConexionSQL();
            if (ConexionSQL.Estado == true)
            {
                lbEstado.Text = "Estado de la conexion: Activa";
                btnReconectar.Visible = false;
            }
            else
            {
                lbEstado.Text = "Estado de la conexion: Inactiva";
                btnReconectar.Visible = true;
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cliente.DUI = txtDui.Text;
            cliente.Nombre=txtNombre.Text;
            cliente.Apellido=txtApellido.Text;
            cliente.Edad = nudEdad.Text;

            Conectar();
            ConexionSQL.AgregarCliente(cliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conectar();
            ConexionSQL.EliminarCliente(txtEDui.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conectar();
            ConexionSQL.BuscarCliente(txtBDui.Text, out cliente);

            txtBNombre.Text = cliente.Nombre;
            txtBApellido.Text = cliente.Apellido;
            nudBEdad.Text = cliente.Edad;
        }
        private void btnMBuscar_Click(object sender, EventArgs e)
        {
            Conectar();
            ConexionSQL.BuscarCliente(txtMDui.Text, out cliente);

            txtMNombre.Text = cliente.Nombre;
            txtMApellido.Text = cliente.Apellido;
            nudMEdad.Text = cliente.Edad;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cliente.DUI = txtMDui.Text;
            cliente.Nombre = txtMNombre.Text;
            cliente.Apellido = txtMApellido.Text;
            cliente.Edad = nudMEdad.Text;

            Conectar();
            ConexionSQL.ModificarCliente(cliente);
        }
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Conectar();
            if (ConexionSQL.Estado == true)
                MessageBox.Show("Conectado", "Conexion con SQL");
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            Conectar();
            dgvClientes.DataSource = ConexionSQL.MostrarClientes();
            dgvClientes.AutoResizeColumns();
        }
    }
}
