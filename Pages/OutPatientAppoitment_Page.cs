
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using VeeDoc_POM.TestData;

namespace VeeDoc_POM.Pages
{
    public class OutPatientAppoitment_Page
    {
        IWebDriver Driver;

        public OutPatientAppoitment_Page Doc;

        public OutPatientAppoitment_Page(IWebDriver driver)
        {

            this.Driver = driver;
        }


        //private IWebElement Out_PatientMenu => Driver.FindElement(By.XPath("//*[@id='navbarSupportedContent']/ul/li[2]"));
        private IWebElement Add_Appointment => Driver.FindElement(By.CssSelector("button[class=btn-vm-icon]"));
        private IWebElement FirstName => Driver.FindElement(By.CssSelector("input[formcontrolname='firstName']"));

        private IWebElement LastName => Driver.FindElement(By.CssSelector("input[formcontrolname='lastName']"));

        private IWebElement Email => Driver.FindElement(By.CssSelector("input[formcontrolname='email']"));

        private IWebElement Reason => Driver.FindElement(By.CssSelector("textarea[formcontrolname='reason']"));

        private IWebElement TimeZone => Driver.FindElement(By.CssSelector("mat-select[formcontrolname='timezone']"));

        private IWebElement Select_Mob_Number => Driver.FindElement(By.ClassName("mat-button-wrapper"));

        private IWebElement Pakistan => Driver.FindElement(By.XPath("//*[@id='mat-menu-panel-0']/div/button[3]/div[2]"));

        private IWebElement Phone_number => Driver.FindElement(By.Id("mat-input-8"));

        private IWebElement Pacific_Select => Driver.FindElement(By.CssSelector("#mat-option-12 > span"));

        private IWebElement Save => Driver.FindElement(By.XPath("//span[contains(text(), 'Create')]"));


        public String Get_SuccessfulName
        {
            get
            {

                String el = Driver.FindElement(By.XPath("//*[@id='container']/table/tr[3]/td[4]")).Text;

                return el;
            }

        }


        public void AddNew_Appoitment(Data data)
        {
            
            Thread.Sleep(2000);

            this.Add_Appointment.Click();
            Thread.Sleep(2000);

            this.FirstName.SendKeys(data.FirstName);
            Thread.Sleep(2000);
            this.LastName.SendKeys(data.LastName);
            Thread.Sleep(2000);
            this.Email.SendKeys(data.Email);
            Thread.Sleep(2000);
            this.Reason.SendKeys(data.Reason);
            Thread.Sleep(2000);
            this.Select_Mob_Number.Click();
            Thread.Sleep(2000);
            this.Pakistan.Click();
            Thread.Sleep(2000);
            this.Phone_number.SendKeys(data.PhoneNumber);
            Thread.Sleep(2000);
            this.TimeZone.Click();
            Thread.Sleep(2000);

            this.Pacific_Select.Click();
            Thread.Sleep(2000);

            this.Save.Click();
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
