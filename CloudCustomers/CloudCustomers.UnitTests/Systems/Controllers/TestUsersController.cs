using CloudCustomers.API.Controllers;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public void Get_OnSuccess_ReturnsStatusCode200()
    {
        var sut = new UsersController();

        var result = sut.Get();

        result.StatusCode.Should().Be(200);
    }
}
