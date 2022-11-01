using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Caculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");            
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");            
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");            
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");            
        }

        //Usando potência
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x}^^{y} = {potencia}");
        }


        // Trigonometria (seno, cosono e tangente)
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo} = {Math.Round(coseno,4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo} = {Math.Round(tangente,4)}");
        }

        
        // Incremento e Decremento

        // Raiz Quadrada

        public void RaizQuadrada( double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrade de {x} = {raiz}");
        }

    }
}