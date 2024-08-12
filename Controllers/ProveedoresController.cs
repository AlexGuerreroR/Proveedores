using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proveedores.Models;

namespace Proveedores.Controllers
{
    class ProveedoresController
    {
        private ProveedoresModels ProveedoresModels = new ProveedoresModels();

        public DataTable todos()
        {
            DataTable listaProveedores = new DataTable();
            listaProveedores = ProveedoresModels.todos();
            return listaProveedores;


        }



    }
}
