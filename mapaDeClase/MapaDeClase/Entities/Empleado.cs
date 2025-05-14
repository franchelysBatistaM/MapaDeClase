using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaDeClase.Entities
{
    public class Empleado : MiembroDeLaComunidad
    {
        public decimal Salario { get; set; }
        public string Puesto { get; set; }
        public Empleado(string nombre, string apellido, int edad, decimal salario, string puesto)
            : base(nombre, apellido, edad)
        {
            Salario = salario;
            Puesto = puesto;
        }
        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"Este es su salario: {Salario}");
            Console.WriteLine($"Este es su puesto: {Puesto}");
        }
    }
}