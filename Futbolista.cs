using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Persona
{
    public class Futbolista:Persona
    {
        public string Equipo { set; get; }
        public int Sueldo { set; get; }

        public Futbolista()
        {
            Equipo = " ";
            Sueldo = 0;
        }
        public override void Leer()
        {
            base.Leer();
            Console.Write("Ingrese el equipo: ");
            Equipo = Console.ReadLine();
            Console.Write("Ingrese el sueldo: ");
            Sueldo = Convert.ToInt32(Console.ReadLine());
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine(Equipo);
            Console.WriteLine(Sueldo);

        }
    }
}
