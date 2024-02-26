[[Página Inicial ASP_NET]]

```table-of-contents
```

## Páginas anteriores
- [[1 - ASP.NET Template]]
- [[2 - ASP.NET REST]]
- [[3 - ASP.NET Model]]
- [[4 - ASP.NET Services]]
- [[5 - ASP.NET Controller Template]]
- [[6 - ASP.NET Controller]]
- [[7 - ASP.NET Run Project]]
- [[8 - Postman]]
- [[9 - ASP.NET Context]]
- [[10 - Ajustando Model]]

## Arrumando Implementations
---
Quando criamos o Implementation no tópico [[4 - ASP.NET Services#Implementando os métodos da Interface]] criamos somente um exemplo onde não precisava de banco de dados, agora iremos modificar essa classe para implementar as regras de configuração com o banco de dados.

### Invocando o Context e Criando construtor
---
Agora iremos chamar o nosso Context que criamos em [[9 - ASP.NET Context#Criando um Context para acesso ao banco de dados]] sendo privado e com o nome começando com underline `_`

```csharp
private SQLiteContext _context;
```

Depois criamos o construtor do nosso __PersonServiceImplementation__ chamando o nosso Context nele:

```csharp
public PersonServiceImplementation(SQLiteContext context)
{
	_context = context;
}
```

### Atualizando o método FindAll
---
Agora que temos o Context conectado, alteramos o nosso método de busca de todas as pessoas utilizando o método do Context chamado __ToList()__ onde fica o nosso método assim:

```csharp
public List<Person> FindAll()
{
   return _context.Persons.ToList();
}
```

Vamos criar um exemplo pelo nosso SQLite Studio para termos um dado para verificar, como no INSERT abaixo:

```sql
INSERT INTO persons(first_name,last_name,address,gender)
VALUES ('Gabriel','Fanto','Porto Alegre','Male');
```

Então clicamos em _Run_ no SQLiteStudio e vai criar o dado em nosso banco, depois disso podemos rodar a seguinte Query para vermos os dados:

```sql
SELECT *
FROM persons;
```

Pelos SQLite Studio vai nos mostrar assim:

![[SQLiteINSERTSELECT.png]]

Após criarmos, podemos rodar o nosso projeto no Visual Studio e abrir a página web onde depois que fizemos a alteração do método __FindAll()__ deve aparecer esse registro, se aparecer a nossa conexão com o banco de dados foi um sucesso!

![[ASPNET_FindAllSQLiteConnection.png]]

