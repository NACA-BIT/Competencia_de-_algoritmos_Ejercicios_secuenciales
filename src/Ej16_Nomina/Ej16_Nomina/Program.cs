//Nomina con horas extra
double  horasTrabajadas, horasExtra, pagoExtra, valorHora, salaBase;
//entrada
Console.WriteLine("Manito, dime cuantas horas trabajaste este mes?");
horasTrabajadas=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("dime cuanto te pagan la hora");
valorHora=Convert.ToDouble(Console.ReadLine());
//proceso

horasExtra = horasTrabajadas % 160;
salaBase = valorHora * 160;
pagoExtra = (valorHora * 1.25) * horasExtra;
//salida
Console.WriteLine($"Listo hermano, su Salario Base es de {salaBase} pesos"); 
Console.WriteLine($"En total trabajaste {horasExtra} Horas extras"); 
Console.WriteLine($"Y este mes te van a dar {pagoExtra} de pago extra por tus horas"); 
    