[[Página Inicial do SQLite]]

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
### Criando um database

- Podemos criar um diretório chamado **db** dentro do diretório **C://sqlite** para colocarmos nossos banco de dados.
- Acessamos o diretório **C://sqlite** por um console e rodamos o seguinte comando:
```
sqlite3 db/nomedatabase.db
```
- Esse comando vai criar um banco de dados chamado `nomedatabase` dentro do diretório **db** totalmente vazio.