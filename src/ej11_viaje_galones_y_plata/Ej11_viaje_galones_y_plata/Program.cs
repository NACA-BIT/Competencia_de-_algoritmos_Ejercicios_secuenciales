//Viaje, galones y money, Muestra cuanta plata y cuantos galones
//necesitas para recorrer x distancia
double Distancia, rendimiento, PrGalon, galonesNece, Money, Velocidad, tiempo;
//entrada1
Console.WriteLine("Manito, decime la velocidad a la que iras en el viaje (km/h)");
Velocidad=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ahora dime cuanto tiempo te echaste?");
tiempo=Convert.ToDouble(Console.ReadLine());
//salida1
Distancia = Velocidad * tiempo;
if (Distancia>50)
{
    Console.WriteLine($"eres el rasho Mac Queen has recorrido {Distancia} km, en {tiempo} horas");
    Console.WriteLine("Cuchau");
}
Console.WriteLine($"Manito, haz recorrido {Distancia} km");
//entrada2
Console.WriteLine("Listo pa, ya sabemos cuanto se echo, ahora hagamos cuentas");
Console.WriteLine("Cuanto le rinde el galon de gasolina? (km/g)");
rendimiento= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Listo pa, ahora cuanto le cuesta el galon? (En pesos colombianos no bolivares)");
PrGalon = Convert.ToDouble(Console.ReadLine());
galonesNece = Distancia / rendimiento;
Money=galonesNece*PrGalon;
//salida2
Console.WriteLine("Listo manito, le tengo las cuentas");
Console.WriteLine($"Necesitas {galonesNece} galones para poder viajar");
Console.WriteLine($"Y en total necesitas {Money} pesitos pa poder llegar con tantica gasolina");
Console.ReadKey();