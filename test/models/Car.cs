using System.ComponentModel.DataAnnotations;

namespace Test.models;

public class Car
{
    [Key]
    public string? registration { get; set; }
    public string? name {get; set;}
    public decimal weight {get;set;}
   

}
