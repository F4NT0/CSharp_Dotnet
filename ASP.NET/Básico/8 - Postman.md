[[Página Inicial ASP_NET]]

```table-of-contents
```

## Utilizando Postman
---
Iremos testar o Postman utilizando o nosso exemplo de API REST criado, para isso precisa primeiro ler os seguinte documentos:
1. [[1 - ASP.NET Template]]
2. [[2 - ASP.NET REST]]
3. [[3 - ASP.NET Model]]
4. [[4 - ASP.NET Services]]
5. [[5 - ASP.NET Controller Template]]
6. [[6 - ASP.NET Controller]]
7. [[7 - ASP.NET Run Project]]
---
### Instalando o Postman
---
Você pode instalar o Postman facilmente pelo [Site oficial](https://www.postman.com/downloads/) e seguir os passos de instalação padrão.
Após isso acesse sua conta de email ou crie uma.
Quando se logar, você vai ver a seguinte página
![[PostmanHome.png]]
Para criar um Workspace de trabalho, criamos como no Gif abaixo
![[CreatePostmanWorkspace.gif]]
### Entendendo as partes do Postman
---
Agora que temos nosso Workspace pronto, vamos entender suas partes
![[PostmanInfos.png]]
1. Podemos escrever uma descrição de nosso Workspace.
2. Podemos salvar as Collections (Conjunto de Requisições) favoritas.
3. Possui a aba onde podemos ver todos os Collections.
4. Possui a aba onde podemos ver todos os Enviroments(Conjunto de variáveis que podemos utilizar).
5. Botão onde podemos criar novas coisas no Postman.
6. Botão para importar Collections ou Enviroments já criados no Postman.
7. Área onde mostra e podemos ativar os Enviroments.
### Como criar uma Collection
---
Para criarmos uma Collection clicamos no botão de `New...` no topo esquerdo e selecione a opção de `Collection`.
Podemos escrever na Collection uma documentação explicando de como usar essa Collection
![[CreatePostmanCollection.gif]]
### Como criar um Enviroment
---
Enviroment serve para salvarmos variáveis para usarmos em todas as requisições, facilitando a necessidade de ter que repetir informações básicas ou tokens entre múltiplas requisições e também podemos exportar para algum diretório ou salvar.
Podemos criar um Enviroment clicando em `New...` e depois `Enviroment` ou podemos clicar no símbolo de um olho no canto direito e selecionar `Add`
#### Opção 1

![[PostmanCreateEnviroment1.png]]
#### Opção 2

![[PostmanCreateEnviroment2.png]]

Com isso agora podemos criar as variáveis que desejamos como mostra no vídeo abaixo:
![[CreatePostmanEnviroment.gif]]
Assim podemos acessar nossos Enviroments no canto esquerdo e o Enviroment somente vai estar ativo quando chamamos no canto direito.
![[PostmanSelectEnviroment.png]]
### Criando Requisições
---
Agora que temos tudo pronto, podemos criar as requisições da API que implementamos no Postman.
Enquanto o projeto estiver rodando localmente no Computador, podemos testar requisições no Postman como irei mostrar em seguida para cada tipos.
#### POST
---
###### Criando
Post como sabemos foi definido por uma URL básica definido pelo Controller, por isso para utilizar o POST criamos uma requisição dentro de um Collection do tipo POST.
Para isso clicamos nos três pontos do lado do nome da nossa Collection e selecionamos a opção
`Add request`

![[PostmanAddRequest.png]]
Isso vai abrir uma nova tela onde devemos dizer:
1) nome da nossa requisição. 
2) o tipo de requisição(GET, POST, PUT, DELETE entre outras).
3) A URL para fazer essa requisição.
![[PostmanCreateRequest1.png]]
Devemos então colocar um nome que nos ajude a entender que tipo de requisição estamos querendo fazer, colocar com a opção POST e colocar a rota definida na nossa API, como o seguinte exemplo:
![[CreatePersonPostman1.png]]
Agora temos que pegar as informações do nosso [[3 - ASP.NET Model]] e colocar em formato JSON na aba **Body** onde iremos definir os valores do nosso Objeto Person, para isso deve ser seguido os passos abaixo.
1. Acesse a aba **Body**
2. Selecione a opção de texto **raw**
3. Quando selecionado **raw** vai mostrar no final da linha de opções escrito **JSON**
4. Devemos construir o JSON com os dados como abaixo:
```JSON
{
    "FirstName": "Gabriel",
    "LastName": "Fanto",
    "Address": "Porto Alegre",
    "Gender": "Male"
}
```
###### Testando
Agora que temos a requisição preparada, devemos rodar o projeto e testar nossa rota, onde no caso do POST ele vai pegar as informações do **Body** e enviar para o banco de dados e nos dar o resultado 200 OK junto com os dados salvos no banco no **Response**

