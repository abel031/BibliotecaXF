using BibliotecaXF.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.Helpers
{
    public class Providers
    {
        private static SocioDAO _socioDAO;
        public static SocioDAO socioDAO
        {
            get
            {
                if (_socioDAO == null) _socioDAO = new SocioDAO(BibliotecaDB.ConectionDatabase);
                return _socioDAO;
            }
        }

        private static LibroDAO _libroDAO;
        public static LibroDAO libroDAO
        {
            get
            {
                if (_libroDAO == null) _libroDAO = new LibroDAO(BibliotecaDB.ConectionDatabase);
                return _libroDAO;
            }
        }
    }
}
