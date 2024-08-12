using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreiras de sql   libreria de Data
using System.Data.SqlClient;
using System.Data;

namespace Proveedores.Config
{
    class ConexionBDD
    {
        private SqlConnection con = new SqlConnection("Server= ALEXANDER; Database = Tienda ; user = sa; password=300809; trustServerCertificate = true");

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed) con.Open(); return con;
        }
        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open) con.Close(); return con;
        }



    }
}
