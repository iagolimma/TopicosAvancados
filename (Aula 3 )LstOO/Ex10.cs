using Model.Ex10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LstOO
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Estatisticas estatisticas = new Estatisticas();

            estatisticas.ReadData();
            estatisticas.DisplayStatistics();

            Console.ReadKey();
        }
    }
}
