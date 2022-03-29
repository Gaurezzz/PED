using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    internal class conexion
    {
        public string cadena;
        public void conec()
        {
            cadena = "Persist Security Info=False;Integrated Security=true;Initial catalog=Aerolinea;server=(local)";
        }
    }
}
