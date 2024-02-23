[[Página Inicial do SQLite]]

```table-of-contents
```

## Comandos
---
Quando colocamos o comando **.help** no console conectados ao SQLite ele nos mostra os tipos de comandos que podemos usar:

| Comando | Descrição |
| ---- | ---- |
| `.databases` | Lista todos os bancos de dados. |
| `.tables` | Lista todas as tabelas no banco de dados atual. |
| `.schema` | Mostra o esquema de criação de todas as tabelas. |
| `.header on` | Ativa a exibição de nomes de colunas no resultado da consulta. |
| `.mode column` | Configura o formato de saída para o modo coluna. |
| `.exit` | Sai do SQLite. |
| `SELECT * FROM nome_tabela;` | Seleciona todos os dados de uma tabela. |
| `INSERT INTO nome_tabela (coluna1, coluna2) VALUES (valor1, valor2);` | Insere dados em uma tabela. |
| `UPDATE nome_tabela SET coluna1 = valor1 WHERE condição;` | Atualiza dados em uma tabela. |
| `DELETE FROM nome_tabela WHERE condição;` | Deleta dados de uma tabela. |

### Acessando o SQLite pelo PowerShell
---
Acessar pelo prompt de comando somente acessamos a rota `C://sqlite` e rodamos o comando __sqlite3__ diretamente:
![[SQLiteConsolePrompt.png]]
Para acessar pelo Powershell é um pouco diferente, temos que colocar `.\` antes do comando:
![[SQLitePowershell.png]]


### Criando um database
---
- Podemos criar um diretório chamado **db** dentro do diretório **C://sqlite** para colocarmos nossos banco de dados.
- Acessamos o diretório **C://sqlite** por um console e rodamos o seguinte comando:
```
sqlite3 db/nomedatabase.db
```
- Esse comando vai criar um banco de dados chamado `nomedatabase` dentro do diretório **db** totalmente vazio.

### Verificando qual database está conectado
---
Quando rodamos o comando __.database__ conectado ao `sqlite3` podemos ver a rota para o banco de dados conectado atualmente, já que ele não mostra o nome do database sempre que você se conecta nele.
```sql
sqlite> .database
sqlite> C:/sqlite/db/restemplate.db
```

### Desconectando de um database
---
Podemos nos desconectar de um database utilizando três comandos: __.exit__ ou __.quit__ ou __.q__ 
Esses comando farão o `sqlite3` finalizar e voltar ao console normal.

### Criando uma tabela
---

### Analisando dados de uma tabela (schema)
---
Podemos ver os dados de uma tabela utilizando o comando __.schema__ e passando como atributo o nome da tabela que deseja ver.
Por exemplo, tenho uma tabela chamado persons, para verificar os dados que se encontram nela usamos o seguinte comando conectado ao sqlite3:
```sql
.schema persons
```
O resultado desse comando é mostrar o código SQL da estrutura da tabela criada.

### Salvando resultado de uma query em um arquivo texto
---
Podemos salvar o resultado de uma query SQL (ou seja um comando SQL rodado) em um arquivo texto, para isso usamos o comando __.output__ com o nome do arquivo texto desejado e a query que queremos rodar, como por exemplo:
```sql
.output persons.txt
SELECT FirstName FROM persons
ORDER BY id
LIMIT 24;
```
Esse comando vai criar um arquivo chamado `persons.txt` e vai salvar nele o resultado da query que passamos embaixo, onde é esperado os primeiros nomes das pessoas organizados pelo ID e limitado a somente 24 registros.

### Copiando nosso banco de dados
---
Podemos copiar (criar um dump) com todos os dados que criamos no nosso banco de dados, para isso o SQLite possui um comando chamado __.dump__ que cria uma cópia do banco de dados em um arquivo que dissermos.
1. Primeiro criamos um arquivo de output que desejamos.
2. Depois rodamos o comando .dump que vai salvar todo o database no arquivo criado.
```sql
sqlite> .output restemplatebkup.sql
sqlite> .dump
```
Com isso ele vai criar um arquivo com nosso banco de dados, onde podemos colocar esse arquivo onde quisermos.
Podemos fazer um backup também de uma única tabela, dai temos que passar somente o nome da tabela depois do comando __.dump__ que ele vai fazer dump somente dela.
```sql
sqlite> .output personbkup.sql
sqlite> .dump persons
```
