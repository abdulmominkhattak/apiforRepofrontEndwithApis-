namespace apiForUserCrud.Model
{
    public class UserRepository : IUserRespository
    {

        private List<User> _users;   
        public UserRepository()
        {
            _users = new List<User>()
            {
                new User(){Id = 1, Name = "Momin", Gender = "Male", Age = 20, Email = "abd@gmail.com", Department = "Science"},
                new User(){Id = 2, Name = "Faheem", Gender = "Male", Age = 22, Email = "FaheemK@gmail.com", Department = "Fianance"},
                new User(){Id = 3, Name = "Haris", Gender = "Male", Age = 25, Email = "HarisJamal@gmail.com", Department = "IT"},
                new User(){Id = 4, Name = "Ali", Gender = "Female", Age = 19, Email = "aliNaseem@gmail.com", Department = "Swp"}
            };
        }

        public User AddUser(User user)
        {
            user.Id = _users.Max(e => e.Id) + 1;
            _users.Add(user);
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(e => e.Id == id);
        }

        public void DeleteUser(int id)
        {
            _users.Remove(GetById(id));
        }

       
    }
}
