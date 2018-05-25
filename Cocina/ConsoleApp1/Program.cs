using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la cocina que desea cocinar");

            Console.WriteLine("Presiona Enter para continua");
            Console.ReadLine();

            Console.Write("Que desea cocinar?");
            List<String> list = new List<String>();
            list.Add("1)Locro");
            list.Add("2)Pollo al sillao");
            list.Add("3)Lomo Saltado");
            list.Add("4)Carne asada");

            foreach (string prime in list)
            {
                System.Console.WriteLine(prime);
                Console.ReadLine();
                
            }
           

            Console.ReadLine();

            Console.WriteLine("Estos son los ingredientes Naturales que se usaran");
            Naturales naturales = new Naturales();
            Console.WriteLine(naturales.nombre1);
            Console.WriteLine(naturales.nombre2);
            Console.WriteLine(naturales.nombre3);

            Console.ReadKey();

            Console.WriteLine("Estos son los ingredientes Procesados que se usaran");
            Procesados procesados = new Procesados();
            Console.WriteLine(procesados.nombre1);
            Console.WriteLine(procesados.nombre2);
            Console.WriteLine(procesados.nombre3);

            Console.ReadKey();

            Console.WriteLine("Desea Agregar estas fruta?");
            Fruta frutas = new Fruta();
            Console.WriteLine(frutas.nombre1);
            Console.WriteLine(procesados.nombre2);
            Console.WriteLine(procesados.nombre3);

            Console.WriteLine("Presiona S para si o N para No");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.ToString() == "s")
            {
                Console.WriteLine("Se Utilizaran las frutas");
            }
            else
            {
                Console.WriteLine("No se utilizaran las frutas");
            }
            Console.WriteLine("Cocinando...");
            Console.WriteLine("Su Orcen esta lista");
            Console.WriteLine("Gracias por usar el sistema");

            Console.ReadLine();
        }

    }
}
