using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.Model
{
    [Table("Libro")]
    public class Libro
    {
        [PrimaryKey,AutoIncrement]
        private int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public Boolean Prestado { get; set; } = false;

        [ForeignKey(typeof(Socio))]
        private int SocioId { get; set; }
    }
}
