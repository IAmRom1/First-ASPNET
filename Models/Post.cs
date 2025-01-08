namespace Api.Models;

public class Post : BaseEntity
{
    public int Likes {get; set;}
    public string? Description {get; set;} = null;
}