using System;

namespace IfElse
{
    public class Program
    {
        public static void Main(string[] args) {
            
            // Variáveis
            int valor1 = 5;
            int valor2 = 6;
            string texto1 = "Texto";
            string texto2 = "Texto";
            string texto3 = "texto";
            string frase = "Buscando um Amor para a vida";

            /*
                COM OPERADORES DE COMPARAÇÃO
            */

            if (valor1 == valor2)
            {
                Console.WriteLine("Valor1 igual ao Valor2");
            }
            else if (valor1 != valor2)
            {
                Console.WriteLine("Valor1 diferente de Valor2");
            }
            else 
            {
                Console.WriteLine("Entrou no bloco Else");
            }

            /*
                COM OPERADORES LÓGICOS
            */
            string value = "Teste";

            if (value != null && value.Equals("Teste"))
            {
                Console.WriteLine("Entrou no bloco AND");
            }

            bool valueBool = false;

            if (valueBool == true || !valueBool)
            {
                Console.WriteLine("Entrou no bloco OR");
            }

            /*
                IF TERNÁRIO
            */
            
            string mensagem = (valor1 == valor2) ? "Entrou no IF" : "Entrou no ELSE";
            Console.WriteLine(mensagem);

            /*
                VERIFICAÇÃO ENTRE STRINGS
            */

            if (texto1.Equals(texto2)) 
            {
                Console.WriteLine($" [EQUALS] {texto1} = {texto2}");
            }

            if (texto1.Equals(texto3, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($" [EQUALS STRINGCOMPARISON] {texto1} = {texto3}");
            }

            if (String.Compare(texto1, texto2) == 0)
            {
                Console.WriteLine($" [COMPARE] {texto1} = {texto2}");
            }

            if (String.Compare(texto1, texto3, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
               Console.WriteLine($" [COMPARE STRINGCOMPARISON] {texto1} = {texto3}"); 
            }

            if (frase.Contains("Amor"))
            {
                Console.WriteLine($" [CONTAINS] {frase}");
            }

            if (frase.Contains("amor", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($" [CONTAINS STRINGCOMPARISON] {frase}");
            }

            if (frase.StartsWith("Buscando"))
            {
                Console.WriteLine($" [STARTSWITH] {frase}");
            }

            if (frase.StartsWith("buscando", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($" [STARTSWITH STRINGCOMPARISON] {frase}");
            }

            if (frase.EndsWith("vida"))
            {
                Console.WriteLine($" [ENDSWITH] {frase}");
            }

            if (frase.EndsWith("Vida", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($" [ENDSWITH STRINGCOMPARISON] {frase}");
            }
        }
    }
}
