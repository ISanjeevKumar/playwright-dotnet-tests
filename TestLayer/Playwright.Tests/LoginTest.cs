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
        using (App app = new App())
        {
            app.LoginPage.login("", "");
        }
    }
}