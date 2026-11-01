//Voltea 3 numeros (Lo mismo que el ejercicio 12 pero diferente :D)
int centenas, decenas, unidades, numeroNormal;
//
//entrada
Console.WriteLine("Manito, dime un numero de tres cifras :D");
numeroNormal = Convert.ToInt32(Console.ReadLine());
while (numeroNormal < 100)
{
    Console.WriteLine("NO SABE LEER?, DIJE TRES CIFRAS >:c");
    Console.WriteLine("Dime el numero de TRES CIFRAS otra vez porfavor");
    numeroNormal = Convert.ToInt32(Console.ReadLine());
}
//Entrada
unidades = numeroNormal % 10;
decenas = (numeroNormal / 10) % 10;
centenas = (numeroNormal / 100) % 10;


Console.WriteLine($"Listo manito, el numero girado es ... {unidades}{decenas}{centenas}");