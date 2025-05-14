using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaDeClase.Entities
{
    public class Exalumno : MiembroDeLaComunidad
    {
        public string Fechainicio { get; set; }
        public string Fechatermino { get; set; }
        public Exalumno(string nombre, string apellido, int edad, string fechainicio, string fechatermino)
            : base(nombre, apellido, edad)
        {
            Fechainicio = fechainicio;
            Fechatermino = fechatermino;
        }
        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"empezo en: {Fechainicio}");
            Console.WriteLine($"termino en: {Fechatermino}");
        }
    }
}