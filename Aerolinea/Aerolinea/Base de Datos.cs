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
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConexionSQL=new ConexionSQL();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cliente.DUI = txtDui.Text;
            cliente.Nombre=txtNombre.Text;
            cliente.Apellido=txtApellido.Text;
            cliente.Edad = nudEdad.Text;

            ConexionSQL.AgregarCliente(cliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionSQL.EliminarCliente(txtEDui.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL.BuscarCliente(txtBDui.Text, out cliente);

            txtBNombre.Text = cliente.Nombre;
            txtBApellido.Text = cliente.Apellido;
            nudBEdad.Text = cliente.Edad;
        }
        private void btnMBuscar_Click(object sender, EventArgs e)
        {
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

            ConexionSQL.ModificarCliente(cliente);
        }
    }
}
