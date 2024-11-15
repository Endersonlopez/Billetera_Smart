using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Cls_Tipo_Catalogos
(
	Id_Tipo_Catalogo INT PRIMARY KEY IDENTITY (1,1),
	Tipo_Catalogo VARCHAR (80) NOT NULL,
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Activo BIT NOT NULL
	);*/
    public class Cls_Tipo_Catalogos
    {
		public int Id_Tipo_Catalogo { get; set; }
		public string Catalogo { get; set; }
		public DateTime Fecha_Creacion { get; set; }
		public DateTime Fecha_Modificacion { get; set; }
		public bool Activo {  get; set; }
    }
}
