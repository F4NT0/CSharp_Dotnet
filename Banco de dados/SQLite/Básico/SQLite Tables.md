[[Página Inicial do SQLite]]

## Conteúdos anteriores
---
- [[Instalando SQLite e SQLite Studio]]
- [[SQLite Database]]
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
Agora irei explicar o que cada parte da tabela significa

| Nome          | Descrição                                                      |
| ------------- | -------------------------------------------------------------- |
| CREATE TABLE  | comando de SQL para criar uma nova tabela                      |
| IF NOT EXISTS | Usado para verificar se já não existe uma tabela com esse nome |
| schema_name   | É o nome d                                                     |
