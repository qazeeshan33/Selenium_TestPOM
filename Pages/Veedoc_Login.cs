using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VeeDoc_POM.Pages
{
    public class Veedoc_Login
    {
        IWebDriver Driver;

        public Veedoc_Login Doc;

        public Veedoc_Login(IWebDriver driver)
        {
           
           this.Driver = driver;
        }


        private IWebElement txtUsername => Driver.FindElement(By.CssSelector("input[type='email']"));
        private IWebElement txtPassword => Driver.FindElement(By.CssSelector("input[type='password']"));
        private IWebElement btnLlogin => Driver.FindElement(By.CssSelector("button[type='submit']"));

        public void LoginApplication(string uName, string pword)
        {
            this.txtUsername.SendKeys(uName);
            Thread.Sleep(2000);

            this.txtPassword.SendKeys(pword);
            Thread.Sleep(2000);

            this.btnLlogin.Click();
            Thread.Sleep(2000);
        }

        public void goToPage()
        {
            Driver.Navigate().GoToUrl("https://dev-aws.veemed.com/veedoc/#/login");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
        }

        public void Close()
        {
            Driver.Close();
     
        }
    }
}