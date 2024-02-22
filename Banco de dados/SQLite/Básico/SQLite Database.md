[[Página Inicial do SQLite]]

```table-of-contents
```

## Criando um database SQLite
---
Agora que temos tudo instalado como mostrado no tutorial de instalação [[Instalando SQLite e SQLite Studio]] devemos criar um database para colocarmos nossas tabelas.

Para isso devemos criar uma pasta em nosso diretório **C://sqlite** chamado **db** onde iremos colocar nossos databases. Esse é o caminho onde colocaremos e interagiremos com nosso banco de dados SQLite:

```
C://sqlite/db
```

### Criando pelo Console

Podemos fazer pelo console que é mais rápido e depois conectar esse banco de dados no nosso SQLite Studio, para isso iremos acessar o SQLite pelo console no diretório **C://sqlite** e rodar o seguinte comando: $\color{red}{\sf sqlite3}$ no console.
![[SQLiteDatabaseCreation1.png]]
Para sair usamos o comando **.quit** e ele volta ao console normal.
Agora que foi entendido como o comando funciona, devemos usar o comando e depois o nome e extensão do banco de dados, como no exemplo abaixo:
```sql
sqlite3 db/meudatabase.db
```
Ele vai criar um banco de dados com o nome do arquivo que pedimos para criar ou ele vai pegar da pasta **C://sqlite/db** o arquivo que já existe com esse nome.

Eu vou criar um banco de dados para usar de exemplo no meu projeto de API REST em .NET como explicado no documento [[9 - Banco de dados]] onde vai se chamar da seguinte forma:

```
sqlite3 db/restemplate.db
```

![[SQLiteDatabaseCreation2.png]]
Podemos usar o comando **.databases** dentro do sqlite3 para saber quais bancos de dados existem.
Pronto! com isso temos um banco de dados criado e acessado pelo console.
Podemos ver se criou mesmo na pasta **C://sqlite/db** onde deve existir no nosso exemplo o arquivo **restemplate.db**

![[SQLiteDatabaseCreation3.png]]

### Acessando no SQLite Studio
Com o nosso banco de dados criado, podemos acessar ele pelo GUI do SQLite Studio da seguinte forma:
1. Abra o SQLiteStudio e clique na opção **Database** no canto superior esquerdo e depois em **Add a database**
![[SQLiteStudioAddDatabase1.png]]
2. Ele vai abrir uma nova tela onde você deve selecionar o arquivo `.db` do banco de dados que criamos no console no passo anterior e escolher a opção de manter ele permanentemente aberto no SQLiteStudio

![[SQLiteStudioAddDatabase2.png]]
3. Podemos testar a conexão com o nosso banco de dados clicando no botão **Test connection** para avaliar se ele consegue acessar.
4. Agora ele deve mostrar no canto esquerdo os databases disponíveis para acessar.

![[SQLiteStudioAddDatabase3.png]]
Pronto! com isso podemos interagir com o nosso banco de dados desejado.

## Próximo assunto
---
[[SQLite Tables]] - Como criar tabelas no database criado