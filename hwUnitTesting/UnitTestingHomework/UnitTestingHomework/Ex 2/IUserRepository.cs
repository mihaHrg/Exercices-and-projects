namespace UnitTestingHomework.Ex_2
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        void SaveUser(User user);
    }
}

