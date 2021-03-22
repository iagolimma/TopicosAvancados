using Model.Ex9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LstOO
{
    class Ex9
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            leitor.ReadPrices();
            
            Console.ReadKey();
        }
    }
}
