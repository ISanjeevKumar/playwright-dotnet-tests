using System;
using Microsoft.Playwright;

namespace Playwright.Page.Objects
{
    public class App : IDisposable
    {
        private LoginPage _loginPage;

        public LoginPage LoginPage
        {
            get
            {
                return _loginPage
                    ?? (_loginPage = new LoginPage());
            }
        }
        public App()
        {

        }

        public void Dispose()
        {

        }
    }
}
