using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    /*CREATE TABLE Tbl_Datos_Personales
(
	Id_Persona INT PRIMARY KEY IDENTITY (1,1),
	Primer_Nombre VARCHAR (80) NOT NULL,
	Segundo_Nombre VARCHAR (80) NULL,
	Primer_Apellido VARCHAR (80) NOT NULL,
	Segundo_Apellido VARCHAR (80) NULL,
	Tipo_DNI INT REFERENCES Cls_Catalogos (Id_Catalogo),
	DNI VARCHAR (20) NOT NULL,
	Genero INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Nacionalidad INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Estado_Civil INT REFERENCES Cls_Catalogos (Id_Catalogo),
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Modificacion DATETIME NOT NULL,
	Id_Estado INT REFERENCES Cls_Estados (Id_Estado)
	);*/
    public class Tbl_Datos_Personales
    {
		public int Id_Persona { get; set; }
		public string Primer_Nombre { get; set; }
		public string Segundo_Nombre { get; set; }
		public string Primer_Apellido { get; set; }
		public string Segundo_Apellido { get; set; }
		public Cls_Catalogos Tipo_DNI	{ get; set; }
		public string DNI {  get; set; }
		public Cls_Catalogos Genero { get; set;  }
		public Cls_Catalogos Nacionalidad { get; set; }
		public Cls_Catalogos Estado_Civl { get; set; }
		public DateTime Fecha_Creacion {  get; set; }
		public DateTime Fecha_Modificacion	{ get; set; }
		public Cls_Estados Id_Estado { get; set; }
    }
}
