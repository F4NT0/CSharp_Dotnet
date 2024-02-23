[[Página Inicial do SQLite]]

## Conteúdos anteriores
---
- [[1- Instalando SQLite e SQLite Studio]]
- [[3 - SQLite Database]]
---
```table-of-contents
```

## Criando tabelas no SQLite
---
Agora que temos nosso banco de dados vazio do __resttemplate__ temos que criar uma tabela com os dados que queremos colocar, vou usar o exemplo de persons da nossa API sendo elaborada.

### Constraints
---
SQLite constraints serve para especificar regras para os dados de uma tabela.
Tipos de constraints mais utilizadas em dados.

| Nome        | Descrição                                                                     |
| ----------- | ----------------------------------------------------------------------------- |
| NOT NULL    | Garante que a coluna não pode haver dados nulos.                              |
| UNIQUE      | Garante que cada dado deve ser único sem repetições.                          |
| PRIMARY KEY | Avisa que o seguinte dado é o ID ou o dado que toda a tabela está organizada. |
| FOREIGN KEY | Avisa que o seguinte dado é a PRIMARY KEY de outra tabela que está conectado. |
| CHECK       | Garante que todos os valores da coluna satisfazem uma condição específica.    |
| DEFAULT     | Define um valor específico caso não seja adicionado um valor na tabela.       |
### Sintaxe de uma tabela
---
A sintaxe de uma tabela em SQL é bem simples, criamos uma tabela com o seguinte código:
```sql
CREATE TABLE [IF NOT EXISTS] [schema_name].table_name (
	coluna_1 data_type PRIMARY KEY,
	coluna_2 data_type NOT NULL,
	coluna_3 data_type DEFAULT 0,
	table_constraint
)[WITHOUT ROWID];
```
Agora irei explicar o que cada parte da tabela significa.

| Nome             | Descrição                                                      |
| ---------------- | -------------------------------------------------------------- |
| CREATE TABLE     | comando de SQL para criar uma nova tabela                      |
| IF NOT EXISTS    | Usado para verificar se já não existe uma tabela com esse nome |
| schema_name      | É o nome do schema, que é um conjunto de tabelas               |
| table_name       | É o nome da tabela que queremos criar                          |
| coluna_1         | É um dado dessa tabela, que irá ficar em uma coluna            |
| data_type        | É o tipo de dado que vem da nossa API                          |
| table_constraint | É algum tipo de constraints que somente a tabela tem.          |

### Tipos de dados
---
Podemos usar os seguinte tipos de dados para dizer que informação é esperada para cada coluna

| Nome    | Descrição                  | Exemplo     |
| ------- | -------------------------- | ----------- |
| INTEGER | tipo inteiro até 8 bytes   | age INTEGER |
| REAL    | tipo flutuante até 8 bytes | salary REAL |
| TEXT    | tipo texto                 | name TEXT   |
| BLOB    | tipo de dado de entrada    | image BLOB  |
| NULL    | tipo de valor nulo         |             |
### Exemplo de tabela
---
agora que entendemos o sintaxe, vamos criar a tabela do nosso objeto Person que estamos criando no [[9 - ASP.NET Database]] na nossa API REST.

No exemplo da API temos os seguintes dados:
```csharp
namespace RESTTemplate.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
```
Nesse código em C# temos os dados do modelo do objeto Person definido em [[3 - ASP.NET Model]] na API REST de exemplo.
Dessa forma podemos transformar esses dados para uma tabela com os seguintes tipos:

| em C#  | em SQL  |
| ------ | ------- |
| long   | INTEGER |
| string | TEXT    |
Sabemos também que o Id deve ser único e que todo o objeto Person é organizado e selecionado por ele, então ele será nossa __PRIMARY KEY__.
Sabemos que `FirstName`e `LastName` são dados obrigatórios, por isso devemos dizer que eles são __NOT NULL__ na nossa tabela.

Com esses dados nossa tabela em SQL fica da seguinte forma:
```sql
CREATE TABLE IF NOT EXISTS persons (
	person_id INTEGER PRIMARY KEY,
	first_name TEXT NOT NULL,
	last_name TEXT NOT NULL,
	address TEXT,
	gender TEXT
);
```

Todos os nomes das colunas não podem ter nomes maiúsculos e as informações são separadas com underline `_` 

### Criando a tabela pelo SQLite Studio
---
Para criarmos uma tabela no SQLite Studio primeiro precisamos abrir um editor, para escrevermos nossa query, para isso podemos usar o comando do teclado __Alt + E__ para abrir um editor ou clicar no símbolo do editor no topo do SQLite Studio.
![[SQLiteStudioOpenSQLEditor.gif]]
Agora colamos nosso código em SQL e criamos a tabela.
![[SQLiteStudioCreateTable.gif]]
Agora vamos ver passo a passo de como fazer.
1) Cole no editor de Query a tabela que você deseja criar
![[SQLiteStudioAddTableCode.png]]
2) Como pode ver não tem nenhuma tabela criada, com isso rode o comando __run__ apresentado como uma seta azul, mas antes verifique se você está no banco de dados correto que você deseja.
![[SQLiteStudioRunSQLTable.png]]
3) Com isso ele vai criar a tabela e vai mostrar na lista de tabelas ao lado, onde podemos abrir a tabela clicando no nome dela duas vezes.
![[SQLStudioOpenTable.png]]

