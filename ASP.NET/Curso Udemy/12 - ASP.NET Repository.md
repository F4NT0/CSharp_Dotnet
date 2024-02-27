[[Página Inicial ASP_NET]]

```table-of-contents
```

## Páginas anteriores
---
- [[1 - ASP.NET Template]]
- [[2 - ASP.NET REST]]
- [[3 - ASP.NET Model]]
- [[4 - ASP.NET Services]]
- [[5 - ASP.NET Controller Template]]
- [[6 - ASP.NET Controller]]
- [[7 - ASP.NET Run Project]]
- [[8 - Postman]]
- [[9 - ASP.NET Context]]
- [[10 - ASP.NET Ajustando Model]]
- [[11 - ASP.NET Ajustando Implementations]]

## O que é Repository
---
O **padrão Repository** é uma abordagem importante no desenvolvimento de aplicações ASP.NET. Ele se origina do **Domain-Driven Design (DDD)** e propõe a criação de objetos chamados **Repositories**, que gerenciam coleções de dados persistidos. A principal característica dos Repositories é que eles são **agnósticos à tecnologia utilizada**, ou seja, não estão vinculados a um banco de dados específico, cache de memória ou qualquer outra fonte de dados.

Aqui estão alguns pontos essenciais sobre o padrão Repository:

1. **Separação de Responsabilidades**: O padrão Repository ajuda a separar a responsabilidade de acesso a dados das outras camadas da aplicação. Isso melhora a organização do código e facilita a manutenção.
    
2. **Menor Acoplamento**: Ao utilizar o padrão Repository, o acoplamento entre as camadas da aplicação é reduzido. Isso significa que as mudanças no acesso a dados não afetam diretamente outras partes do sistema.
    
3. **Testabilidade Aprimorada**: O uso de interfaces com o padrão Repository permite a criação de testes unitários mais eficientes. Isso ocorre porque podemos criar implementações de teste para os Repositories sem depender de um banco de dados real.
    

Para ilustrar, vejamos um exemplo prático de como implementar o padrão Repository em uma aplicação ASP.NET Core com o Entity Framework (EF) Core:

1. **Interface ICustomerRepository**:
    
    - Primeiro, criamos uma interface chamada `ICustomerRepository`. Essa interface define os métodos básicos de acesso aos dados, como `GetAll`, `GetById` e `Insert`.
2. **Classe CustomerRepository**:
    
    - Em seguida, implementamos a classe `CustomerRepository`, que é responsável por realizar a interação com a entidade “Customer”. Nessa classe, transferimos o código de acesso a dados que estava anteriormente no Controller.

## Criando o Repository
---
Agora que sabemos o que é o Repository em teoria, vamos criar um Repository em nosso projeto, onde vamos criar um diretório novo com o nome Repository e criar a interface para o nosso objeto Person

![[ASPNET_Repository.png | 400]]

Depois criamos uma interface que chamaremos de __IPersonRepository__

![[ASPNET_RepositoryPersonInterface.png]]

Essa Interface vai ter os mesmos construtores do Service, onde iremos implementar mais um que é o _Exists_ que utilizamos antes:

![[ASPNET_RepositoryPersonInterface2.png]]

Depois criamos um diretório chamado _Implementations_ e criamos a classe __PersonRepositoryImplementation__ com os mesmos métodos do __PersonServiceImplementation__ sendo a principal mudança que o método _Exists_ agora será público.

```csharp
using RESTTemplate.Model;
using RESTTemplate.Model.Context;

namespace RESTTemplate.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        private SQLiteContext _context;

        public PersonRepositoryImplementation(SQLiteContext context) 
        { 
            _context = context; 
        }

        
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindbyID(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
```

Toda a lógica dos Services agora será modificada!

## Adicionando a dependência no Program.cs
---
Assim como fizemos no Service, devemos alterar o _Program.cs_ adicionando a conexão com o Repository que foi recém criado, de uma forma bem simples, adicione o seguinte código abaixo da dependência do Service:

```csharp
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
```


