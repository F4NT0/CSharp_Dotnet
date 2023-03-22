# Introduction

In this module, you'll create a cross-platform ASP.NET Core Razor Pages web app with .NET and C#.

This module uses the .NET CLI and Visual Studio Code (Windows, Linux, and macOS) to demonstrate ASP.NET Core Razor Pages development.

This module uses the .NET 6.0 SDK. Ensure that you have .NET 6.0 installed by running the following command in your preferred terminal:

```shell
dotnet --list-sdks
```

Expected Output:

```shell
3.1.100 [C:\program files\dotnet\sdk]
5.0.100 [C:\program files\dotnet\sdk]
6.0.100 [C:\program files\dotnet\sdk]
```

# What is Razor Pages

Razor Pages is a server-side, page-centric programming model for building web UI with ASP.NET Core. Razor Pages provide the following benefits:

Makes it easy to get started building dynamic web apps when all you need is to define UI logic using a combination of HTML, CSS, and C#.
Encourages organization of files by feature, which eases maintenance of your app.
Can be broadly described as an HTML file in which you work with markup as you're used to. You also have the advantage of adding server-side C# code by using Razor syntax.

Razor Pages use a markup language called **Razor** for embedding server-based code into webpages. Razor syntax is a combination of **HTML and C#** where the `C# code defines the dynamic rendering logic for the page`. In a webpage that uses the Razor syntax, there can be two kinds of content: client content and server code:

- **Client content**: Contains what you're used to in webpages. For example, HTML markup (elements), style information such as CSS, maybe some client script such as JavaScript, and plain text.

- **Server code**: Razor enables you to add server code to your client content. If there's server code in the page, the server runs that code first, before it sends the page to the browser. Pages with server code can perform more complex tasks than using client content alone. For example, securely accessing databases. Most importantly, server code can dynamically create client content—it can generate HTML markup or other content and send it to the browser along with any static HTML that the page might contain. From the browser's perspective, client content generated on the server is no different than any other client content.

Razor Pages enforces separation of concerns for page-related data properties and logic operations in a C# PageModel class. A model object typically defines data properties and encapsulates any logic or operations related to those data properties. More specifically, a PageModel:

- Encapsulates the data properties and logic operations scoped just to its Razor page.

- Defines page handlers for HTTP requests sent to the page and for the data used to render the page.

## When to use Razor Pages

Use Razor Pages in your ASP.NET Core app when you:

- Want to generate dynamic web UI from your ASP.NET Core app.
Prefer a page-focused approach to developing web apps, where the page markup and PageModel are in close proximity.
- Want your page-focused ASP.NET Core app to use partial views—mechanisms for reducing duplication of common markup across the site.

Razor Pages allow you to keep your ASP.NET Core pages organized in a simpler way:

- All view (page) specific logic and page properties defined in the Razor page's (PageModel) can be kept together in their own namespace and directory.
- Groups of related pages can be kept in their own namespace and directory.

# Create a web app project

To set up a .NET project to work with a web app, you'll use Visual Studio Code. Visual Studio Code includes an integrated terminal, which makes creating a new project easy. If you don't want to use another code editor, you can run the commands in this module in a terminal.

1. In Visual Studio Code, select File > Open Folder.

2. Create a new folder named **RazorPagesPizza** in the location of your choice, and then choose Select Folder to make it the active folder. If you're shown a prompt asking Do you trust the authors of the files in this folder? select the Yes button.

3. Open the integrated terminal from Visual Studio Code by selecting View > Terminal from the main menu.

4. In the terminal window, copy and paste the following command.

```shell
dotnet new webapp -f net6.0
```

The command uses an ASP.NET Core project template to scaffold a C#-based web app project. A RazorPagesPizza directory is created, which contains an ASP.NET Core project running on .NET. The project name matches the RazorPagesPizza directory name.

You should now have access to these files:

```txt
-| obj
-| Pages
   - | Shared
   - | _ViewImports.cshtml
   - | _ViewStart.cshtml
   - | Error.cshtml
   - | Error.cshtml.cs
   - | Index.cshtml
   - | Index.cshtml.cs
   - | Privacy.cshtml
   - | Privacy.cshtml.cs
-| Properties
-| wwwroot
-| appsettings.Development.json
-| appsettings.json
-| Program.cs
-| RazorPagesPizza.csproj
```

# Compile and Run the project

- Run the following .NET Core CLI command in the terminal on the RazorPagesPizza folder:

```dotnet
dotnet run
```

- You should see in your terminal the following:

```shell
Now listening on: https://localhost:7192
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5211
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
  Content root path: /home/<user>/aspnet-learn/src/RazorPagesPizza
```

