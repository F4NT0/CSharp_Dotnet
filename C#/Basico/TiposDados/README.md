# $$\boxed{\mathbb{TIPOS \space DE \space DADOS}}$$

<p align="center">
    <img src="../../imagens\R (3).png" width=200>
</p>

---

C# é uma linguagem super tipada, precisa dizer exatamente qual tipo de cada variável.

Com tipos de dados dizemos qual o tamanho necessário de memória necessária para uma variável

Todo tipo de dados possuem um valor minimo e máximo.

Todo tipo de dados podem ter um valor retornado.

- $\sf \color{magenta}bool$ = Guarda valores booleanos (true ou false)
- $\sf \color{magenta}int$ = Guarda valores inteiros (1, 2, 3, 543, 10000)
- $\sf \color{magenta}float/double/decimal$ = Guarda valores de pontos flutuantes (1,.5, 2.34, 33.33333)
- $\sf \color{magenta}char$ = Guarda um caractere
- $\sf \color{magenta}bye$ = Guarda 8 bit
- $\sf \color{magenta}object$ = Guarda um objeto, isso será visto mais para frente.
- $\sf \color{magenta}string$ = guarda um conjunto de caracteres, que se tornam uma palavra, separado com `“ ”`

## Tipos de dados

### Tipos de dados de referência e de valor

Os tipos de dados em C# podem ser divididos em dois tipos: tipos de valor e tipos de referência.

### Tipos de valor

Os tipos de valor, como $\sf \color{magenta}int$, $\sf \color{magenta}float$ e $\sf \color{magenta}bool$, são tipos que armazenam diretamente o valor em uma variável. Quando uma variável é definida como um tipo de valor, um espaço na memória é alocado para armazenar o valor. Os tipos de valor são armazenados na pilha.

### Tipos de referência

Os tipos de referência, como $\sf \color{magenta}string$ e $\sf \color{magenta}object$, armazenam um ponteiro para um objeto na memória. Quando uma variável é definida como um tipo de referência, um espaço na memória é alocado para armazenar o ponteiro para o objeto. O objeto real é armazenado em outro lugar na memória e pode ser compartilhado por várias variáveis. Os tipos de referência são armazenados no heap.

Os tipos de valor são geralmente mais eficientes em termos de desempenho do que os tipos de referência, pois eles não exigem alocar e desalocar memória dinamicamente. No entanto, os tipos de referência são mais flexíveis e podem ser usados para representar objetos complexos e estruturas de dados.

```mermaid
flowchart 
	subgraph vl [Tipos de valores]
		tipo(Tipo de dados) .-> vdt(Tipos de dados de valores)
		tipo .-> rdt(Tipos de dados referenciais)
		
		vdt .-> pdt1(Tipos de dados pré-definidos)
		vdt .-> udt1(Tipos de dados definido por usuário)
		
		pdt1 .-> int(Integer)
		pdt1 .-> bool(Boolean)
		
		udt1 .-> enum(Enumeration)
		udt1 .-> struct(Struct)
		
		rdt .-> pdt2(Tipos de dados pré-definidos)
		rdt .-> udt2(Tipos de dados definido por usuário)

		pdt2 .-> str(String)
		pdt2 .-> arr(Array)
		
		udt2 .-> classe(Class)
		udt2 .-> inter(Interface)
	end

	style vl fill:#000,color:#fff,stroke:#fff
	style tipo fill:#000,color:#00FFFF,stroke:#00FFFF
	style rdt fill:#000,color:#BF7FFF,stroke:#BF7FFF
	style vdt fill:#000,color:#BF7FFF,stroke:#BF7FFF
	style pdt1 fill:#000,color:#00FF00,stroke:#00FF00
	style pdt2 fill:#000,color:#00FF00,stroke:#00FF00
	style udt1 fill:#000,color:#00FF00,stroke:#00FF00
	style udt2 fill:#000,color:#00FF00,stroke:#00FF00
	style int fill:#000,color:#ff8400,stroke:#ff8400
	style bool fill:#000,color:#ff8400,stroke:#ff8400
	style enum fill:#000,color:#ff8400,stroke:#ff8400
	style struct fill:#000,color:#ff8400,stroke:#ff8400
	style str fill:#000,color:#ff8400,stroke:#ff8400
	style arr fill:#000,color:#ff8400,stroke:#ff8400
	style classe fill:#000,color:#ff8400,stroke:#ff8400
	style inter fill:#000,color:#ff8400,stroke:#ff8400
```

## Hierarquia de tipos de dados

A hierarquia de tipos de dados no C# começa com o tipo $\sf \color{magenta}object$, que é a raiz da hierarquia. Todos os outros tipos de dados são derivados desse tipo. Abaixo de $\sf \color{magenta}object$ estão os tipos de valor e os tipos de referência. Os tipos de valor, como $\sf \color{magenta}int$, $\sf \color{magenta}float$, $\sf \color{magenta}double$, etc., são armazenados diretamente na memória, enquanto os tipos de referência, como $\sf \color{magenta}string$, $\sf \color{magenta}object$, etc., são armazenados em outra parte da memória e referenciados por um ponteiro. Além disso, existem os $\sf \color{magenta}Backing Types$, que são os tipos subjacentes que suportam as propriedades de um tipo de dados. Essa hierarquia é exemplificada pelo diagrama abaixo:

