[[Página Inicial ASP_NET]]

```table-of-contents
```

## Utilizando Postman
---
Iremos testar o Postman utilizando o nosso exemplo de API REST criado, para isso precisa primeiro ler os seguinte documentos:
1. [[1 - Criando template ASPNET no Visual Studio]]
2. [[2 - Básico de REST]]
3. [[3 - Model]]
4. [[4 - Services]]
5. [[5 - Template de um Controller]]
6. [[6 - Controller]]
7. [[7 - Iniciando o projeto]]
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
![[Pasted image 20240220181926.png]]
Agora temos que pegar as informações do nosso [[3 - Model]] e colocar em formato JSON na aba **Body** onde iremos definir os valores do nosso Objeto Person, para isso deve ser seguido os passos abaixo.
1. Acesse a aba **Body**
2. Selecione a opção de texto **raw**
3. Quando selecionado **raw** vai mostrar no final da linha de opções escrito **JSON**
4. Devemos construir o JSON com os dados como abaixo:
```JSON
{
    "Id": 1,
    "FirstName": "Gabriel",
    "LastName": "Fanto",
    "Address": "Porto Alegre",
    "Gender": "Male"
}
```

Agora em vídeo:

![[CreatePersonPOST.gif]]

###### Testando
Agora que temos a requisição preparada, devemos rodar o projeto e testar nossa rota, onde no caso do POST ele vai pegar as informações do **Body** e enviar para o banco de dados e nos dar o resultado 200 OK junto com os dados salvos no banco no **Response**

![[CreatePersonPOSTResponse.gif]]

Com isso temos a response mostrando o que foi salvo no banco de dados e nos retornando o objeto que criamos, além do código 200.
#### GET ALL
---

#### GET BY ID
---
#### PUT
---
#### DELETE
---