- Open your Browser and put the first localhost showed on terminal:

```shell
https://localhost:7192
```

## Examine the Project

Name|Description
|---|---|
_Pages_|Contains Razor Pages and supporting files. Each Razor page is a pair of files: A .cshtml file that contains markup with C# code using Razor syntax. A .cshtml.cs PageModel class file that defines page handler methods and data used to render the page.
_wwwroot_|Contains static asset files, such as HTML, JavaScript, and CSS.
_RazorPagesPizza.csproj_|Contains configuration metadata for the project, such as dependencies.
_Program.cs_|Serves as the app's managed entry point and configures app behavior, such as routing between pages.

By convention, the Pages directory is where all Razor Pages are stored and organized in an ASP.NET Core app.

A Razor page has a `.cshtml` file extension. By convention, its associated _PageModel_ C# class file uses the same name but with a .cs appended. For example, the Razor page Index.cshtml has an associated PageModel class file for _Index.cshtml.cs_.

A model object defines data properties and encapsulates logic or operations related to those data properties. A PageModel is essentially the same thing, but is a model that more specifically encapsulates the data properties and logic operations scoped just to its Razor page. The PageModel class:

- Allows for separation of the logic of a Razor page from its presentation.
- Defines page handlers for requests sent to the page and for the data used to render the page.

A page handler is the method that's executed as a result of an HTTP request. For example, an OnGet method in the Razor page's PageModel class is automatically executed for an HTTP GET request.

Partial markup elements that are shared across several Razor pages are located by convention in a _Pages/Shared directory_. The RazorPagesPizza app uses two shared partial views, which are included when you create a new ASP.NET Core Web Application project:

- _Layout.cshtml: Provides common layout elements across multiple pages.
- _ValidationScriptsPartial.cshtml: Provides validation functionality such as client-side form input validation and cross-site antiforgery validation. This partial view is available to all pages in the project.

- Layouts: In ASP.NET Core, layouts are .cshtml files that define a top-level template for views in the app. Apps don't require a layout. Apps can define more than one layout, with different views specifying different layouts. Most web apps have a common layout that provides a consistent user experience. The layout typically includes common UI elements such as the app header, navigation or menu elements, and footer. Common HTML structures such as scripts and stylesheets are also frequently used by many pages within an app. All of these shared elements may be defined in a layout file, which can then be referenced by any view used within the app. Layouts reduce duplicate code in views.

- Partial view: A partial view is a Razor markup file (.cshtml) that renders HTML output within another markup file's rendered output. Partial views are used to break up large markup files into smaller components. They also reduce the duplication of common markup content across markup files. Partial views aren't used to maintain common layout elements. Common layout elements are specified in a _Layout.cshtml file.

# Create a Page

to create a Page in .NET CLI, use the following code to create a Page in this project:

```cli
dotnet new page --name Pizza --namespace RazorPagesPizza.Pages --output Pages
```

# Create Classes

## Model

- A model class is needed to represent a pizza in inventory. The model contains properties that represent the characteristics of a pizza. The model is used to pass data in the web app and to persist pizza options in the data store.

- Create on Project Root the Directory called `Models`

- Create a file called `Pizza.cs`

- Explain the namespace, it's the directory names to your class

```csharp
namespace RazorPagesPizza.Models;
```

- Create a Class with the name of the Model

```csharp
public class Pizza {
    // ...  
}
```

- Put the informations you wanted in this Model like following:
      - the names from the Atributes beggin with Uppercase
      - `{ get; set; }` are the Getters and Setters from this atribute

```csharp
public class Pizza {

      public int Id { get; set; } // Getter and Setter added
      public String Name { get; set; }
      public PizzaSize Size { get; set; }
      public bool IsGlutenFree { get; set; }
      public decimal Price { get; set; }
}

// Enums
public enum PizzaSize {
      Small,
      Medium,
      Large
}
```

- When some information is Required (not null) you can put the `[Required]` in the atribute

```csharp
public class Pizza {
      // ...

      [Required]
      public int Id { get; set; }

      // ...
}
```

- When some atribute can have the value **null** you can put `?` after his type

```csharp
public class Pizza {
      // ...

      public string? Name { get; set; }

      // ...
}
```

- You can put some range in decimal, when it send error if the value is off this range

```csharp
public class Pizza {
      // ...

      [Range(0.01, 9999.99)]
      public decimal Price { get; set; }

      // ...
}
```

## Services

- Create a `Services` folder into the Root folder

- Create a file called `PizzaService.cs` into the `Services` folder


