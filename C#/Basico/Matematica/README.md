# $$\boxed{\sf Matemática}$$

<p align="center">
    <img src="../../imagens\R (3).png" width=200>
</p>

## $$\sf Glossário$$

- [Operadores Aritméticos](#operadores-aritméticos)
- [Incremento e Decremento](#incremento-e-decremento)
- [Tipos de valores](#tipos-de-valores)
- [Classe Math](#classe-math)
    - [Arredondamento](#arredondamento)
    - [Maior e Menor número](#maior-e-menor-número)
    - [Potência](#potência)
    - [Raiz Quadrada](#raiz-quadrada)
    - [Logaritmo](#logaritmo)
    - [Exponencial](#exponencial)


---

## Operadores Aritméticos

Nome|Simbolo|Uso
|---|---|---|
Soma|$\sf \color{lightgreen}+$|`x + y`
Subtração|$\sf \color{yellow}-$|`x - y`
Multiplicação|$\sf \color{lightblue}*$|`x * y`
Divisão|$\sf \color{red}/$|`x / y`
Resto da divisão|$\sf \color{magenta}\%$|`x % y`

* Exemplo de resto da divisão

```csharp
// Resto da divisão é o que sobra de uma divisão
int x = 6;
int y = 3;
int z = 8;
int resto = x % y; // 6 % 3 = 0
int resto2 = z % y; // 8 % 3 = 2
```

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

## Tipos de valores

Estes são os tipos de valores numéricos mais utilizados e suas informações:

Nome|Tipo|Valor Mínimo|Valor Máximo|Número de digitos
|---|---|---|---|---|
int|Inteiro|-2147483648|2147483647| 10
decimal|Decimal|-79228162514264337593543950335|79228162514264337593543950335|29
sbyte|Sbyte|-128|127|3
long|Long|-9223372036854775808|9223372036854775807|19
double|Double|-1,7976931348623157E+308|1,7976931348623157E+308|17

## Classe Math

Classe $\sf \color{orange}Math$ é uma classe pré-existente do C# que serve para fazermos cálculos matemáticos mais avançados, onde possui métodos que fazem fórmulas matemáticas mais usadas.

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
Console.WriteLine($"Potência \n\n Base: {basePot} \n Expoente: {expoente} \n potência normal: {potencia2}, \n potência usando cast de Inteiro: {potencia}");
/*
Saída:
Potência 

 Base: 2
 Expoente: 3
 potência normal: 8,
 potência usando cast de Inteiro: 8
*/
```

### Raiz Quadrada

### Logaritmo

### Exponencial
