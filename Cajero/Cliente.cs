using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Cliente
    {
        String _rut;
        String _nombre;
        String _apellido;
        Double _saldo;

        public String Rut
        {
            get
            {
                return this._rut;
            }
            set
            {
                this._rut = value;
            }
        }

        public String Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public String Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public Double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this._saldo = value;
            }
        }

    }
}