![[CreatePersonPOST.gif]]

Com isso temos a response mostrando o que foi salvo no banco de dados e nos retornando o objeto que criamos, além do código 200.
#### GET ALL
---
Para podermos ver todos os dados salvos é bem simples, só precisamos pegar a requisição base definida utilizando a opção GET do Postman.
Não é necessitado nenhum _Body_ nem configurações, só definir como GET.

![[ASPNET_GETALLPOSTMAN.png]]
O retorno no Response vão ser todos os registros do banco de dados.

![[ASPNET_GETALLPOSTMAN2.png]]
#### GET BY ID
---
Get By ID é da mesma forma que o GET ALL mas na requisição passamos um ID para pegarmos somente aquele registro no banco de dados.
Vai ser buscado no banco de dados somente o registro que possuir o ID definido.

![[ASPNET_GETBYIDPOSTMAN.png]]

Vai retornar no Response somente os dados do objeto que possui o ID 1 que foi passado na URL da requisição.

![[ASPNET_GETBYIDPOSTMAN2.png]]

#### PUT
---
O PUT ele necessita ser passado pelo __Body__ do Postman um registro completo também com ID, ele vai pegar o ID passado no JSON e buscar no banco de dados e alterar todos os dados que foram colocados diferentes no Body.
 Um exemplo nosso é o objeto de ID 1 como abaixo:
 
```json
{
    "id": 1,
    "firstName": "Gabriel",
    "lastName": "Fanto",
    "address": "Porto Alegre",
    "gender": "Male"
}
```

Agora vamos fazer algumas alterações, mantendo o ID definido mas mudando todo o resto:

```json
{
    "id": 1,
    "firstName": "Liliane",
    "lastName": "Clemente",
    "address": "Novo Hamburgo",
    "gender": "Female"
}
```

No Postman colocamos esse novo JSON no __Body__ e deixamos a URL normal como do POST, mas mudamos o tipo de requisição para __PUT__.

![[ASPNET_PUTPOSTMAN.png]]

No nosso Response irá mostrar exatamente os dados que colocamos no __Body__ e se fizermos novamente a requisição GET BY ID com o ID desse objeto modificado teremos como resposta se no banco de dados atualizou os dados passados.

![[ASPNET_PUTPOSTMAN2.png]]

#### DELETE
---
Delete tem a mesma URL do GET BY ID, onde passamos um ID que ele vai buscar o objeto do banco de dados e irá apagá-lo permanentemente.
A principal mudança é que devemos selecionar no Postman que essa requisição será do tipo DELETE.

![[ASPNET_DELETEPOSTMAN.png]]

Ele não vai retornar nada como resposta, mas irá nos entregar como resposta o 204 NO CONTENT para vermos que realmente foi removido.

![[ASPNET_DELETEPOSTMAN2.png]]

### Configurações avançadas
---
Podemos fazer algumas configurações que irá fazer nosso projeto ser muito mais avançado para testarmos de forma completa e no fluxo correto.

#### Utilizando o Enviroment

