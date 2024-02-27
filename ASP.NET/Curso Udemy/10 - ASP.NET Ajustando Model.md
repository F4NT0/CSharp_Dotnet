[[Página Inicial ASP_NET]]
![[R (3).png#center|200]]

```table-of-contents
```

## Páginas anteriores
- [[1 - ASP.NET Template]]
- [[2 - ASP.NET REST]]
- [[3 - ASP.NET Model]]
- [[4 - ASP.NET Services]]
- [[5 - ASP.NET Controller Template]]
- [[6 - ASP.NET Controller]]
- [[7 - ASP.NET Run Project]]
- [[8 - Postman]]
- [[9 - ASP.NET Context]]

## Ajustando o Model
---
Agora que fizemos toda a criação do Context e sua configuração com o projeto, vamos ajustar o Model para se entender com os dados no banco de dados.
Os nomes que se encontram no banco de dados são diferentes aos nomes que se encontra na classe Model, por isso podemos fazer as modificações necessárias para que o Model reconheça esses valores.

### Anotação Table
Como vimos no estudo [[4 - SQLite Tables]] vimos que o nome da nossa tabela de pessoas se chama _persons_ e o nome do nosso Model é _Person_ por isso podemos usar a anotação __Table__ para dissermos exatamente qual o nome que é esperado para enviar ao banco de dados.

```csharp
[Table("persons")]
public class Person {}
```

### Anotação Column

Para as colunas do banco de dados deve ser feito o mesmo, mas utilizando a anotação __Column__ onde iremos colocar os nomes como foram identificados na criação da tabela no tópico [[4 - SQLite Tables#Exemplo de tabela]] :

```sql
CREATE TABLE IF NOT EXISTS persons (
	person_id INTEGER PRIMARY KEY,
	first_name TEXT NOT NULL,
	last_name TEXT NOT NULL,
	address TEXT,
	gender TEXT
);
```

No ASP.NET ficam com os seguintes nomes ajustando:

```csharp

[Column("person_id")]
public long Id { get; set; }

[Column("first_name")]
public string FirstName { get; set; }

[Column("last_name")]
public string LastName { get; set; }

[Column("address")]
public string Address { get; set; }

[Column("gender")]
public string Gender { get; set; }
```

