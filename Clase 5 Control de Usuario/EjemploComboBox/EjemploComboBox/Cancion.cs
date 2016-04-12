using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComboBox
{
    public class Cancion
    {
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private string _interprete;

        public string Interprete
        {
            get { return _interprete; }
            set { _interprete = value; }
        }

        private Duration _duracion;

        public Duration Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        

        private string _genero;

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        private int _año;

        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }

        private string _album;

        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        public Cancion(string titulo, string interprete, Duration duracion, string genero, int año, string album)
        {
            this._titulo = titulo;
            this._interprete = interprete;
            this._duracion = duracion;
            this._genero = genero;
            this._año = año;
            this._album = album;
        }
                  
    }
}
