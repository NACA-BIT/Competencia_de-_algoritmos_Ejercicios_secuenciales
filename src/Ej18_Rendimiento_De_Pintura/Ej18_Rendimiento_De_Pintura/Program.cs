//Cuanto rinde la pintura por metro cuadrado
int metrosAPintar, rendimiento, litros, latasUsadas, pinturaSobrante;
Console.WriteLine("Man, dime cuanto mide lo que quieres pintar (En metros cuadrados)");
metrosAPintar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cuanto le rinde cada lata? (En metros cuadrados sobre litro)");
rendimiento=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cuantos litros trae cada lata?");
litros=Convert.ToInt32(Console.ReadLine());



//proceso
latasUsadas = metrosAPintar / rendimiento;
pinturaSobrante = metrosAPintar % rendimiento;
//Salida
Console.WriteLine($"Bueno, pa pintar esa obra de arte moderno, necesitas {latasUsadas} latas y te sobraria {pinturaSobrante} litros");
