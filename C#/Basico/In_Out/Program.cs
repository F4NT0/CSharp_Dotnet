using System;
using System.IO;

namespace In_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variáveis pré-definidas
            int valor = 5;
            double dividendo = 8.0;
            double divisor = 3.0;

            // Entrada de valor pré-definido
            string valorDefinido = "6";
            Console.SetIn(new StringReader(valorDefinido));
            //string entrada = Console.ReadLine();

            // Entrada de valor esperando o usuário
            // Console.Write("Insira um valor de 0 a 10: ");
            // string entrada = Console.ReadLine();

            // Divisão
            double divisao = dividendo / divisor;

            // Saída
            Console.WriteLine("Valor = " + valor);
            Console.WriteLine($"Valor = {valor}");

            //Console.WriteLine($"Valor de entrada: {entrada}");

            Console.WriteLine($"Divisão = {divisao}");
            Console.WriteLine($"Divisão = {divisao.ToString("0.##")}");
        }
    }
}
