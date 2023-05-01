# $$\boxed{\sf Matemática}$$

<p align="center">
    <img src="../../imagens\R (3).png" width=200>
</p>

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