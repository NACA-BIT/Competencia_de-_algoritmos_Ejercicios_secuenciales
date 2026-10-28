//Intercambio con variable auxiliar
int a, b, c;
Console.Write("dime el numero A: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Ahora dime el numero B: ");
b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"el numero original A es {a} y el numero B es {b}");

c = a;
a = b;
b = c; 

Console.WriteLine($"el numero cambiado es A es {a} y el numero B es {b}");