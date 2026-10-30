//el rectangulo que crece
//definir variables
double area, area_mas, perimetro, perimetro_mas, basse, altura;
Console.WriteLine("Manito, dime la base de tu rectangulo pa que crezca :D");
basse= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ahora dime la altura pa que hacer la magia :D");
altura= Convert.ToDouble(Console.ReadLine());
//procesos
area = basse * altura;
area_mas = (basse * altura)*2;
perimetro = 2 * (basse + altura);
perimetro_mas = 2 * (basse + altura)*3;

Console.WriteLine($"el area original es: {area} y el perimetro original es: {perimetro}");
Console.WriteLine("y.....");
Console.WriteLine($"el doble del area es: {area_mas} y el triple del perimetro es {perimetro_mas}");
Console.WriteLine("TARAN :DDD");