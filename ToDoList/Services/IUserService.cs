using ToDoList.Model;

namespace IaOrganization.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUserAsync();
        Task<User> AddNewUserAsync(User request);
        Task<User> UpdateUserAsync (UpdateUser request, string email);
        Task<User> GetASingleUserAsync(string email);
        Task<User> DeleteUserAsync (string email);
    }
}
