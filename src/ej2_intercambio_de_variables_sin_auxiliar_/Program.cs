//intercambio de variables sin auxiliar
int a, b;
Console.WriteLine("Porfavor ingresa el valor de A:");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ahora dime el valor de B: ");
b=Convert.ToInt32(Console.ReadLine());
//permutar valores

a = a+b;
b = a-b;
a = a-b;
Console.WriteLine($"los valores permutados serian, A seria igual a: {a} y B seria igual a: {b}");