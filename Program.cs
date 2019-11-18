using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista fut1 = new Futbolista();
            fut1.Leer();
            fut1.Mostrar();
            Console.ReadKey();
        }
    }
}
