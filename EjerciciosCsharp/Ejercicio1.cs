Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu edad");
byte edad = Convert.ToByte(Console.ReadLine()); //byte porque nadie podría tener -0 ni +255 años

Console.WriteLine("Tu nombre es " + char.ToUpper(nombre[0]) + nombre.Substring(1) + " y tienes " + edad + " años");

Console.WriteLine("\n\n Ahora ingresa la hora en el formato hora:minutos");
string hora = Console.ReadLine();
Console.WriteLine("La hora ingresada es: " + hora + " hs,");