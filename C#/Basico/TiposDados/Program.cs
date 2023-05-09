using System;

namespace TiposDados
{
    public class Program
    {
        public static void Main(String[] args)
        {
            /*
            | Exemplos de tipos de dados
            */
            bool valorBool = true;
            int valorInt = 10;
            float valorFloat = 10.0f;
            double valorDouble = 10.0;
            decimal valorDecimal = 10.0m;
            char valorChar = 'a';
            byte valorByte = 10;
            object valorObject = "10";
            string valorString = "10";

            Console.WriteLine($"Valor Bool: {valorBool}");
            Console.WriteLine($"Valor Int: {valorInt}");
            Console.WriteLine($"Valor Float: {valorFloat}");
            Console.WriteLine($"Valor Double: {valorDouble}");
            Console.WriteLine($"Valor Decimal: {valorDecimal}");
            Console.WriteLine($"Valor Char: {valorChar}");
            Console.WriteLine($"Valor Byte: {valorByte}");
            Console.WriteLine($"Valor Object: {valorObject}");
            Console.WriteLine($"Valor String: {valorString}\n\n");

            /*
            | Exemplos de Backing Types
            */
            Int32 valorInt32 = 10;
            Boolean valorBoolean = true;
            Byte valorByte2 = 10;
            Char valorChar2 = 'a';
            Decimal valorDecimal2 = 10.0m;
            Double valorDouble2 = 10.0;
            Single valorSingle = 10.0f;
            Object valorObject2 = "10";
            String valorString2 = "10";
            Int64 valorInt64 = 10;

            Console.WriteLine($"Valor Int32: {valorInt32}");
            Console.WriteLine($"Valor Boolean: {valorBoolean}");
            Console.WriteLine($"Valor Byte: {valorByte2}");
            Console.WriteLine($"Valor Char: {valorChar2}");
            Console.WriteLine($"Valor Decimal: {valorDecimal2}");
            Console.WriteLine($"Valor Double: {valorDouble2}");
            Console.WriteLine($"Valor Single: {valorSingle}");
            Console.WriteLine($"Valor Object: {valorObject2}");
            Console.WriteLine($"Valor String: {valorString2}");
            Console.WriteLine($"Valor Int64: {valorInt64}\n\n");

            /*
            | Usando Datetime
            */
            DateTime data1 = new DateTime(2023,05,04); // ano, mes, dia
            DateTime hoje = DateTime.Today; // pega o dia de hoje
            DateTime agora = DateTime.Now; // pega a data e hora de agora
            DateTime doisDiasDepois = data1.AddDays(2); // dois dias depois da data inicial
            DayOfWeek dia = data1.DayOfWeek; // pega o dia da semana da data inicial
            bool isDST = data1.IsDaylightSavingTime(); // verifica se é dia

            Console.WriteLine($"Data1: {data1}");
            Console.WriteLine($"Hoje: {hoje}");
            Console.WriteLine($"Dois dias depois: {doisDiasDepois}");
            Console.WriteLine($"Dia da semana: {dia}");
            Console.WriteLine($"É dia: {isDST}");
            Console.WriteLine($"Agora: {agora}\n\n");

            /*
            | Usando TimeSpan
            */
            TimeSpan intervalo = new TimeSpan(2, 14, 18); // horas, minutos, segundos
            TimeSpan intervalo2 = new TimeSpan(1, 0, 0, 0); // dias, horas, minutos, segundos
            Console.WriteLine($"Intervalo: {intervalo}");
            Console.WriteLine($"Intervalo2: {intervalo2}\n\n");

            /*
            | Usando Strings
            */
            string s1 = "Hello World"; //string normal
            string s2 = string.Empty; // para identificar como string vazia
            var s3 = "This is a string"; //variável var que reconhece o dado como string
            string s4 = null; //variável de string nula
            string s5; //variável de string somente inicializada (sem valor ainda)
            s5 = "Teste"; //atribuindo valor a variável s5

            Console.WriteLine($"String normal: {s1}");
            Console.WriteLine($"String vazia: {s2}");
            Console.WriteLine($"String como var: {s3}");
            Console.WriteLine($"String nula: {s4}");
            Console.WriteLine($"String inicializada depois: {s5}\n\n");

            string parte1 = "Bem vindo ";
            string parte2 = "ao curso de C#";
            string novaString = String.Concat(parte1, parte2); //concatenação de strings
            Console.WriteLine($"Concatenação: {novaString}\n\n");

            /*
            | Utilizando Parse
            */
            string valorParse = "10";
            int valorConvertido = int.Parse(valorParse); //converte string para int
            Console.WriteLine($"Valor convertido de string: {valorConvertido}\n\n");
        }
    }
}
