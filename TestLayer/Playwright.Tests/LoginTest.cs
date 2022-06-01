using Playwright.Page.Objects;

namespace Playwright.Tests;

public class LoginTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldBeAbleToLogin()
    {
        App app = new App();
        Assert.Pass();
    }
}