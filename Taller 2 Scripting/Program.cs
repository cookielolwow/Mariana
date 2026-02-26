using Taller_2_Scripting;
using System;
using System.Collections.Generic;

    List<Empleado> empleados = new List<Empleado>();

    empleados.Add(new EmpleadoTiempoCompleto(000547537, "Ana Maria Gallego", 3000000));
    empleados.Add(new EmpleadoPorHoras(000481023, "Carlos Andres Pulgarin", 120, 20000));
    empleados.Add(new EmpleadoTiempoCompleto(000214355, "Laura Zo", 3500000));
    empleados.Add(new EmpleadoPorHoras(000153738, "Pedro Pascal Saldarriaga", 80, 25000));


    for (int i = 0; i < empleados.Count; i++)
    {
        empleados[i].MostrarInformacion(); 
    }

    Console.ReadLine();
