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
            Console.WriteLine("Decremento depois = " + valor2 + "\n"); // 8

            /*
                Tipos de valores 
            */
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            sbyte maxSByte = sbyte.MaxValue;
            sbyte minSByte = sbyte.MinValue;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine($"Max Int: {maxInt}");
            Console.WriteLine($"Min Int: {minInt}");
            Console.WriteLine($"Max Decimal: {maxDecimal}");
            Console.WriteLine($"Min Decimal: {minDecimal}");
            Console.WriteLine($"Max Sbyte: {maxSByte}");
            Console.WriteLine($"Min Sbyte: {minSByte}");
            Console.WriteLine($"Max Double: {maxDouble}");
            Console.WriteLine($"Min Double: {minDouble}");
            Console.WriteLine($"Max Long: {maxLong}");
            Console.WriteLine($"Min Long: {minLong}\n");

            /*
                Classe Math
            */
            double dividendo = 8;
            double divisor = 3;
            Console.WriteLine($"Dividendo: {dividendo}, Divisor: {divisor}, {dividendo}/{divisor} = {dividendo/divisor}"); // 2,6666666666666665
            
            double arredondamentoMaior = Math.Ceiling(dividendo/divisor);
            double arredondamentoMenor = Math.Floor(dividendo/divisor);
            Console.WriteLine($"Arredondamento para mais: {arredondamentoMaior}");
            Console.WriteLine($"Arredondamento para menos: {arredondamentoMenor}");

            double arredondamentoControle = Math.Round(dividendo/divisor);
            Console.WriteLine($"Arredondamento usando Round: {arredondamentoControle}\n");

            double maximo = Math.Max(dividendo,divisor);
            double minimo = Math.Min(dividendo, divisor);

            Console.WriteLine($"Máximo valor entre {dividendo} e {divisor}: {maximo}");
            Console.WriteLine($"Mínimo valor entre {dividendo} e {divisor}: {minimo}");

            int basePot = 2;
            int expoente = 3;
            int potencia = (int)Math.Pow(basePot, expoente);
            double potencia2 = Math.Pow(basePot, expoente);
            Console.WriteLine($"Potência \n\n Base: {basePot} \n Expoente: {expoente} \n potência normal: {potencia2}, \n potência usando cast de Inteiro: {potencia}");


        }
    }
}
