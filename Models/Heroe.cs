
using System.ComponentModel.DataAnnotations;

public class Heroe{
    [Required]
    [MinLength(4, ErrorMessage ="need 4 characters!")]
    public string firstName { get; set; }
    [Required]
    [MinLength(4, ErrorMessage ="need 4 characters!")]
    public string lastName { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(8, ErrorMessage = "The password need 8 characters!")]
    [DataType(DataType.Password)]
    public string Pass { get; set; }
}