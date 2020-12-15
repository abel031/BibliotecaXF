using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaXF.DAO
{
    public class SocioDAO
    {
        private SQLiteAsyncConnection connection;

        public SocioDAO(SQLiteAsyncConnection connection)
        {
            this.connection = connection;
        }

        public Task<List<Socio>> AllSocios()
        {
            return this.connection.Table<Socio>().ToListAsync();
        }

        public int Insert(Socio socio)
        {
            Task<int> filas = this.connection.InsertAsync(socio);
            return filas.Result;
        }

        public static void deleteSocio(Socio s)
        {
            BD.Socios.Remove(s);
        }

        public static void addSocio(Socio s)
        {
            BD.Socios.Add(s);
        }

    }
}
