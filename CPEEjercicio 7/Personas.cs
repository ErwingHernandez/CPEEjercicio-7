using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_7
{
    internal class Personas
    {
        string nom;
        public Personas() { }
        public Personas(string nom)
        {
            this.nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            return "Nom: " + this.Nom;
        }
    }
    class Profesor:Personas
    {
        public Profesor(string nombre)
        {
            this.Nom = nombre;
        }


        public void Explicar()
        {
            Console.WriteLine($"{Nom} está explicando.");
        }
    }
    class Estudiante : Personas
    {

        public Estudiante(string nombre)
        {
            this.Nom = nombre;
        }

        public void Estudiar()
        {
            Console.WriteLine(this.Nom + " está estudiando.");
        }
    }
}
