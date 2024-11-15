using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Tbl_Permisos
(
	Id_Permiso INT PRIMARY KEY IDENTITY (1,1),
	Id_Rol INT REFERENCES Tbl_Roles (Id_Rol),
	Permiso VARCHAR (50) NOT NULL,
	Descripcion_Permiso VARCHAR (150) NULL,
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
)*/
    public class Tbl_Permisos
    {
		public int Id_Permiso { get; set; }
		public Tbl_Roles Id_Rol {  get; set; }
		public string Permiso { get; set; }
		public string Descripcion { get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_Modificacion { get; set; }
		public Cls_Estados Id_Estado { get; set; }
    }
}
