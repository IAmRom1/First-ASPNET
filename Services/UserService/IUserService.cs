namespace Api.Services;

public interface IUserService 
{
    ServiceResponse<List<User>> GetUsers();
    ServiceResponse<User> GetUserById(int id);
}