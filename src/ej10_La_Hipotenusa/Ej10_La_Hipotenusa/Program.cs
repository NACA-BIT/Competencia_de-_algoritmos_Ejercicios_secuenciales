//En fin, la Hipotenusa
double cat1, cat2, hipotenusa;
Console.WriteLine("Dame tu cateto 1 porfa");
cat1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ahora dime tu cateto 2");
cat2=Convert.ToDouble(Console.ReadLine());
//entrada
//recomendacion, sepa la bola porque, pero debes elevar al cuadrado antes de elevarlo a raiz
//si no, te dara un resultado incorrecto
cat1 = cat1 * cat1;
cat2 = cat2 * cat2;
hipotenusa = Math.Sqrt(cat1 + cat2);
//salida
Console.WriteLine($"En fin, la hipotenusa es: {hipotenusa}");