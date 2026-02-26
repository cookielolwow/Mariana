Para empezar con nuestras decisiones de diseño...  Empezamos creando la interfaz de IPagable para cualquier clase que represantara un empleado implemnetara el método CalcularSalario(). Esto permite que sea mas flexible a la hora de agregar
nuevos empleados se pueda poner de forma mas sencilla la lógica.

Continuando, creamos la clase de empleado de forma abstracta porque es una clase genérica y pues por el caso del taller no tendria sentido crear una clase empleado sin tipo. En ella implementamos la interfaz. 
Tienes propiedades que se pidieron, que serian el id y el nombre, que definimos mediante el encapsulamiento con private set. Además definimos el metodo de la interfaz CalcularSalario() para clases que van a heredar de esta a implementarlo. Y el metodo MostrarInformación() que pueda ser sobrescrito.

La herencia la usamos en las clases EmpleadoTiempoCompleto y EmpleadoPorHoras. En la clase EmpleadoTiempoCompleto añadimos el atributo salarioFijo que era la caracteristica de esta clase, y 
se sobrescribió el método CalcularSalario() para que simplemente se mostrara el salario fijo del empleado. y además, sobrescribimos el método MostrarInformacion() para mostrar el tipo de empleado y  su salario.

En la clase EmpleadoPorHoras añadimos los atributos horasTrabajadas y valorHora. En el método  CalcularSalario() lo implemnetamos multiplicando las horas de trabajo por el valor de cada hora. Aqui se evidencia el polimorfismo, ya que el mismo método que definimos en la clase padre se puede comportar de forma diferente dependiento del tipo de empleado.  Creamos sus atributos y constructor basados en lo que necesitaria la clase que seria id, nombre, horasTrabajadas y valorHora. De esta manera, nos aseguramos de recibir los datos y calcular su salario correctamente.


En cuanto al main, creamos una lista de tipo List<Empleado>. Aunque la lista está declarada con el tipo de la clase base, en ella agregamos objetos tanto de EmpleadoTiempoCompleto como de EmpleadoPorHoras. Esto nos permitió trabajar con todos los empleados de manera general, sin importar su tipo específico del empleadoo. En este punto evidenciamos polimorfismo porque usamos la referencia de empleado para manejar los otros tipos de empleados, y aun así cada uno responde como se deberia al recorrer la lista y llamar al método MostrarInformacion().

<img width="736" height="648" alt="image" src="https://github.com/user-attachments/assets/53d9775f-f8a2-47a0-aec9-1625eac3d4a7" />

hoy nos sentimos asi, buenos flashbacks de poo.


