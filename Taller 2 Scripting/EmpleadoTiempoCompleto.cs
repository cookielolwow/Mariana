using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2_Scripting
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        private decimal salarioFijo;

        public EmpleadoTiempoCompleto(int id, string nombre, decimal salarioFijo)
            : base(id, nombre)
        {
            this.salarioFijo = salarioFijo;
        }

        public override decimal CalcularSalario()
        {
            return salarioFijo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Tiempo Completo");
            Console.WriteLine($"Salario: {CalcularSalario()}");
            Console.WriteLine("**************************");
        }
    }
}
