using Model.Ex13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LstOO
{
    class Ex13
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora();

            impressora.ReadNumber();
            impressora.PrintNumbers();

            Console.ReadKey();
        }
    }
}
