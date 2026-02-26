using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2_Scripting
{
    public class EmpleadoPorHoras : Empleado
    {
        private int horasTrabajadas;
        private decimal valorHora;

        
        public EmpleadoPorHoras(int id, string nombre, int horasTrabajadas, decimal valorHora)
            : base(id, nombre)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }


        public EmpleadoPorHoras(int id, string nombre)
            : base(id, nombre)
        {
            horasTrabajadas = 0;
            valorHora = 0;
        }

        public override decimal CalcularSalario()
        {
            return horasTrabajadas * valorHora;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Por Horas");
            Console.WriteLine($"Salario: {CalcularSalario()}");
            Console.WriteLine("**************************");
        }
    }
}
