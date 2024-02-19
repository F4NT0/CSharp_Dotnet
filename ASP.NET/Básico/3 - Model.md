[[Página Inicial ASP_NET]]

O Model é um arquivo onde vão os valores que iremos trabalhar em uma API, são os dados requisitados para utilizar a API.

```table-of-contents
```

## Construindo um Model

### Criando o folder Model
---
O folder Model não vem por padrão em templates ASP.NET, por isso temos que construir esse folder da seguinte forma:

1) Clique com botão direito encima do projeto no Visual Studio e clique na opção **Add..**

![[ASPNET_AddFolder1.png]]
2) Depois selecione a opção **New Folder**

![[ASPNET_AddFolder2.png]]

3) Coloque o nome de **Model**
![[ASPNET_AddFolder3.png]]

### Criando um Arquivo Model
---
Podemos criar quantos Models quisermos, para isso primeiro devemos criar uma nova classe dentro do folder Model:

1) Clique com o botão direito no Folder desejado e selecione a opção **Add...**

![[ASPNET_CreateClass1.png]]
2) Depois seleciona a opção **Class...**
![[ASPNET_CreateClass2.png]]
3) Coloque o nome desejado que será o nome oficial da classe, iremos chamar a nossa classe de **Person**.
![[ASPNET_CreateClass3.png]]

### Entendendo uma Classe
---
Quando criamos uma classe por um template, ele é gerado uma classe simples como na imagem abaixo:

![[ASPNET_ClassExample.png]]

Nesse código temos o seguinte:

```csharp
namespace RESTTemplate.Model
{
    public class Person
    {
    }
}
```

$\color{yellow}{\sf namespace}$ = namespace serve para organizar um conjunto de classes pelo seu folder definido, no nosso exemplo acima a nossa classe Person faz parte do folder Model da API RESTTemplate.

$\color{yellow}{\sf public}$ = public significa que nossa classe pode ser lidar e utilizada por todo o projeto, sem ser restrito a alguma lugar.

$\color{yellow}{\sf class}$ = class mostra que esse arquivo é uma classe que podemos definir métodos e objetos internos dela

### Colocando objetos nessa classe
---
podemos colocar objetos e atributos dentro de uma classe Model, onde colocamos do seguinte exemplo:

```csharp
namespace RESTTemplate.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
    }
}
```

quando colocamos $\color{yellow}{\sf get; \space set;}$ estamos já definindo de forma limpa (clean code) os Getters e Setter do atributo, onde não precisamos criar métodos locais para cada atributo.

---
## Próximo
---
[[4 - Services]]