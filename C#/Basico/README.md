# $$\boxed{\mathbb{BÁSICO \space DE \space CSHARP}}$$

<p align="center">
    <img src="../imagens\R (3).png" width=200>
</p>

---

## $$\sf Glossário$$

- [Hello World](HelloWorld/README.md)
- [Entrada e Saída](In_Out/README.md)
- [Matemática](Matematica/README.md)
- [If-Else](IfElse/README.md)

---

## Roadmap

```mermaid
flowchart LR
    subgraph Operadores de Comparação
        IG[igual a]
        DI[diferente de]
        MA[maior que]
        ME[menor que]
        MAI[maior ou igual a]
        MEI[menor ou igual a]
    end

    subgraph Operadores Lógicos
        E[AND]
        OU[OR]
        NÃO[NOT]
    end

    subgraph Estruturas de Controle
        I[If/Else]
        F[For - Loop padrão]
        F2[For - Loop ForEach]
        F3[For - Loop While]
        S[Switch]
    end

    subgraph Estruturas de Dados
        L[Listas]
        A[Arrays]
        D[Dicionários]
    end

    subgraph Operações de Aritmética
        Add[Adição]
        Sub[Subtração]
        M[Multiplicação]
        Div[Divisão]
        MD[Módulo]
    end

    subgraph Tipos de Dados
        Str[Strings]
        int[Inteiro]
        bool[Booleano]
        double[Ponto Fluante]
    end

    E --> I
    OU --> I
    NÃO --> I

    IG --> I
    DI --> I
    MA --> I
    ME --> I
    MAI --> I
    MEI --> I

    IG --> F
    DI --> F
    MA --> F
    ME --> F
    MAI --> F
    MEI --> F

    IG --> S
    DI --> S
    MA --> S
    ME --> S
    MAI --> S
    MEI --> S

    IG --> F2
    DI --> F2
    MA --> F2
    ME --> F2
    MAI --> F2
    MEI --> F2

    IG --> F3
    DI --> F3
    MA --> F3
    ME --> F3
    MAI --> F3
    MEI --> F3

    I --> F
    I --> F2
    I --> F3

    L --> A
    Str --> A

    Add --> Sub
    Sub --> M
    M --> Div
    Div --> MD

    F --> A
    F --> L

    F2 --> A
    F2 --> L

    F3 --> A
    F3 --> L

    style F stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style F2 stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style F3 stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style I stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style S stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style IG stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style DI stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MEI stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MAI stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style ME stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style MA stroke:magenta,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style E stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style OU stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style NÃO stroke:red,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    style MD stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Div stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style M stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Sub stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style Add stroke:blue,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
```
