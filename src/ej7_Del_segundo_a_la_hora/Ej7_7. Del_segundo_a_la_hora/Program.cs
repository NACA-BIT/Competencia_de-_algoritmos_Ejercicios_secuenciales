//Comversion de unidades de segundos a horas
//int , , ,, ,restante restantefinal;
int segundos_base,segundos, horas,minutos;
//entrada
Console.WriteLine("Man, dime la cantidad de segundos que quieras convertir");
segundos_base = Convert.ToInt32(Console.ReadLine());
//procesos

//Para sacar H/M/S
//se empieza dividiendo los segundos base (los segundos que da el usuario) sobre 3600 (el equivalente de una hora en segundos) para obtener el numero de horas

horas = segundos_base / 3600;
//para minutos es lo mismo pero diferente, necesitamos el residuo de la division anterior (para eso es el %) y ese residuo dividirlo por 60 (el equivalente en segundos de 1 minuto)
//para que filtre ese residuo que fue lo que nos sobro de la division y lo combierta a minutos dividiendolo en 60

minutos = (segundos_base % 3600)/ 60;

//para segundos lo unico que necesitamos es el residuo de segundos_base (lo que nos sobro de la division anterior)
segundos = segundos_base % 60;

//salida

Console.WriteLine($"Ahora por el poder de graiscol, se que tus segundos valen {horas} horas, {minutos} minutos, {segundos} segundos");