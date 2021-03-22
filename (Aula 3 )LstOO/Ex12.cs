using Model.Ex12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LstOO
{
    class Ex12
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            Console.WriteLine("\nSoma: " + leitor.ReadNumbers());

            Console.ReadKey();
        }
    }
}
