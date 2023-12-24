using System.Data.Common;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DecolaTech;

Console.WriteLine("Testando as operações matematicas");

Calculadora calc = new Calculadora();
calc.Somar(6,7);
calc.Subtrair(123,40);
calc.Multiplicar(12,20);
calc.Dividir(20,4);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(64);

