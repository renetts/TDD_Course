using Moq;
using MockingUnitTesting.Repository;
using MockingUnitTesting.Service;

namespace MockingTests;

public class UserServiceTest
{
    private IUserRepository userRepository;
    private UserService userService;

    public UserServiceTest() {
        userRepository = new FakeUserRepository();
        userService = new UserService(userRepository);
    }

    [Fact]
    public void TestGetAllUsersUsingFake()
    {
        List<object> actual = userService.GetAllUsers();
        Assert.Empty(actual);
        userService.Insert("Renato");
        actual = userService.GetAllUsers();
        Assert.NotEmpty(actual);
        Assert.Equal("Renato", actual.First());
    }

    [Fact]
    public void TestGetAllUsersUsingStub()
    {
        IUserRepository userRepository = new StubUserRepository();
        UserService userService = new UserService(userRepository);
        List<object> actual = userService.GetAllUsers();
        Assert.NotEmpty(actual);
        Assert.Equal("Renato", actual.First());
        Assert.Equal("Pedrito", actual.Last());
    }

    [Fact]
    public void TestGetAllUsersUsingMock()
    {
        List<object> users = new List<object>();
        users.Add("Renato");
        users.Add("Pedrito");
        Mock<IUserRepository> mock = new Mock<IUserRepository>();
        mock.Setup(mockUserRepository => mockUserRepository.GetAllUsers()).Returns(users);
        UserService userService = new UserService(mock.Object);
        List<object> actual = userService.GetAllUsers();
        Assert.NotEmpty(actual);
        Assert.Equal("Renato", actual.First());
        Assert.Equal("Pedrito", actual.Last());
    }

    [Fact]
    public void TestInsertUserUsingMock()
    {
        object user = "Renato";
        Mock<IUserRepository> mock = new Mock<IUserRepository>();
        UserService userService = new UserService(mock.Object);
        userService.Insert(user);
        mock.Verify(mockUserRepository => mockUserRepository.Insert("Renato"));
    }




}