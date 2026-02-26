using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2_Scripting
{
   public abstract class Empleado : IPagable
    {
         public int Id { get; private set; }
         public string Nombre { get; private set; }

        public Empleado(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public abstract decimal CalcularSalario();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }
}
