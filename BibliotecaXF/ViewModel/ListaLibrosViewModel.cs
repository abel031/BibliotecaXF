using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class ListaLibrosViewModel
    {
        public ObservableCollection<Libro> Libros { get; set; }

        public ListaLibrosViewModel()
        {
            Libros = new ObservableCollection<Libro>(BD.Libros);
        }

    }
}
