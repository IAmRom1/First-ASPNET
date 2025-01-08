namespace Api.Services;

public class UserService : IUserService
{
    public ServiceResponse<User> GetUserById(int id)
    {
        List<User> users = GenerateUsers(5);

        try
        {
            User? user = users.FirstOrDefault(u => u.Id == id) ?? throw new NullReferenceException("utilisateur introuvable");
            return new ServiceResponse<User>(){Data = user, ErrorMessage = string.Empty, Success = true};
        }
        catch(Exception ex)
        {
            return new ServiceResponse<User>(){Data = null, ErrorMessage = ex.Message, Success = false};
        }
    }

    /// <summary>
    /// Return a list of users.
    /// </summary>
    /// <returns></returns>
    public ServiceResponse<List<User>> GetUsers()
    {
        List<User> users = GenerateUsers(10);

        return new ServiceResponse<List<User>>(){Data = users, ErrorMessage = "null"};
    }

    /// <summary>
    /// Generate a list of users.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static List<User> GenerateUsers(int number)
    {
        List<User> users = [];

        for(int i = 0; i < number; i++)
        {
            users.Add(new User(){Id = i++, Email = "test", Username = "test"});
        }

        return users;
    }
}