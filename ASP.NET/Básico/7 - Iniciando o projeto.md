[[Página Inicial ASP_NET]]

```table-of-contents
```

## Rodando o projeto
---
É bem simples rodar o projeto no Visual Studio, onde após configurado o $\color{lightgreen}{\sf launchSettings.json}$ com as rotas definidas no [[6 - Controller]] somente precisamos clicar no Runner desejado, possuindo 3 principais:

![[ASPNET_RunningOptions.png]]
 Podemos selecionar a opção que quiser e clique em **Run...** que é onde tem o nome da opção escrita:
 ![[VisualStudioRun.gif]]
 Vai abrir uma página Web, onde vai iniciar na URL definida em `launchUrl` que deve ser o código da API ou de um Controller específico como mostrado a nossa URL vai ser `api/person` que vai iniciar o GET geral, como mostrado abaixo:
 ![[VisualStudioRun2.gif]]
 Com isso podemos testar as requisições diretamente no Browser ou podemos testar no Postman enquanto estiver rodando o projeto no Visual Studio.