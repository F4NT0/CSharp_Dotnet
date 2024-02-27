[[Página Inicial ASP_NET]]

```table-of-contents
```

## O que é Migration
---
**Migrações no ASP.NET** são um recurso essencial para gerenciar alterações no esquema do banco de dados em aplicativos ASP.NET.

1. **O que são Migrações?**
    
    - **Migrações** permitem que você altere o **modelo de dados** (ou seja, as classes de entidade) e aplique essas alterações ao **banco de dados** sem descartar e recriar todo o banco.
    - Antes das migrações, quando você alterava o modelo de dados, o Entity Framework descartava o banco de dados existente e criava um novo com base no novo modelo. Isso funcionava bem durante o desenvolvimento, mas não era prático em produção.
    - Com as migrações, você pode **atualizar** o esquema do banco de dados sem perder os dados existentes.
2. **Como funcionam as Migrações?**
    
    - Quando você adiciona, remove ou altera classes de entidade ou a classe `DbContext`, o Entity Framework cria uma **migração**.
    - A migração contém instruções para **atualizar** o banco de dados de acordo com as alterações no modelo.
    - Você pode aplicar a migração ao banco de dados usando comandos como `Add-Migration` e `Update-Database`.
3. **Benefícios das Migrações:**
    
    - **Flexibilidade**: Você pode iterar no modelo de dados sem medo de perder dados.
    - **Controle**: As migrações permitem que você gerencie o esquema do banco de dados de forma incremental.
    - **Implantação mais segura**: Em produção, as migrações atualizam o esquema sem descartar o banco.
4. **Como habilitar Migrações:**
    
    - No seu projeto ASP.NET, você pode usar o **Code First Migrations**.
    - Desabilite o inicializador que excluía e recriava o banco de dados automaticamente.
    - Habilite as migrações com o comando `Enable-Migrations`.

Lembre-se de que as migrações são uma prática recomendada para manter o esquema do banco de dados em sincronia com o modelo de dados, especialmente quando você implanta seu aplicativo em produção. 🚀

## Como colocar Migration
---
Agora vamos ver de implementar o Migration em nosso projeto.

Precisamos baixar alguns Pacotes em nosso projeto, o primeiro dele se chama __Evolve__