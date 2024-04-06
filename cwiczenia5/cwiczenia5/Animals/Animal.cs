using System.ComponentModel.DataAnnotations;
using cwiczenia5.Enums;

namespace cwiczenia5.Animals;

public class Animal
{
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    [EnumDataType(typeof(Rasa))]
    public Rasa Rasa { get; set; }
    public int Mass { get; set; }
    [Required]
    [EnumDataType(typeof(FurrColor))]
    public FurrColor furrColor { get; set; }
}