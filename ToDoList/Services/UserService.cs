using ToDoList.Model;

namespace IaOrganization.Services
{
    public class UserService : IUserService
    {

        public static List<User> users = new List<User>
        {
              new User
            {
                FirstName = "John",
                Email = "John@email.com",
                LastName = "John",
                Password = "John1234",
            },
              new User
            {
                FirstName = "Paul",
                Email = "Paul@email.com",
                LastName = "Paul",
                Password = "Paul234",
            },
              new User
            {
                FirstName = "Markeese",
                Email = "Markesse@email.com",
                LastName = "Markeese",
                Password = "Markeese234",
            },
              new User
            {
                FirstName = "Ted",
                Email = "Ted@email.com",
                LastName = "Ted",
                Password = "Ted1234",
            },
              new User
            {
                FirstName = "Sabrina",
                Email = "Sabrina@email.com",
                LastName = "Sabrina",
                Password = "Sabrina1234",
            }
        };
        public async Task<List<User>> GetAllUserAsync()
        {
            return users;
        }
        public Task<User> GetASingleUserAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email), "Email cannot be null or empty");

            var user = users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());

            if(user == null)
                throw new ArgumentNullException(nameof(email), "There no User with that email Address");

            return Task.FromResult(user);
        }
        public async Task<User> AddNewUserAsync(User request)
        {
            if (request != null)
                users.Add(request);

            return request;
        }

        public async Task <User> UpdateUserAsync(UpdateUser request, string email)
        {
            var user = users.FirstOrDefault(u => u.Email == email);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;

            return user;
        }
        public async Task<User?> DeleteUserAsync(string email)
        {
            var user = users.FirstOrDefault(u => u.Email == email);

            users.Remove(user);
            
            return user;
        }
}} 
