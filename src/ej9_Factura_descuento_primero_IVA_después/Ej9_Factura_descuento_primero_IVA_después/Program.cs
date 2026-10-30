//factura con descuento + iva
double subtotal, subtotaldescontado, descuento, iva, total;
//entrada
Console.WriteLine("Manito, dime porfavor cuanto te costo el mercado?");
subtotal = Convert.ToDouble(Console.ReadLine());
//proceso (este si es muy intuitivo)
descuento = 0.10;
subtotaldescontado = subtotal * descuento;
iva =subtotaldescontado* 0.19;
total = (subtotal-subtotaldescontado)+iva;

//salida
Console.WriteLine($"descuento {subtotaldescontado} - iva {iva} - total {total}");
