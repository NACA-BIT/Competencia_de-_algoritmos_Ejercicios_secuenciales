//Toma un numero de 4 cifras y muestra sus milllares, centenas, decenas y unidades 
//(nota pal instructor: aqui reutilice el codigo anterior y lo modifique para el ejercicio, perdon instru necesitaba agilizar D:)
int  millares, centenas, decenas, unidades, numeroNormal;
//entrada
Console.WriteLine("Manito, dime un numero de cuatro cifras pa sumarlo :D");
numeroNormal = Convert.ToInt32(Console.ReadLine());
while (numeroNormal < 1000)
{
    Console.WriteLine("NO SABE LEER?, DIJE CUATRO CIFRAS >:c");
    Console.WriteLine("Dime el numero de CUATRO CIFRAS otra vez porfavor");
    numeroNormal = Convert.ToInt32(Console.ReadLine());
}
//Salida
unidades = numeroNormal % 10;
decenas = (numeroNormal / 10) % 10;
centenas = (numeroNormal / 100) % 10;
millares = (numeroNormal / 1000) % 10;


Console.WriteLine($"Listo manito, la radiografia nos muestra que son {unidades} millares, {decenas} centenas, {centenas} decenas, {millares} unidades");