using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComboBox
{
    public class Duration
    {
        private int _minutos;

        public int Minutos
        {
            get { return _minutos; }
            set { _minutos = value; }
        }

        private int _segundos;

        public int Segundos
        {
            get { return _segundos; }
            set { _segundos = value; }
        }


        public Duration(int minutos, int segundos)
        {
            this._minutos = minutos;
            this._segundos = segundos;
        }

        public override string ToString()
        {
            string durString = "";
            if (this._minutos >= 0 && this._minutos < 10)
                durString += "0" + this._minutos;
            else
                durString += this._minutos;

            durString += ":";

            if (this._segundos >= 0 && this._segundos < 10)
                durString += "0" + this._segundos;
            else
                durString += this._segundos;

            return durString;

        }

    }
}
