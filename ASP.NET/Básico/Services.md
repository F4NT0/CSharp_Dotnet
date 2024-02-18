Em uma API REST no C#, os “Services” são componentes que encapsulam a lógica de negócios e as operações que podem ser reutilizadas. Eles são responsáveis por realizar tarefas específicas e complexas, como interagir com um banco de dados ou processar dados.

Os Services são usados para manter os [[Controller]] enxutos e o código organizado. Em vez de colocar toda a lógica de negócios em um [[Controller]], você pode criar um Service para lidar com essa lógica e, em seguida, injetar esse serviço no controlador. Isso torna o código mais fácil de manter e testar.

---

```table-of-contents
```

## Criando uma Service

### Criando um folder Services
---
O folder Services não vem como padrão no ASP.NET, por isso devemos criar um novo folder e chamar ele de Services, para isso clicamos com o botão direito no nome do projeto, clicamos em **Add..** e depois **New Folder...**, após isso definimos o nome como **Services**.

![[ASPNET_CreateFolderServices.png]]

### Criando uma interface
---
Uma interface em C# é um tipo que define um conjunto de métodos e propriedades que uma classe ou struct deve implementar. Ela define um contrato que a classe ou struct deve seguir.

Aqui estão alguns pontos importantes sobre as interfaces em C#:

- Uma interface pode conter declarações (assinaturas sem nenhuma implementação) dos seguintes membros: Métodos, Propriedades, Indexadores e Eventos.
- As interfaces não podem declarar dados de instância, como campos, propriedades implementadas automaticamente ou eventos semelhantes a propriedades.
- A partir do C# 11, uma interface pode declarar membros `static abstract` e `static virtual` para todos os tipos de membro, exceto campos.
- Uma interface não pode conter campos de instância, construtores de instância ou finalizadores.
- Os membros da interface são públicos por padrão.

Para criar uma interface é bem simples, clicamos com o botão direito no folder que queremos criar a interface e selecionamos **Add...** depois **Class...**

![[ASPNET_CreateInterface1.png]]
Em **Class...** selecionamos a opção **Interface** e colocamos o nome do nosso Model desejado começando com um I para dizer que é uma Interface e depois escrito Service para sabermos que é um Service da API, como no exemplo abaixo:

| Nome do Model | Nome do Service |
| --- | --- |
| Person | IPersonService |
Isso é um padrão para qualquer Service no C#.

![[ASPNET_CreateInterface2.png]]

Quando criamos uma Interface, ele tem por padrão o seguinte código:

```csharp
namespace RESTTemplate.Services
{
    public interface IPersonService
    {
    }
}
```

$\color{yellow}{\sf namespace}$ = namespace serve para organizar um conjunto de classes pelo seu folder definido, no nosso exemplo acima a nossa classe IPersonService faz parte do folder Services da API RESTTemplate.

$\color{yellow}{\sf public}$ = public significa que nossa classe pode ser lidar e utilizada por todo o projeto, sem ser restrito a alguma lugar.

$\color{yellow}{\sf interface}$ = interface mostra que o nosso arquivo é uma interface do C# que podemos escrever os métodos que iremos usar em Controllers. 

### Definindo métodos na Interface
---
Agora iremos construir a estrutura base dos métodos que iremos utilizar em nossos Controllers, utilizando o sistema do CRUD explicado em [[Básico de REST]] onde temos os seguintes tipos:

$\color{yellow}{\sf Create}$ = utilizamos a requisição HTTP $\color{orange}{\sf POST}$ para criar um objeto no banco de dados, mas na nossa Interface usamos o método $\color{lightblue}{\sf Create(Object \space object)}$ para criarmos um objeto novo no banco de dados.
$\color{yellow}{\sf Read}$ = utilizamos a requisição HTTP $\color{cyan}{\sf GET}$ para buscar um objeto no banco de dados, mas na nossa Interface usamos o método $\color{lightblue}{\sf FindById(long \space id)}$ para procurar por um objeto específico pelo seu ID ou  $\color{lightblue}{\sf FindAll()}$ para procurar por todos os objetos existentes no banco de dados.
$\color{yellow}{\sf Update}$ = utilizamos a requisição HTTP $\color{lightgreen}{\sf PUT}$ para editar um objeto no banco de dados, mas na nossa Interface usamos o método $\color{lightblue}{\sf Update(Object \space object)}$ para atualizarmos um objeto já existente no banco de dados.
$\color{yellow}{\sf Delete}$ = utilizamos a requisição HTTP $\color{red}{\sf DELETE}$ para criar um objeto no banco de dados, mas na nossa Interface usamos o método $\color{lightblue}{\sf Create(Object object)}$ 


