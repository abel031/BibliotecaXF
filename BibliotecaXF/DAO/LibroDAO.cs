using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaXF.DAO
{
    public class LibroDAO
    {
        private SQLiteAsyncConnection connection;

        public LibroDAO(SQLiteAsyncConnection connection)
        {
            this.connection = connection;
        }

        public Task<List<Libro>> AllSocios()
        {
            return this.connection.Table<Libro>().ToListAsync();
        }

        public int Insert(Libro libro)
        {
            Task<int> filas = this.connection.InsertAsync(libro);
            return filas.Result;
        }


        public static void saveLibro(Libro l)
        {
            var pos = BD.Libros.IndexOf(l);
            if (pos >= 0)
            {
                BD.Libros[pos] = l;
            }
            else
            {
                BD.Libros.Add(l);
            }
        }

        public static void deleteLibro(Libro l)
        {
            BD.Libros.Remove(l);
        }

        /*public static void addLibro(Libro l)
        {
            BD.Libros.Add(l);
        }*/
    }
}
