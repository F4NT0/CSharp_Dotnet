## Objetos no C#

Classes e objetos
As classes são os tipos do C# mais fundamentais. Uma classe é uma estrutura de dados que combina ações (métodos e outros membros da função) e estado (campos) em uma única unidade. Uma classe fornece uma definição das instâncias da classe, também conhecidas como objetos. As classes dão suporte à herança e polimorfismo, mecanismos nos quais classes derivadas podem estender e especializar classes base.

Novas classes são criadas usando declarações de classe. Uma declaração de classe começa com um cabeçalho. O cabeçalho especifica:

- Os atributos e modificadores da classe.
- O nome da classe.
- A classe base (ao herdar de uma classe base).
- As interfaces implementadas pela classe.
- O cabeçalho é seguido pelo corpo da classe, que consiste em uma lista de declarações de membro escrita entre os delimitadores { e }.

```csharp
public class Point
{
    public int X { get; }
    public int Y { get; }
    
    public Point(int x, int y) => (X, Y) = (x, y);
}
```