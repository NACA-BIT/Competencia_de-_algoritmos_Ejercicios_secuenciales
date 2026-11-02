//Negocio o perdida??, vea si vale la pena o no

/* Nota: instru, perdon por todo este despelote, quise hacer una prueba para que el ejercicio fuera mas completo
 * para que calculara perdidas (en caso de haberlas) pero me tomaba mas tiempo del debido, retomare el ejercicio en otro momento
 * (porque me gusta complicarme pa aprender) por ahora asi quedaria de momento como usted lo pido*/

double costoFabricacion, precioVenta, unidadesVendidas, ganancias, Rentabilidad;

//unidadesPerdidas,unidadesFabricadas,perdidas
//entrada

Console.WriteLine("Manito, veamos si vale la pena el negocio");
Console.WriteLine("Dime cuanto es el costo de fabricacion?");
costoFabricacion=Convert.ToDouble(Console.ReadLine());

/*Console.WriteLine("Dime cuantas unidades fabricaste");
unidadesFabricadas=Convert.ToDouble(Console.ReadLine());*/

Console.WriteLine("Ahora dime a cuanto lo vendes?");
precioVenta=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y cuanto vendiste??");
unidadesVendidas=Convert.ToDouble(Console.ReadLine());

//proceso

//unidadesPerdidas = unidadesFabricadas - unidadesVendidas;
ganancias = (precioVenta - costoFabricacion) * unidadesVendidas;
//perdidas= (precioVenta-costoFabricacion) * unidadesPerdidas;
Rentabilidad = (ganancias / costoFabricacion) *10;

/*if (unidadesPerdidas>0)
{
    Rentabilidad = (perdidas / costoFabricacion) * 100;

    Console.WriteLine($"perdiste -{unidadesPerdidas} unidades, y la rentabilidad esta en -{Rentabilidad}%, y las perdidas se estiman en -{perdidas}");
}*/
Console.WriteLine($"Man, como que si esta dando la cosa, tienes ganancias de {ganancias} y la rentabilidad esta en un {Rentabilidad}%");
