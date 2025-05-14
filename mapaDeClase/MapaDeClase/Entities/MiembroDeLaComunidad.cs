using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaDeClase.Entities
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public MiembroDeLaComunidad(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public virtual void presentar()
        {
            Console.WriteLine($"El Nombre es: {Nombre} ");
            Console.WriteLine($"El Apellido es: {Apellido} ");
            Console.WriteLine($"La Edad es: {Edad} ");
        }
    }
}