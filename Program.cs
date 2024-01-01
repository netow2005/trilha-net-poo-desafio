using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using DesafioPOO.Models;

Nokia N1 = new Nokia("99774331", "NokiaG21", "123123", 128);
Console.WriteLine($"Usando um Nokia: ");
N1.Ligar();

N1.ReceberLigacao();

N1.InstalarAplicativo("Whatsapp");

Iphone I1 = new Iphone("88564526", "Iphone14", "321321", 256);

Console.WriteLine("\nUsando um iphone: ");

I1.ReceberLigacao();

I1.InstalarAplicativo("Safari");

