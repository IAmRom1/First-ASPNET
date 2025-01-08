namespace Api.Models;

public class ServiceResponse<T>
{
    public T? Data {get; set;}
    public string ErrorMessage {get; set;} = string.Empty;
    public bool Success {get; set;} = true;
}