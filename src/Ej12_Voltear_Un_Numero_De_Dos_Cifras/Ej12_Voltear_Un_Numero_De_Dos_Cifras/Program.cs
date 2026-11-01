//voltee el numero(en este caso vamos a usar decenas y unidades para hacerlo)
int  decenas,unidades,numeroNormal;
//
//entrada
Console.WriteLine("Manito, dime un numero de dos cifras :D");
numeroNormal=Convert.ToInt32(Console.ReadLine());
while (numeroNormal<10 || numeroNormal>99)
{
    Console.WriteLine("NO SABE LEER?, DIJE DOS CIFRAS >:c");
    Console.WriteLine("Dime el numero de DOS CIFRAS otra vez porfavor");
    numeroNormal = Convert.ToInt32(Console.ReadLine());
}
//Entrada
unidades = numeroNormal % 10;
decenas=(numeroNormal/10)  % 10;

Console.WriteLine($"Listo manito, el numero girado es ... {unidades}{decenas}");