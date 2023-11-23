using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camacho_Victor_POO
{
    class Gerente : Empleado, IMostrarInformacion
    {
        public string Departamento { get; set; }

        public Gerente(string nombre, float salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }

        public new void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
