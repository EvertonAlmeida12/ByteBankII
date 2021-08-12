using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
    class Program
    {
        static void Main(string[] args)
        {
            //pagina?argumentos
            //01234567

            string url = "pagina?argumentos";
            Console.WriteLine(url);

            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
