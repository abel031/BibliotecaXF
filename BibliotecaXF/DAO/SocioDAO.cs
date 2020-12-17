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

        public Task<List<Socio>> AllSociosAsync()
        {
            return this.connection.Table<Socio>().ToListAsync();
        }

        public int InsertAsync(Socio socio)
        {
            Task<int> filas = this.connection.InsertAsync(socio);
            return filas.Result;
        }

        public Task<int> deleteAsync(Socio s)
        {
            Task<int> t= this.connection.DeleteAsync(s);
            return t;
        }

        public Task<int> ModifyAsunc(Socio s)
        {
            return this.connection.UpdateAsync(s);
        }

    }
}
