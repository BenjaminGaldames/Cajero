using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            String i = "";
            Cajero cajero = new Cajero();

            Cliente cliente1 = new Cliente();
            cliente1.Rut = "1-9";
            cliente1.Nombre = "Juan";
            cliente1.Apellido = "Soto";
            cliente1.Saldo = 0;

            Cliente cliente2 = new Cliente();
            cliente2.Rut = "12345678-5";
            cliente2.Nombre = "Pedro";
            cliente2.Apellido = "Páramo";
            cliente2.Saldo = 0;

            Cliente cliente3 = new Cliente();
            cliente3.Rut = "17689567-4";
            cliente3.Nombre = "Martín";
            cliente3.Apellido = "Cárcamo";
            cliente3.Saldo = 0;


            cajero.clientes.Add(cliente1);
            cajero.clientes.Add(cliente2);
            cajero.clientes.Add(cliente3);

            do
            {
                Console.WriteLine("1) Ver clientes");
                Console.WriteLine("2) Aumentar saldo");
                Console.WriteLine("3) Disminuir saldo");
                Console.WriteLine("4) Consultar saldo por cliente");
                Console.WriteLine("5) Consultar saldo total");
                Console.WriteLine("6) Salir");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Console.WriteLine("");
                        cajero.mostrarClientes();
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("");
                        cajero.mostrarClientes();
                        Console.WriteLine("Ingrese el rut del cliente:");
                        String rut = Console.ReadLine();
                        Console.WriteLine("Ingrese el dinero del cliente:");
                        Double saldo = Double.Parse(Console.ReadLine());
                        cajero.aumentarSaldoCliente(rut, saldo);
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        cajero.mostrarClientes();
                        Console.WriteLine("Ingrese el rut del cliente:");
                        rut = Console.ReadLine();
                        Console.WriteLine("Ingrese el dinero del cliente:");
                        saldo = Double.Parse(Console.ReadLine());
                        cajero.reducirSaldoCliente(rut, saldo);
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.WriteLine("");
                        cajero.mostrarClientes();
                        Console.WriteLine("Ingrese el rut del cliente:");
                        rut = Console.ReadLine();
                        cajero.consultarSaldoCliente(rut);
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("La cantidad de dinero en el cajero es de $" + cajero.getMonto());
                        Console.WriteLine("");
                        break;
                    case "6":
                        Console.WriteLine("Hasta pronto!!!");
                        break;
                    default:
                        Console.WriteLine("Esa opción es inválida.");
                        break;
                }

            } while (!i.Equals("6"));
            Console.ReadLine();

        }
    }
}
