[[Página Inicial ASP_NET]]

Vamos criar um Controller com as requisições para testarmos nossa API:

## Inicio
---
Primeiro criamos um arquivo dentro do diretório **Controller** no projeto

![[ASPNET_CREATE_CONTROLLER.png]]
Depois abrimos o arquivo **launchSettings.json** e colocamos uma rota que iremos criar para ajustar do template criado

![[ASPNET_launchsettings_config1.png]]

## Template
---
Agora vamos criar e entender as partes do template de um Controller!

### Classe

```csharp
[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase 
{
	// Insert code Here
}
```

Aqui, estamos definindo uma classe chamada `CalculatorController` que herda de `ControllerBase`. As anotações `ApiController` e `Route` são usadas para indicar que esta classe é um controlador de API e para definir a rota base para este controlador, respectivamente.

$\color{yellow}{\sf ControllerBase}$ = É uma classe base do ASP.NET Core que manipula solicitações HTTP, fornecendo um conjunto de propriedades e métodos comuns que Controllers podem usar para manipular solicitações HTTP e gerar respostas HTTP.
Um exemplo de método que o ControllerBase possui que utilizamos muito é o **Ok(object? value)** e **BadRequest(object? value)**

```Csharp
[HttpGet("mult/{firstNumber}/{secondNumber}")]
public IActionResult Mult(string firstNumber, string secondNumber)
{
    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
    {
        var mult = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
        return Ok(mult.ToString()); // ControllerBase.Ok
    }

    return BadRequest("Error! Invalid Input"); // ControllerBase.BadRequest
}
```

$\color{yellow}{\sf ApiController}$ = é um atributo do ASP.NET Core que, quando associado a um Controller ajuda a simplificar a codificação e a manter o código mais limpo. Este atributo indica que um tipo e todos os tipos derivados são usados para server a response de HTTP.
ApiController auxilia o ControllerBase a fazer requisições Web com os métodos implementados no ControllerBase.

$\color{yellow}{\sf Route}$ = É um atributo do ASP.NET Core que é usado para definir rotas para métodos de ação de um Controller. Ele descreve como os caminhos da URL são correspondidos ás ações e é usado para gerar URLs para links. O padrão é chamar todas as rotas definidas em cada método de ação ou criar uma rota geral, esse normalmente é o exemplo gerado automático:

```csharp
[Route("[controller]")]
```

Podemos alterar para uma rota desejada:

```csharp
[Route("Home/Index/{name?}")]
public IActionResult Index(string name)
{
    //...
}
```

Em relação ao código limpo, é melhor usar o **HttpGet**, ou **HttpPost** ou **HttpPut** ou **HttpDelete** para colocar a rota no método de ação como mostrado anteriormente:

```csharp
[HttpGet("mult/{firstNumber}/{secondNumber}")]
```
****

```csharp
private readonly ILogger<CalculatorController> _logger;
public CalculatorController(ILogger<CalculatorController> logger)
{
    _logger = logger;
}
```

Este é o construtor da classe `CalculatorController` e está injetando uma dependência de `ILogger<CalculatorController>`. A injeção de dependência é um padrão de design que permite que uma classe receba as dependências de outras classes.

```csharp
[HttpGet("sum/{firstNumber}/{secondNumber}")]
public IActionResult Get(string firstNumber, string secondNumber)
```

Este é um método de ação que responde a solicitações HTTP GET para a rota `sum/{firstNumber}/{secondNumber}`. Ele recebe dois parâmetros, `firstNumber` e `secondNumber`.

```csharp
if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
{
    var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
    return Ok(sum.ToString());
}
```

Aqui, estamos verificando se os dois parâmetros são numéricos. Se forem, convertemos os números para decimal, somamos e retornamos o resultado com um status HTTP 200 (OK).

```csharp
return BadRequest("Error! Invalid Input");
```

Se os parâmetros não forem numéricos, retornamos um erro com um status HTTP 400 (Bad Request).

```csharp
private bool IsNumeric(string strNumber)
```

Este é um método privado que verifica se uma string pode ser convertida em um número.

```csharp
private decimal ConvertToDecimal(string strNumber)
```

Este é outro método privado que tenta converter uma string em um número decimal. Se a conversão falhar, ele retorna 0.