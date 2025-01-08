using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

public class User : BaseEntity
{
    [Column("email")]
    [EmailAddress]
    [MaxLength(255)]
    [MinLength(5)]
    public required string Email {get; set;}
    
    [Column("username")]
    public required string Username {get; set;}
}