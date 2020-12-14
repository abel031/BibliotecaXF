using BibliotecaXF.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.Model
{
    public class Socio : NotifyPropertyBase
    {

        private string _DNI;
        public string DNI
        {
            get { return _DNI; }
            set
            {
                _DNI = value;
                OnPropertyChanged();
            }
        }
        private string _Nombre;
        public string Nombre { 
            get { return _Nombre; } 
            set
            {
                _Nombre = value;
                OnPropertyChanged();
            }
        }
        public List<Libro> Prestamos { get; set; } = new List<Libro>();

    }
}
