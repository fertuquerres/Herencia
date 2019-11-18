using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Persona
{
    public class Persona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Edad { set; get; }
        
        public Persona()
        {
            Nombre = " ";
            Apellido = " ";
            Edad = 0;
        }
        public virtual void Leer()
        {
            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Edad);

        }
    }
}
