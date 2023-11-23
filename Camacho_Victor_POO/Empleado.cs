using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camacho_Victor_POO
{
    class Empleado:IMostrarInformacion
    {
        public string Nombre;
        public float Salario;
         
        
        public Empleado(string nombre, float salario)
        {
            Nombre=nombre;
            Salario=salario;
        }
        public float salAnual()
        {
            return Salario * 12;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario: {Salario:C}");
            Console.WriteLine($"Salario Anual: {salAnual():C}");
        }
    }
}
