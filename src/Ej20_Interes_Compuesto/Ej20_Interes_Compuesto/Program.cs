//Calcular la tasa de interes
//entrada
double capitalInicial, tasaDeInteres, numeroMeses, capitalFinal,interesesGanados ;
Console.WriteLine("Veamos como esta tu interes compuesto");
Console.WriteLine("De cuanto fue tu capital inicial?");
capitalInicial=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Cuanto es el porcentaje de tu tasa de interes mensual?");
tasaDeInteres=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Durante cuantos meses lo llevaste?");
numeroMeses=Convert.ToDouble(Console.ReadLine());
//proceso 
capitalFinal = capitalInicial * Math.Pow((1 + tasaDeInteres / 100),numeroMeses);
interesesGanados = capitalFinal - capitalInicial;
    //salida
Console.WriteLine($"Ok, empezaste con {capitalInicial} de capital inicial su capital es de {capitalFinal:F2} y ganaste {interesesGanados:F2} en intereses");