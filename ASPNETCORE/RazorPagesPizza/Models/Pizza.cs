using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;

public class Pizza
{
    public int Id { get; set; } // primary key

    [Required]
    public string? Name { get; set; } // ? means nullable
    public PizzaSize Size { get; set; } // enum
    public bool IsGlutenFree { get; set; } // checkbox

    [Range(0.01, 9999.99)] // min and max values
    public decimal Price { get; set; } // decimal
}

public enum PizzaSize { Small, Medium, Large }