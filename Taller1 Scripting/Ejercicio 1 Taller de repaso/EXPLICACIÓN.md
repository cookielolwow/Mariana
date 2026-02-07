1.	En este código lo que hice fue imprimir únicamente los números primos que aparecieron dentro de los primeros términos de la serie de 	Fibonacci. Primero definí n=6, o sea que revisé solo los primeros 6 números, y empecé la serie con a = 0 y b = 1.

    Después mostré un mensaje y usé un ciclo for que se repitió n veces para ir generando cada término de Fibonacci. Dentro del ciclo c	reé una variable llamada primo, que asumí como verdadera al inicio, pero descarté los números menores que 2 porque no son primos.

    Luego utilicé otro for interno para comprobar si el número a se podía dividir exactamente por algún valor entre 2 y a-1. Si 	encontraba una división exacta, marqué que no era primo y salí del ciclo con break.
	
    Si al final el número sí resultaba primo, lo imprimí. Finalmente calculé el siguiente término sumando a + b y actualicé las 	variables para continuar con la serie.


2. Primero le pedí al usuario que ingresara los segundos por consola y los guardé en una variable llamada segs.

   Después llamé a la función ConvertirASegundos, que fue la que se encargó de hacer la conversión, y guardé el resultado en un string 	llamado reloj. Luego simplemente imprimí el formato final en pantalla.

    Dentro de la función, primero calculé las horas dividiendo los segundos entre 3600. Después saqué los minutos usando el residuo que 	sobraba y dividiéndolo entre 60. Finalmente obtuve los segundos restantes con el módulo 60.
