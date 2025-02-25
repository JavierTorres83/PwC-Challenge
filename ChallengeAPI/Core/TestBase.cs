using ChallengeAPI.Core;
using NUnit.Framework;

public class TestBase
{
    protected ApiClient Api;

    [SetUp]
    public void Setup()
    {
        string baseUrl = "https://restful-booker.herokuapp.com";
        Api = new ApiClient(baseUrl);
    }

    [TearDown]
    public void TearDown()
    {
        Api = null;
    }
}
