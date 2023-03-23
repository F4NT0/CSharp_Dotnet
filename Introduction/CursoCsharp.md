# Curso C# com .NET

* C# = Linguagem de Programação do Windows
* .NET = Framework de desenvolvimento para criar programas

.NET disponibiliza várias bibliotecas base (BCL - BASE CLASS LIBRARY) para desenvolvimento

.NET possui (CLR - Common Language Euntime) que é uma máquina virtual que executa um programa, ele possui Garbage Collection onde os objetos não usados são deslocados da memória

.NET standard é um padrão de desenvolvimento, onde foram implementados vários tipos:

- .NET Framework: 2002 (Criado pela microsoft)
- mono: 2004 (Independente)
- Xamarin: 2011 (Independente)
- .NET Core: 2016 (Microsoft e comunidade) - Multiplataforma e é o mais novo

Dependendo do tipo de aplicação, vai ter um conjunto de bibliotecas e modelos 

<img src="images\dotnet.png">

- C# é uma linguagem pré-compilada, ou seja, ela é transformada em um código intermediário chamado **CIL**(Common Intermediate Language) que não é vinculado a uma plataforma única e depois vai para uma máquina virtual do computador específico chamado de **.NET CLR** (Common Language Runtime) específico ou do windows ou do mac ou do linux.

<img src="images\Compilação.png">

<img src="images\execução.png">

## Estruturas de Arquivos C#

- Como é Orientado a Objetos, possui Classes

```csharp
public class Teste {

}
```

- Diferente de outras linguagens, ela tem **Namespace** que é o agrupamento Lógico de classes relacionadas

<img src="images\namespace.png">

- uma estrutura de namespace no projeto:

    - nome do diretório principal
    - nome do diretório onde se encontra o arquivo

```text
Name
 |
 | - Model
       |
       | - Main.cs
```

```csharp
namespace Name.Model;
public class Main {
    // ...
}
```

- Outra coisa é algo chamado **Assembly**, que é um agrupamento físico de classes relacionadas (DLL ou EXE)

<img src="images\Assembly.png">

- Uma **Aplicação** é um conjunto de Assemblies relacionados

<img src="images\aplicação.png">

No visual studio é chamado de **Solution** uma Aplicação e **Project** um Assembly


