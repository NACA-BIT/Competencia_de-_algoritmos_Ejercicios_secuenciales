//Cajero en billetes minimos: el cajero debe dar la menor cantidad de billetes necesarios
//La variable debe ser en int (entero) y no double (decimal), ya que si no,
//nos dara resultados decimales y quedaria mal el ejercicio
int monto, resto, UltiResto, Billete50, Billete20, Billete10, Billete5;
//entrada
Console.WriteLine("Bienvenido a Mondabank");
Console.WriteLine("cuanto desea retirar :D?");
monto = Convert.ToInt32(Console.ReadLine());
//Proceso (Manito, como el ejercicio anterior, acuerdese)

Billete50 = monto / 50000;
resto = monto % 50000;
//Se pone el resto en lugar del monto de aqui para abajo ya que si no (si seguimos poniendo monto)
//nos daria la cantidad de billetes EQUIVALENTE de cada denominacion.
//Cada resto se va actualizando en cada linea, el resto contiene el residuo de la primera division y asi sucesivamente, haciendo que de ahi para abajo
//tome cada residuo de cada division y siga dividiendo, hasta que el residuo es cero, para asi
//sacar la menor cantidad de billetes del cajero
Billete20 = resto / 20000;
resto = resto % 20000;
Billete10 = resto / 10000;
resto = resto % 10000;
Billete5 = resto / 5000;
UltiResto = resto % 5000;
//Salida
Console.WriteLine($"Joa Papi tu eres la verdadera monda, el cajero te dara {Billete50} de 50 barras, {Billete20} de 20 ,{Billete10} de 10 vale," +
    $" y {Billete5} de 5 cacha :D");