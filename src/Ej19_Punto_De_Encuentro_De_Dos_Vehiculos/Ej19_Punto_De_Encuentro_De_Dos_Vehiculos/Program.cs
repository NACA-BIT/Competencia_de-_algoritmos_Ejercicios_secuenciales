/*Dos vehículos separados por distancia D 
 * salen al mismo tiempo uno hacia el otro, 
 * con velocidades v1 y v2. Calcule el tiempo 
 * hasta el encuentro y la distancia que recorrió cada uno.*/
string unidadDistancia;
int Distancia;
double DistanciaRecorrida1, DistanciaRecorrida2, velocidad1, velocidad2,
    velocidadMs1=0, velocidadMs2=0, tiempoHastaEncuentro=0, tiempoC1=0, tiempoC2=0;
//entrada distanciaRecorridaCarro1 distanciaRecorridaCarro2
Console.WriteLine("Man, dime cuanta distancia hay entre los vehiculos?");
Distancia=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Metros o Kilometros??");
unidadDistancia=Console.ReadLine();


//Aqui quise meter un while para comprobar si el valor ingresado es el correcto y no avanzar hasta que ingrese el valor correcto
//pero no me dejo :c
/*while (unidadDistancia != "metros"|| unidadDistancia != "Metros" || unidadDistancia != "M" || unidadDistancia != "m"
    || unidadDistancia != "kilometros" || unidadDistancia != "Kilometros" || unidadDistancia != "K" || unidadDistancia != "k")
{
    Console.WriteLine("Manito, no se haga el chistoso, Metros o Kilometros?");
    unidadDistancia = Console.ReadLine();
}
*/


Console.WriteLine("Chebre, a que velocidad va el primer carrito? (En Km/H)");
velocidad1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y a que velocidad va el segundo carrito? (En Km/H)");
velocidad2=Convert.ToDouble(Console.ReadLine());

//proceso
if (unidadDistancia == "M" || unidadDistancia == "m" || unidadDistancia == "Metros" || unidadDistancia=="metros")
{
    velocidadMs1 = Math.Truncate(velocidad1 / 3.6 * 100)/100;
    velocidadMs2 = Math.Truncate(velocidad2 / 3.6 * 100)/100;
    tiempoC1 = Math.Truncate(Distancia / velocidadMs1 *100)/100;
    tiempoC2 = Math.Truncate(Distancia / velocidadMs2 *100)/100;
    tiempoHastaEncuentro = Math.Truncate(Distancia/(velocidadMs1 + velocidadMs2)*100)/100;
    DistanciaRecorrida1 = Math.Truncate((velocidadMs1 * tiempoHastaEncuentro)*100)/100;
    DistanciaRecorrida2 = Math.Truncate((velocidadMs2 * tiempoHastaEncuentro)*100)/100;
    //salida
    Console.WriteLine($"Ok, los dos carritos se encuentran en {tiempoHastaEncuentro} segundos");
    Console.WriteLine($"El carrito 1 recorrio {DistanciaRecorrida1} metros y el Carrito 2 recorrio {DistanciaRecorrida2} metros");
}
else if (unidadDistancia == "Km" || unidadDistancia == "km" || unidadDistancia == "Kilometros" || unidadDistancia == "kilometros")
{
   tiempoC1 = Math.Truncate(Distancia / velocidad1 * 100) / 100;
    tiempoC2 = Math.Truncate(Distancia / velocidad2 * 100) / 100;
    tiempoHastaEncuentro = Math.Truncate(Distancia/(velocidad1 + velocidad2) * 100) / 100;
    DistanciaRecorrida1 = Math.Truncate((velocidad1 * tiempoHastaEncuentro) * 100) / 100;
    DistanciaRecorrida2 = Math.Truncate((velocidad2 * tiempoHastaEncuentro) * 100) / 100;

    //salida
    Console.WriteLine($"Ok, los dos carritos se encuentran en {tiempoHastaEncuentro} Horas");
    Console.WriteLine($"El carrito 1 recorrio {DistanciaRecorrida1} Kilometros y el Carrito 2 recorrio {DistanciaRecorrida2} Kilometros");
}



