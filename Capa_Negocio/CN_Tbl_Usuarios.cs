using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Data;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Tbl_Usuarios
    {
        private CD_Tbl_Usuarios objCapaDAto = new CD_Tbl_Usuarios();

        public List<Tbl_Usuarios> Listar()
        {
            return objCapaDAto.Listar();
        }
    }
}
