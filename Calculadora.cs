using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech
{
    public class Calculadora
    {
        public void Somar (int a, int b){
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        public void Subtrair (int a, int b){
            Console.WriteLine($"{a} - {b} = {a-b}");
        }
        public void Multiplicar (int a, int b){
            Console.WriteLine($"{a} X {b} = {a*b}");
        }
        public void Dividir (int a, int b){
            Console.WriteLine($"{a} / {b} = {a/b}");
        }
        public void Potencia(int a, int b){
            double pot = Math.Pow(a,b);
            Console.WriteLine($"{a} ^ {b} = {pot}");
        }
        public void Seno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno =  Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Cosseno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double cosseno =  Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(cosseno, 4)}");
    }
        public void Tangente (double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente =  Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double a){
            double raiz = Math.Sqrt(a);
            Console.WriteLine($"Raiz quadrade de {a} = {raiz}");
        }
    }
}