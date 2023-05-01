using System;

namespace Matematica 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            /* 
                CÁLCULOS COM OPERADORES ARITMÉTICOS
            */

            // valores inteiros
            int x = 6;
            int y = 3;
            int z = 8;

            // valores de ponto flutuantes
            double z2 = 8.0;
            double y2 = 3.0; 

            // Soma
            int soma = x + y; // 6 + 3 = 9

            // Subtração positiva
            int subtracaoPos = x - y; // 6 - 3 = 3

            // Subtração negativa
            int subtracaoNeg = y - x; // 3 - 6 = -3

            // Multiplicação
            int multiplicacao = x * y; // 6 * 3 = 18

            // Divisão inteira
            int divisao = x / y; // 6 / 3 = 2

            // Divisão Fracionada
            double divisaoFrac = z2 / y2; // 8 / 3 = 2,6

            // Resto da divisão
            int resto1 = x % y; // 6 % 3 = 0
            int resto2 = z % y; // 8 % 3 = 2

            // Output
            Console.WriteLine($"Soma de {x} + {y} = {soma} \n");
            
            Console.WriteLine($"Subtração positiva de {x} - {y} = {subtracaoPos} \n");
            Console.WriteLine($"Subtração negativa de {y} - {x} = {subtracaoNeg} \n");
            
            Console.WriteLine($"Multiplicação de {x} * {y} = {multiplicacao} \n");
            
            Console.WriteLine($"Divisão de {x} / {y} = {divisao} \n");
            Console.WriteLine($"Divisão Fracionada de {z2} / {y2} = {divisaoFrac} \n");
            
            Console.WriteLine($"Resto da divisão de {x} % {y} = {resto1} \n");
            Console.WriteLine($"Resto da divisão de {z} % {y} = {resto2} \n");

            /*
                INCREMENTO E DECREMENTO
            */

            int valor1 = 6;
            int valor2 = 8;

            Console.WriteLine("Incremento antes = " + ++valor1); // 7

            Console.WriteLine("Incremento depois = " + valor2++); // 8
            Console.WriteLine("Incremento depois = " + valor2); // 9

            Console.WriteLine("Decremento antes = " + --valor1); // 6

            Console.WriteLine("Decremento depois = " + valor2--); // 9
            Console.WriteLine("Decremento depois = " + valor2); // 8
        }
    }
}
