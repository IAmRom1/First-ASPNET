using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

public class BaseEntity
{
    [Key]
    [Column("id")]
    public int Id {get; set;}

    [Column("creation_date")]
    public DateTime CreationDate {get; set;} = DateTime.Now;
}