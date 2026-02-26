Para empezar con nuestras decisiones de diseño...  Empezamos creando la interfaz de IPagable para cualquier clase que represantara un empleado implemnetara el método CalcularSalario(). Esto permite que sea mas flexible a la hora de agregar
nuevos empleados se pueda poner de forma mas sencilla la lógica.

Continuando, creamos la clase de empleado de forma abstracta porque es una clase genérica y pues por el caso del taller no tendria sentido crear una clase empleado sin tipo. En ella implementamos la interfaz. 
Tienes propiedades que se pidieron, que serian el id y el nombre, que definimos mediante el encapsulamiento con private set. Además definimos el metodo de la interfaz CalcularSalario() para clases que van a heredar de esta a implementarlo. Y el metodo MostrarInformación() que pueda ser sobrescrito.

La herencia la usamos en las clases EmpleadoTiempoCompleto y EmpleadoPorHoras. En la clase EmpleadoTiempoCompleto añadimos el atributo salarioFijo que era la caracteristica de esta clase, y 
se sobrescribió el método CalcularSalario() para que simplemente se mostrara el salario fijo del empleado. y además, sobrescribimos el método MostrarInformacion() para mostrar el tipo de empleado y  su salario.

En la clase EmpleadoPorHoras añadimos los atributos horasTrabajadas y valorHora. En el método  CalcularSalario() lo implemnetamos multiplicando las horas de trabajo por el valor de cada hora. Aqui se evidencia el polimorfismo,
ya que el mismo método que definimos en la clase padre se puede comportar de forma diferente dependiento del tipo de empleado.  