Agora que criamos um Enviroment, vamos colocar a nossa configuração do Localhost que fizemos em nosso projeto ASP.NET.

A configuração se encontra no arquivo _launchsettings.json_ onde podemos usar o `http`, `https`, `IIS Express` onde eu normalmente uso o http.

```json
"profiles": {
  "http": {
    "commandName": "Project",
    "dotnetRunMessages": true,
    "launchBrowser": true,
    "launchUrl": "api/person",
    "applicationUrl": "http://localhost:5110",
    "environmentVariables": {
      "ASPNETCORE_ENVIRONMENT": "Development"
    }
  }
}
```

Como podemos ver nessa configuração, a URL da nossa aplicação será iniciada no `http://localhost:5110` e será o inicio de URL de todas as nossas requisições como foi mostrado nos exemplos anteriores.

Com isso em mente, podemos colocar essa URL em nosso Enviroment e reutilizar essa variável em todas as nossas requisições.

![[ASPNET_POSTMANENVIROMENT1.png]]

Para invocarmos as variáveis do enviroment primeiro precisamos ativá-lo em nosso projeto, somente selecionando ele nas opções de enviroment no canto direito bem encima.

![[ASPNET_POSTMANENVIROMENT2.png]]

Selecione o Enviroment desejado e verifique as variáveis existentes:

![[SelectEnviromentPostman.gif]]

Agora para podermos chamar essa Variável utilizamos chaves duplas em volta do nome da variável em nossas URLs:

![[ASPNET_UPDATEPOSTVARIABLE.png]]
![[ASPNET_UPDATEGETALLPOSTMAN.png]]
![[ASPNET_UPDATEGETIDPOSTMAN.png]]
![[ASPNET_UPDATEUPDATEPOSTMAN.png]]
![[ASPNET_UPDATEDELETEPOSTMAN.png]]
Agora sempre que mudar a URL para outra posta ou trocar para produção, somente deve ser atualizado o valor da variável, não precisando alterar as URLs de cada requisição.

#### Criando uma variável global pelos testes

Variáveis globais podem ser usadas por todas as requisições de todas as Collections que pertencem ao grupo que estou mexendo, elas são muito úteis para criarmos ou interagirmos com variáveis que mudam o tempo todo, no nosso caso, quando criamos um POST e gera um ID na response podemos salvar esse ID para reutilizarmos.

Para fazer isso, iremos utilizar pela primeira vez a aba do Postman chamada __Tests__ , nela podemos criar Testes em Javascript utilizando a biblioteca do Postman chamado __PM__.

Um exemplo simples é verificarmos se a resposta da nossa requisição deu 200 OK:

```js
pm.test("Status code is 200", function () {
	pm.response.to.have.status(200);
});
```

Para pegarmos um dado da Response do Postman temos que usar o método do Postman chamado __globals__  mas primeiro devemos ter uma variável que armazene os valores do JSON como abaixo:

```js
var jsonData = pm.response.json();
```

Com essa variável pegamos o ID como se escreve no Response e usamos o _set_ do __globals__ para definir o valor que pegamos em uma variável que definimos o nome:

```js
pm.globals.set("Person Id", jsonData.id);
```

Com isso definido criamos o Teste usando o __pm.test__ como no exemplo do response status:

```js
pm.test("Validate ID", function () {
	var jsonData = pm.response.json();
	pm.globals.set("Person Id", jsonData.id);
});
```

Abaixo se encontra o nosso teste na aba __Tests__ no Postman

![[ASPNET_TESTPOST.png]]

Rodando esse teste, ele vai criar um novo objeto, pegar o ID do Response e salvar nas variáveis globais do Postman:

![[AddGlobalVariables.gif]]

Agora podemos usar esse ID salvo em outras requisições como por exemplo o GET BY ID, onde de vez de passarmos um ID específico, ele pega dessa variável:

![[AddGlobalVariables2.gif]]