```mermaid
flowchart 
	subgraph subg [Hierarquia de tipos de dados]
		obj(Object) .-> str(String)
		obj .-> array(Array)
		obj .-> exp(Exception)
		obj .-> file(File)
		obj .-> value(Tipos de valores)
		value .-> flut(Pontos Flutuantes)
		value .-> bool(Booleanos)
		value .-> inte(Inteiros)
		flut .-> double(System.Double)
		inte .-> byte(System.Byte)
		flut .-> float(System.Float)
		flut .-> decimal(System.Decimal)
		inte .-> int32(System.Int32)
		inte .-> long(System.Long)
		bool .-> boolean(System.Boolean)
	end
	style subg fill:#000,color:#fff,stroke:#fff
	style obj fill:#000,color:#00fffc,stroke:#00fffc
	style exp fill:#000,color:#FF6666,stroke:#FF6666
	style str fill:#000,color:#9393FF,stroke:#9393FF
	style array fill:#000,color:#FFA500,stroke:#FFA500
	style file fill:#000,color:#FF00FF,stroke:#FF00FF
	style value fill:#000,color:#ffde00,stroke:#ffde00
	style flut fill:#000,color:#2af104,stroke:#2af104
	style double fill:#000,color:#2af104,stroke:#2af104
	style float fill:#000,color:#2af104,stroke:#2af104
	style decimal fill:#000,color:#2af104,stroke:#2af104
	style inte fill:#000,color:#bb8cde,stroke:#bb8cde
	style byte fill:#000,color:#bb8cde,stroke:#bb8cde
	style int32 fill:#000,color:#bb8cde,stroke:#bb8cde
	style long fill:#000,color:#bb8cde,stroke:#bb8cde
	style bool fill:#000,color:#10ec75,stroke:#10ec75
	style boolean fill:#000,color:#10ec75,stroke:#10ec75

```

## Backing Types

**Backing Types** são os tipos de dados subjacentes que suportam as propriedades de um tipo de dados. Por exemplo, a propriedade $\sf \color{magenta}int$ é suportada pelo tipo subjacente $\sf \color{magenta}System.Int32$. O tipo subjacente pode ser acessado usando a palavra-chave $\sf \color{magenta}typeof$.

Tipo primitivo|Backing Type
|---|---|
int|Int32
float|Float
decimal|Decimal
bool|Boolean
byte|Byte

## Utilizando tipos de dados básicos do C#

---

### Booleanos

- para guardarmos booleanos precisamos construir uma variável do tipo `bool`
- Podemos guardar um valor ou podemos utilizar uma ******************expressão****************** para salvar esse valor, como nos exemplos abaixo

```csharp
bool value1 = true; // Salvar um tipo booleano direto na variável

bool value2 = 3 == 4; // Cria uma expresão que retorna um valor booleano 
```

### Inteiros

- Para guardarmos inteiros precisamos construir uma variável do tipo `int`
- Podemos guardar um valor ou podemos utilizar uma ******************expressão****************** para salvar esse valor, como nos exemplos abaixo

```csharp
int value1 = 3; // Salvar um valor inteiro direto na variável

int value2 = 4 + 5; // Criar uma expressão que retorna um valor inteiro
```

### Pontos Flutuantes

- Tem 3 principais tipos de pontos flutuantes: `float` , `double` , `decimal`
- A principal diferença entre eles é o tamanho máximo de digitos que podem ser usados, o `decimal`possui o maior tamanho máximo de uso
- Para guardarmos pontos flutuantes, podemos guardar um valor direto ou podemos utilizar uma ******************expressão****************** para salvar esse valor, como nos exemplos abaixos

```csharp
float value1 = 1.2; // float direto na variável
float value2 = 2/3; // expressão que retorna um float

double value3 = 1.3333; // double direto na variável
double value4 = 2/3; // expressão que retorna um double

decimal value5 = 1.3333333; // decimal direto na variável
decimal value6 = 2/3; // expressão que retorna um decimal
```

### Caracteres

- Caractere são salvos no tipo `char`
- Podemos fazer verificações com caracteres, usando métodos existentes do C#

```csharp
char myChar = 'a'; // caractere direto na varivável

bool isSpace = char.IsWhiteSpace(myChar); // verifica se é um espaço em branco
bool isDigit = char.IsDigit(myChar); // verifica se é um número
bool isPuntuation = char.IsPunctuation(myChar); // verifica se é um acento
```

## Utilizando DateTime

---

Datetime é um tipo de dado objeto para construir tipos de datas.

- Aqui alguns exemplos de uso do Datetime

```csharp
DateTime data1 = new DateTime(2023,05,04); // ano, mes, dia
DateTime hoje = DateTime.Today; // pega o dia de hoje
DateTime doisDiasDepois = data1.AddDays(2); // dois dias depois da data inicial
DayOfWeek dia = data1.DayOfWeek; // pega o dia da semana da data inicial
bool isDST = data1.IsDaylightSavingTime(); // verifica se é dia
```

- Podemos colocar a data de uma forma mais simples de leitura, utilizando `TimeSpan`
1. Vamos criar uma data e vamos imprimir a data de forma visual e o horário dela

```csharp
DateTime agora = DateTime.Now;
Console.WriteLine(agora.ToLongDateString()); // Apresenta o dia de forma visual
Console.WriteLine(agora.ToShortTimeString()); // Apresenta a hora de forma visual
```