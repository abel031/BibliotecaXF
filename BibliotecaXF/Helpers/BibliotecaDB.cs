using BibliotecaXF.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaXF.Helpers
{
    public class BibliotecaDB
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        public static SQLiteAsyncConnection ConectionDatabase => lazyInitializer.Value;

        public BibliotecaDB()
        {
            /*ConectionDatabase.CreateTableAsync<Libro>().Wait();
            ConectionDatabase.CreateTableAsync<Socio>().Wait();*/

           /* Providers.socioDAO.Insert(new Socio
            {
                DNI="111",
                Nombre="pepe",
            });*/

            //InitializeAsync().SafeFireAndForget(false);
        }

        //async Task InitializeAsync()
        //{
        //    //if (!initialized)
        //    //{
        //    //    if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(LibDB).Name))
        //    //    {
        //    //        await Database.CreateTablesAsync(CreateFlags.None, typeof(LibDB)).ConfigureAwait(false);
        //    //    }
        //    //    initialized = true;
        //    //}
        //}
    }
}
