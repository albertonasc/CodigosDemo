using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("Porto Alegre");
            cidades.Add("Florianópolis");
            cidades.Add("São José");
            cidades.Add("Coritiba");

            BuscarListaComLinqLambda(cidades, "Sã").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        public static string BuscarPrimeiroComForEach(List<string> lista, string termo)
        {
            foreach(string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }
            return null;
        }

        public static string BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Equals(termo) select item).First();
        }

        public static string BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }

        public static List<string> BuscarListaComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarListaComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }



    }
}
