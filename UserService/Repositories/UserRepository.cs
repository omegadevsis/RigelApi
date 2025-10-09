using System.Collections.Generic;
using UserService.Models;

namespace UserService.Repositories;

public class UserRepository : IUserRepository
{
    public List<User> Get()
    {
        var users = new List<User>()
        {
            new User(1, "Igor"),
            new User(2, "Iago"),
            new User(3, "Irio"),
            new User(4, "Isabel"),
        };

        return users;
    }

    public User Create(int id, string name)
    {
        var user = new User(id, name);
        return user;
    }
}

public interface IUserRepository
{
    List<User> Get();
    User Create(int id, string name);
}