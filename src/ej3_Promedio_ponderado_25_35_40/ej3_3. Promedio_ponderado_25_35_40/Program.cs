//3.	Promedio ponderado (25 / 35 / 40)
//definir variables
double per1, per2, per3, total;
Console.Write("Manito, cuanto saco en el primer periodo?");
per1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Manito, cuanto saco en el segundo periodo?");
per2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Manito, cuanto saco en el tercer periodo?");
per3 = Convert.ToDouble(Console.ReadLine());
//definir %
per1 = per1 * 0.25;
per2 = per2 * 0.35;
per3 = per3 * 0.40;
total = per1 + per2 + per3;
//salida
Console.WriteLine($"El total de nota es {total}");