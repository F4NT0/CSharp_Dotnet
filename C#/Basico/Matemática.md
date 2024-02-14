# $$\boxed{\sf MATEMÁTICA}$$

<p align="center">
    <img src="../../imagens/R (3).png" width=200>
</p>

## $$\sf Glossário$$

- [Operadores Aritméticos](#operadores-aritméticos)
- [Incremento e Decremento](#incremento-e-decremento)
- [Tipos de valores](#tipos-de-valores)
- [Utilizando Cast](#utilizando-cast)
- [Classe Math](#classe-math)
    - [Arredondamento](#arredondamento)
    - [Maior e Menor número](#maior-e-menor-número)
    - [Potência](#potência)
    - [Raiz Quadrada](#raiz-quadrada)
    - [Logaritmo](#logaritmo)
    - [Exponencial](#exponencial)
- [Valores Randomicos](#valores-randomicos)
- [Fórmulas avançadas](#fórmulas-avançadas)


---

## Operadores Aritméticos

Nome|Simbolo|Uso
|---|---|---|
Soma|$\sf \color{lightgreen}+$|`x + y`
Subtração|$\sf \color{yellow}-$|`x - y`
Multiplicação|$\sf \color{lightblue}*$|`x * y`
Divisão|$\sf \color{red}/$|`x / y`
Resto da divisão|%|`x % y`

* Exemplo de resto da divisão

```csharp
// Resto da divisão é o que sobra de uma divisão
int x = 6;
int y = 3;
int z = 8;
int resto = x % y; // 6 % 3 = 0
int resto2 = z % y; // 8 % 3 = 2
```

---

## Incremento e Decremento

Nome|O que faz| Simbolo
|---|---|---|
Incremento|Soma mais um em uma variável|$\sf \color{lightgreen}++$
Decremento|Subtrai menos um em uma variável|$\sf \color{yellow}--$

* Incrementa antes

```csharp
int x = 5;
Console.WriteLine(++x); // 6
```

* Incrementa depois

```csharp
int x = 5;
Console.WriteLine(x++); // 5
Console.WriteLine(x); // 6
```

* Decrementa antes

```csharp
int x = 5;
Console.WriteLine(--x); // 4
```

* Decrementa depois

```csharp
int x = 5;
Console.WriteLine(x--); // 5
Console.WriteLine(x); // 4
```

---

## Tipos de valores

Estes são os tipos de valores numéricos mais utilizados e suas informações:

Nome|Tipo|Valor Mínimo|Valor Máximo|Número de digitos
|---|---|---|---|---|
int|Inteiro|-2147483648|2147483647| 10
decimal|Decimal|-79228162514264337593543950335|79228162514264337593543950335|29
sbyte|Sbyte|-128|127|3
long|Long|-9223372036854775808|9223372036854775807|19
double|Double|-1,7976931348623157E+308|1,7976931348623157E+308|17

---

## Utilizando Cast

Cast na programação serve para alterar o tipo de um valor, onde podemos alterar os valores dos tipos numéricos para o que queremos.

A estrutura no C# fica assim:

```csharp
double teste = 3.25;
int troca = (int)teste;
Console.WriteLine(troca); // 3
```

---

## Classe Math

Classe $\sf \color{orange}Math$ é uma classe pré-existente do C# que serve para fazermos cálculos matemáticos mais avançados, onde possui métodos que fazem fórmulas matemáticas mais usadas.

---

### Arredondamento

Para arredondarmos um valor para o maior valor inteiro próximo de um resultado, podemos usar o método $\sf \color{lightgreen} Math.Ceiling$.

Para arredondarmos um valor para o menor valor inteiro de um resultado, podemos usar o método $\sf \color{lightgreen} Math.Floor$.

```csharp
double dividendo = 8;
double divisor = 3;
Console.WriteLine($"Dividendo: {dividendo}, Divisor: {divisor}, {dividendo}/{divisor} = {dividendo/divisor}");

double arredondamentoMaior = Math.Ceiling(dividendo/divisor);
double arredondamentoMenor = Math.Floor(dividendo/divisor);
Console.WriteLine($"Arredondamento para mais: {arredondamentoMaior}");
Console.WriteLine($"Arredondamento para menos: {arredondamentoMenor}");
/* 
Saída:
Dividendo: 8, Divisor: 3, 8/3 = 2,6666666666666665
Arredondamento para mais: 3
Arredondamento para menos: 2
*/
```

Para arredondar um número para o inteiro mais próximo e ainda definir o número de casas decimais, usamos o $\sf \color{lightgreen} Math.Round$.

```csharp
double dividendo = 8;
double divisor = 3;
Console.WriteLine($"Dividendo: {dividendo}, Divisor: {divisor}, {dividendo}/{divisor} = {dividendo/divisor}");

double arredondamentoControle = Math.Round(dividendo/divisor);
Console.WriteLine($"Arredondamento usando Round: {arredondamentoControle}");
/*
 Saída: 
 Dividendo: 8, Divisor: 3, 8/3 = 2,6666666666666665
 Arredondamento usando Round: 3
 */
```

---

### Maior e Menor número

Podemos usar a classe Math para pegarmos o maior e o menor número entre dois valores, utilizando os métodos $\sf \color{lightgreen} Math.Max$ e $\sf \color{lightgreen} Math.Min$.

```csharp
double dividendo = 8;
double divisor = 3;

double maximo = Math.Max(dividendo,divisor);
double minimo = Math.Min(dividendo, divisor);

Console.WriteLine($"Máximo valor entre {dividendo} e {divisor}: {maximo}");
Console.WriteLine($"Mínimo valor entre {dividendo} e {divisor}: {minimo}");
/*
 Saída
 Máximo valor entre 8 e 3: 8
 Mínimo valor entre 8 e 3: 3
*/
```

---

### Potência

Uma potência é uma operação matemática que envolve a multiplicação repetida de um número por ele mesmo chamado de **base** por um número específico de vezes definida pelo **expoente**.

$$2^3 = 2 \times 2 \times 2$$

* O número 2 é a $\sf \color{magenta} Base$.
* O número 3 é o $\sf \color{magenta} Expoente$.

Em C#, utilizamos a classe $\sf \color{orange} Math$ com o método $\sf \color{lightgreen} Pow(b,e)$ para calcular a potência.

```csharp
int basePot = 2;
int expoente = 3;
int potencia = (int)Math.Pow(basePot, expoente);
double potencia2 = Math.Pow(basePot, expoente);
Console.WriteLine($" Base: {basePot}, Expoente: {expoente}");
Console.WriteLine($" Potencia normal: {potencia2}");
Console.WriteLine($" Potencia usando cast de int: {potencia}");
/*
Saída:
Base: 2, Expoente: 3
potência normal: 8,
potência usando cast de int: 8
*/
```

---

### Raiz Quadrada

Podemos fazer o cálculo da raiz quadrada utilizando o método $\sf \color{lightgreen} Sqrt(value)$ da classe $\sf \color{orange} Math$.

$$\sqrt{144} = 12$$

Para fazermos esse cálculo no C# construimos o seguinte código:

```csharp
double square = Math.Sqrt(144);
Console.WriteLine("Valor original: " + square); // 12
```

---

### Logaritmo

Logaritmo é uma função matemática que relaciona dois valores: a base do logaritmo e um número real positivo.

Um logaritmo é o expoente a que a base deve ser elevada para produzir um determinado número.

Por exemplo, se a base do logaritmo é 10 e o número é 100, então o logaritmo de 100 na base 10 é 2, porque 10 elevado a 2 é igual a 100.

$$\log_{10}(100) = 2$$

No exemplo acima o valor 10 é considerado a $\sf \color{lightblue}base$ do logaritmo.

O valor 100 é considerado o $\sf \color{lightblue}argumento$ do logaritmo. 

Do exemplo mostrado acima, podemos escrever a mesma fórmula no C# usando o método $\sf \color{lightgreen} Log(value1, value2)$ da classe $\sf \color{orange} Math$

```csharp
double baseLog = 10;
double argumento = 100;
double valor = Math.Log(100,10);
Console.WriteLine($"Log base {base} argumento {argumento} = {valor}");
// Saída: Log base 10 argumento 100 = 2
```

---

### Exponencial

A função exponencial é uma função matemática que envolve uma base elevada a uma potência. Em outras palavras, é uma função que relaciona um número real positivo, a base, com um expoente que pode ser qualquer número real.

Por exemplo, a função exponencial com base 2 pode ser escrita como $f(x) = 2^x$, onde $x$ é o expoente. Isso significa que para qualquer valor de $x$, a função retorna o resultado da base 2 elevada a esse expoente.

A função exponencial tem algumas propriedades interessantes, como:

- Quando a base é um número maior que 1, a função cresce exponencialmente à medida que o expoente aumenta.
- Quando a base é um número entre 0 e 1, a função decresce exponencialmente à medida que o expoente aumenta.
- Quando o expoente é igual a 0, o resultado da função é sempre 1.
- Quando o expoente é um número negativo, o resultado da função é um número entre 0 e 1.

A função exponencial é amplamente utilizada em muitas áreas da matemática, ciência, engenharia e tecnologia, e é usada para modelar muitos fenômenos naturais e processos dinâmicos.

$$f(x) = e^{2} = 7,389$$

No C# podemos usar o método $\sf \color{lightgreen}Exp(value)$ da classe $\sf \color{orange} Math$ para calcularmos o exponencial.

```csharp
double exponencial = Math.Exp(2.0); // e^2
Console.WriteLine("Exponencial: " + exponencial);
Console.WriteLine("Arredondando Exponencial: " + exponencial.ToString("0.###"));
/*
    Saída:
    Exponencial: 7,38905609893065
    Arredondando Exponencial: 7,389
*/
```

---

## Valores Randomicos

Podemos criar valores randomicos no C# utilizando a classe $\sf \color{orange} Random$.

Esta classe diferente da classe Math deve ser inicializada quando queremos usar, como abaixo:

```csharp
Random random = new Random();
```

Se quisermos pegar um valor randomico de 0 á 99, devemos utilizar o método $\sf \color{lightgreen}Next(value)$ colocando o value como 100, onde vai ser procurado um valor de 0 á 99.

```csharp
Random random = new Random();
int numeroRandom = random.Next(100);
Console.WriteLine(numeroRandom); // pode ser entre 0 á 99
```

Se quisermos pegar valores de ponto flutuante, podemos usar o método $\sf \color{lightgreen}NextDouble(value)$, onde se não colocarmos um valor específico, ele vai tentar pegar valores entre 0 e 1.

```csharp
Random random = new Random();
double randomDouble = random.NextDouble();
Console.WriteLine(randomDouble);// pode ser entre 0 á 1
```

Se quisermos pegar valores booleanos para verificar, podemos utilizar o método $\sf \color{lightgreen}Next(value)$ onde colocamos o valor 2, dai o método vai verificar entre o valor 0 ou 1 e com isso podemos fazer validações lógicas.

```csharp
Random random = new Random();
bool randomBoolean = random.Next(2) == 0;
Console.WriteLine(randomBoolean); // True ou False
```

---

## Fórmulas avançadas

Agora com todo esse conhecimento podemos implementar fórmulas avançadas de diversos tipos, como a fórmula de Bhaskara:

$$x = \frac{-b \pm \sqrt{b^2 - 4ac}}{2a}$$

Onde $a$, $b$ e $c$ são os coeficientes de uma equação quadrática na forma $ax^2 + bx + c = 0$ e $x$ são as soluções da equação. A fórmula de Bhaskara é usada para calcular as soluções da equação quadrática.

Com essa fórmula matemática podemos resolver matemáticamente a seguinte equação quadrática:

$$x^2 - 5x + 6 = 0$$

**Passo 1:** Identifique os valores de $a$, $b$ e $c$ na equação.

Neste caso, $a = 1$, $b = -5$ e $c = 6$.

**Passo 2:** Substitua os valores de $a$, $b$ e $c$ na fórmula de Bhaskara.

$$x = \frac{-(-5) \pm \sqrt{(-5)^2 - 4(1)(6)}}{2(1)}$$

**Passo 3:** Simplifique a expressão.

$$x = \frac{5 \pm \sqrt{25 - 24}}{2}$$

$$x = \frac{5 \pm 1}{2}$$

**Passo 4:** Resolva para as soluções.

$$x_1 = \frac{5 + 1}{2} = 3$$

$$x_2 = \frac{5 - 1}{2} = 2$$

Portanto, as soluções da equação quadrática $x^2 - 5x + 6 = 0$ são $x_1 = 3$ e $x_2 = 2$.

Agora podemos construir esse cálculo e essa fórmula em C# usando todo o conhecimento adquirido até o momento:

```csharp
double a = 1;
double b = -5;
double c = 6;

double delta = Math.Pow(b, 2) - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("As soluções da equação são:");
Console.WriteLine("x1 = " + x1);
Console.WriteLine("x2 = " + x2);

/*
    Saída:
    As soluções da equação são:
    x1 = 3
    x2 = 2
*/
```





