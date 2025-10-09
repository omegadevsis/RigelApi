using UserService.Repositories;

namespace UserService.Tests;

public class UserServiceTests
{
    private readonly IUserRepository _userRepository;

    public UserServiceTests()
    {
        _userRepository = new UserRepository();
    }

    [Theory]
    //[InlineData(5)]
    [InlineData(4)]
    //[InlineData(3)]
    public void GetAllUsersTest(int count)
    {
        var result = _userRepository.Get();
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(count, result.Count);
        //Assert.Equal(result, p => p.UserId == 1);
    }
    
    [Fact]
    public void GetAllUsersTest2()
    {
        var result = _userRepository.Get();
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Contains(result, p => p.UserId == 1);
        Assert.Contains(result, p => p.UserId == 2);
    }

    [Theory]
    [InlineData(5, "Liliane")]
    [InlineData(6, "Reinaldo")]
    public void PostUserTest(int id, string name)
    {
        var result = _userRepository.Create(id, name);
        
        Assert.Equal(id, result.UserId);
        Assert.Equal(name, result.UserName);
    }
}