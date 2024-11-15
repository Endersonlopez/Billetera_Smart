using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*(
    Id_Usuario_Rol INT PRIMARY KEY IDENTITY (1,1),
    Id_Usuario INT REFERENCES Tbl_Usuarios (Id_Usuario),
    Id_Rol INT REFERENCES Tbl_Roles (Id_Rol),
    Fecha_Creacion DATETIME NOT NULL,
    Fecha_Modificacion DATETIME NOT NULL,
    Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
    )*/
    public class Tbl_Usuarios_Roles
    {
        public int Id_Usuario_Rol {  get; set; }
        public Tbl_Usuarios Id_Usuario { get; set; }
        public Tbl_Roles Id_Rol {  get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public Cls_Estados Id_Estado { get; set; }
    }
}
