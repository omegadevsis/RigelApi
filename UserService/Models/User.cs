namespace UserService.Models;

public class User
{
    public int UserId { get; private set; }
    public string UserName { get; private set; }

    public User(int id, string name)
    {
        UserId = id;
        UserName = name;
    }
}