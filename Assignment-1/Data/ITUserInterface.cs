namespace Assignment_1.Data
{
    public interface ITUserInterface
    {
        User ValidateUser(string userName, string Password);
        void AddUser(User user);
    }
}