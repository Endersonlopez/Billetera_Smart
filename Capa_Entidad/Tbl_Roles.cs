using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Tbl_Roles
(
	Id_Rol INT PRIMARY KEY IDENTITY (1,1),
	Rol INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
	)*/
    public class Tbl_Roles
    {
		public int Id_Rol {  get; set; }
		public Cls_Tipo_Catalogos Rol { get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_Modificacion { get; set; }
		public Cls_Estados Id_Estado { get; set; }
    }
}
