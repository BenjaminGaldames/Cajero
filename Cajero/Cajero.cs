using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Cajero
    {
        public List<Cliente> clientes = new List<Cliente>();

        public double getMonto()
        {
            Double monto = 0;
            foreach (Cliente cliente in clientes)
            {
                monto += cliente.Saldo;
            }
            return monto;
        }

        public void mostrarClientes()
        {
            int count = 0;
            foreach (Cliente cliente in clientes)
            {
                count++;
                Console.WriteLine(count + ") " + cliente.Nombre + " " + cliente.Apellido + " " + cliente.Rut);
            }
        }

        public void aumentarSaldoCliente(String rut, Double saldo)
        {
            bool existe = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Rut.Equals(rut))
                {
                    existe = true;
                    cliente.Saldo = cliente.Saldo + saldo;                
                }
            }

            if (!existe)
            {
                Console.WriteLine("No existe el cliente de rut '" + rut + "'.");
            }
        }

        public void reducirSaldoCliente(String rut, Double saldo)
        {
            bool existe = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Rut.Equals(rut))
                {
                    existe = true;
                    cliente.Saldo = cliente.Saldo - saldo;
                }
            }

            if (!existe)
            {
                Console.WriteLine("No existe el cliente de rut '" + rut + "'.");
            }
        }

        public void consultarSaldoCliente(String rut)
        {
            bool existe = false;
            Double saldo = 0;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Rut.Equals(rut))
                {
                    existe = true;
                    saldo = cliente.Saldo;
                }
            }

            if (!existe)
            {
                Console.WriteLine("No existe el cliente de rut '" + rut + "'.");
            }else
            {
                Console.WriteLine("El saldo del cliente es $" + saldo + ".");
            }
        }
    }
}
