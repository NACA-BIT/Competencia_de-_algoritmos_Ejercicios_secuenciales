//Leer un numero de 3 digitos y sumar esos nueros
//(nota pal instructor: aqui reutilice el codigo anterior y lo modifique para el ejercicio, perdon instru necesitaba agilizar D:)
int centenas,decenas, unidades, numeroNormal, numeroSumado;
//
//entrada
Console.WriteLine("Manito, dime un numero de tres cifras pa sumarlo :D");
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
numeroSumado = unidades + decenas + centenas;

Console.WriteLine($"Listo manito, el numero normalito seria {numeroNormal}, y la suma de sus tres digitos es... {numeroSumado}");