# $$\boxed{\mathbb{BÁSICO \space DE \space CSHARP}}$$

<p align="center">
    <img src="../imagens\R (3).png" width=200>
</p>

---

## $$\sf Glossário$$

- [Hello World](HelloWorld/README.md)
- [Tipos de dados](TiposDados/README.md)
- [Entrada e Saída](In_Out/README.md)
- [Matemática](Matematica/README.md)
- [If-Else](IfElse/README.md)

---

## Roadmap

```mermaid
flowchart TD
    subgraph text [Roadmap do Básico]
        subgraph comp [Operadores de Comparação]
            IG[igual a]
            DI[diferente de]
            MA[maior que]
            ME[menor que]
            MAI[maior ou igual a]
            MEI[menor ou igual a]
        end

        subgraph logic [Operadores Lógicos]
            E[AND]
            OU[OR]
            NÃO[NOT]
        end

        subgraph cont [Estruturas de Controle]
            I[If/Else]
            F[For]
            F2[ForEach]
            F3[While]
            F4[Do-While]
            Lamb[Lambda]
            S[Switch]
        end

        subgraph dsa [Estruturas de Dados]
            L[Listas]
            A[Arrays]
            Stack[Filas]
            Graph[Grafos]
            Three[Árvores]
            D[Dicionários]
        end

        subgraph arit [Matemática]
            Add[Adição]
            Sub[Subtração]
            M[Multiplicação]
            Div[Divisão]
            MD[Módulo]
            rand[Random]
            math[Classe Math]
            cast[Cast]
        end

        subgraph types [Tipos de Dados]
            Str[Strings]
            int[Inteiro]
            bool[Booleano]
            double[Ponto Fluante]
            sbyte[sbyte]
        end
    end
    
    types --> arit
    types --> logic
    arit --> cont
    logic --> cont
    comp --> cont
    comp --> logic
    cont --> dsa
    
    style types fill: #000,color:#fff
    style arit fill: #000,color:#fff
    style logic fill: #000,color:#fff
    style cont fill: #000,color:#fff
    style comp fill: #000,color:#fff
    style dsa fill: #000,color:#fff
    style text fill: #000,stroke:#fff
    

    style F fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style F2 fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style F3 fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style I fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style S fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Lamb fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style F4 fill: #000,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style IG fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style DI fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MEI fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MAI fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style ME fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MA fill: #000,stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style E fill: #000,stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style OU fill: #000,stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style NÃO fill: #000,stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style MD fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Div fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style M fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Sub fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Add fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style cast fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style math fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style rand fill: #000,stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style sbyte fill: #000,stroke:yellow,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style double fill: #000,stroke:yellow,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style bool fill: #000,stroke:yellow,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style int fill: #000,stroke:yellow,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Str fill: #000,stroke:yellow,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style D fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Three fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Graph fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Stack fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style A fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style L fill: #000,stroke:lightgreen,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    
```
