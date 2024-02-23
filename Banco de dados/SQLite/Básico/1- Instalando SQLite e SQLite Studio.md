[[Página Inicial do SQLite]]

```table-of-contents
```

## O que é SQLite
---
SQLite é um banco de dados relacional de código aberto que armazena seus arquivos dentro de sua própria estrutura. Ele não depende de um servidor para armazenar suas informações, o que o torna muito útil para aplicações diversas, principalmente websites de tráfego médio e sistemas mobile.

SQLite é capaz de funcionar muito bem em aplicações diversas, principalmente, websites de tráfego médio e sistemas mobile. Ele suporta um grande número de linguagens, algo em torno de 30, o que o torna bastante versátil.

Diferente de outras ferramentas do tipo, como o MySQL, o SQLite consegue colocar os seus arquivos dentro de si próprio.
## Instalando SQLite
---
### Baixando o SQLite
Podemos baixar o programa no site oficial: [SQLite Download Page](https://sqlite.org/download.html)

Escolha a versão para Windows mostrada abaixo, ela possui o Shell e command line infos para seu computador.
![[SQLiteVersionWindows.png]]
Baixe o .zip e coloque na sua pasta de Downloads, extraia os documentos e renomeie para sqlite e é esperado que você tenha os seguintes documentos:
![[SQLiteFolder.png]]
Agora iremos pegar esse diretório e iremos salvar na pasta **C:/** do seu computador.
### Testando o SQLite
Agora que colocamos o sqlite folder no **C:/** devemos acessar esse diretório pelo seu console windows e rodar o comando **sqlite3** no console:
![[SQLiteAccess.png]]
Se mostrar a versão do SQLite e acessar o banco significa que foi instalado com sucesso!
Para sair do SQLite do console coloque o comando **.quit**
## Utilizando SQLite
---
### Pelo Console
Quando colocamos o comando **.help** no console conectados ao SQLite ele nos mostra os tipos de comandos que podemos usar:

|Comando|Descrição|
|---|---|
|`.databases`|Lista todos os bancos de dados.|
|`.tables`|Lista todas as tabelas no banco de dados atual.|
|`.schema`|Mostra o esquema de criação de todas as tabelas.|
|`.header on`|Ativa a exibição de nomes de colunas no resultado da consulta.|
|`.mode column`|Configura o formato de saída para o modo coluna.|
|`.exit`|Sai do SQLite.|
|`SELECT * FROM nome_tabela;`|Seleciona todos os dados de uma tabela.|
|`INSERT INTO nome_tabela (coluna1, coluna2) VALUES (valor1, valor2);`|Insere dados em uma tabela.|
|`UPDATE nome_tabela SET coluna1 = valor1 WHERE condição;`|Atualiza dados em uma tabela.|
|`DELETE FROM nome_tabela WHERE condição;`|Deleta dados de uma tabela.|
### Por um gerenciador de DBs

Podemos ver nosso banco de dados do SQLite por um Gerenciador específico chamado SQLite Studio que podemos baixar aqui:
[SQLite Studio](https://sqlitestudio.pl/?act=download%E3%80%82SQLiteStudio) ou caso não possa instalar no seu computador por ser de empresa, instale a versão **portable** que se encontra no Github, como por exemplo: [Releases · pawelsalawa/sqlitestudio (github.com)](https://github.com/pawelsalawa/sqlitestudio/releases)
Não precisa instalar o programa, nesse caso você extrai todos os arquivos que se encontram no .zip e coloque no diretório que quiser, então somente clique no arquivo **SQLiteStudio.exe** para iniciar o programa, ele deve mostrar a imagem a seguir inicialmente:
![[SQLiteStudioOpening.png]]

## Criando um database e conectando nele
---
Agora que temos o nosso SQLite configurado, devemos criar um [[3 - SQLite Database]] e se conectar com ele para podermos criar nossas tabelas