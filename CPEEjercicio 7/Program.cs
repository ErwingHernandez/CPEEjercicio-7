using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas[] p1 = new Personas[3];
            p1[0] = new Profesor("Juan");
            p1[1] = new Estudiante("Sara");
            p1[2] = new Estudiante("Carlos");
            
            foreach(Personas p in p1)
            {
                if(p is Estudiante)
                {
                    ((Estudiante)p).Estudiar();
                }
                else
                {
                    ((Profesor)p).Explicar();
                }
            }
            Console.ReadKey();
        }
    }
}
