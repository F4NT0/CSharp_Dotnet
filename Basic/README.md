# Introdução a linguagem C# (C Sharp)

---



---

## Entendo mensagem de erros

Se você receber a seguinte mensagem de erro:

```shell
(1,1): error CS0103: The name 'console' does not exist in the current context
```

A parte `(1,1)` significa que a linha 1 e a coluna 1 ocorreu o erro.

Erros iniciais que podem ocorrer:

- Inserir letras minúsculas em vez de colocar C em maiúsculas em Console ou as letras W ou L em WriteLine
- Inserir uma vírgula em vez de um ponto entre Console e WriteLine
- Esquecer de usar aspas duplas ou colocar a frase Hello World! entre aspas simples
- Esquecer de usar o ponto e vírgula no final do comando

---

## Códigos iniciais

- Para mandar um Hello World:

```csharp
Console.WriteLine("Hello World"); // coloca o texto e da uma nova linha
Console.Write("Hello World"); // coloca o texto tudo na mesma linha
```

---

## Tipos de pontos flutuantes

Float Type|Precision
|---|---|
float    |     ~6-9 digits
double   |     ~15-17 digits
decimal  |      28-29 digits

```csharp
Console.WriteLine(123); // Integer
Console.WriteLine(0.25F); // Float
Console.WriteLine(2.625); // Double
Console.WriteLine(12.39816m); // Decimal
```

---

## Booleanos

Booleanos funciona como qualquer outra linguagem

```csharp
Console.WriteLine(true);
Console.WriteLine(false);
// Saída: True ou False
```

---

## Variáveis

```csharp
string filename;
filename = "Test.txt";

char userOption;
userOption = 'b';

int gameScore;
gameScore = 123;

double number;
number = 2.3;

decimal particlesPerMillion;
particlesPerMillion = 12.123m;

bool processedCustomer;
processedCustomer = true;

Console.WriteLine(filename);
Console.WriteLine(userOption);
Console.WriteLine(gameScore);
Console.WriteLine(number);
Console.WriteLine(particlesPerMillion);
Console.WriteLine(processedCustomer);
```

---

## Chamando variáveis na saída

```csharp
string name = "Bob";
int number = 3;
double outhernumber = 34.4;

Console.WriteLine("Hello, " + name + "! You have " + number + " in your inbox. The temperature is " + outhernumber + " celsius.");
// Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.
```

---

## Cálculos com variáveis

```csharp
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
// 19
```

- **Sem parenteses no cálculo faz com que concatene o resultado**

```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// Bob sold 77 widgets.
```
- **Com parenteses**

```csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// OuBob sold 14 widgets.
```

- **Calculando em C#**

```csharp
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum); // 12
Console.WriteLine("Difference: " + difference); // 2 
Console.WriteLine("Product: " + product); // 35
Console.WriteLine("Quotient: " + quotient); // 1
```

- **Para enviar o resultado de um cálculo dentro de uma String, deve ser começado com o `$` e a variável deve ser chamada usado o `{}`**

```csharp
decimal decimalQuotient = 2 * 5;
Console.WriteLine($"2 * 5: {decimalQuotient}");
// 2 * 5: 10
```

```csharp
Console.WriteLine($"200 Mod 5 : {200 % 5}"); // 200 Mod 5 : 0
Console.WriteLine($"7 Mod 5 : {7 % 5}"); // 7 Mod 5 : 2
```

- **Casting de dados**

```csharp
int first = 7;
int second = 5;
decimal value = (decimal)first / (decimal)second;
Console.WriteLine(value); // 1.4
```

- **Ordem de Operadores**

1. Feito primeiro os parênteses `()`
2. Expoentes
3. Multiplicação e Divisão (Esquerda para Direita)
4. Adição e Subtração (Esquerda para Direita)

- **Incremento e Decremento**

```csharp
int value = 1;

value = value + 1; // 2
value += 1; // 3
value++; // 4

value = value - 1; // 3 
value -= 1; // 2
value--; // 1
```

---

## Mexendo com Strings

- `\n` faz uma nova linha
- `\t` faz um tab no texto

```csharp
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld2!");
// Hello
// World!
// Hello   World2!
```

- adicionar uma String dentro da String

```csharp
// ERRADO
Console.WriteLine("Hello"world"!");

// CERTO
Console.WriteLine("Hello\"world\"!");
```

- Adicionar `\` em uma String

```csharp
// ERRADO
Console.WriteLine("c:\source\repos");

// CERTO
Console.WriteLine("c:\\source\\repos");
```

- Usando Unicode na String

```csharp
Console.Write("\u2C10" + "\u2C0B" + "\u2C10" + "\u2C00");
// ⰐⰋⰐⰀ
```

- Usando interpolação de String com String Literal

```csharp
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
// Update to Windows 11
```

- Juntando literal verboso com interpolação de String

```csharp
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
// C:\Output\First-Project\Data
```
