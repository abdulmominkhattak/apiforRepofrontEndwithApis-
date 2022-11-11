namespace apiForUserCrud.Model
{
    public interface IUserRespository
    {
        public User GetById(int id);
        public IEnumerable<User> GetAllUsers();

        public User AddUser(User employee);

        public void DeleteUser(int id);

    
    }
}
