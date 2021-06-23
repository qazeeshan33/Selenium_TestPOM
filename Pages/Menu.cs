using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VeeDoc_POM.Pages
{
    class Menu
    {


        IWebDriver Driver;

        public Veedoc_Login Doc;

        public Menu(IWebDriver driver)
        {

            this.Driver = driver;
        }


        private IWebElement Out_PatientMenu => Driver.FindElement(By.ClassName("icon_vm_outpatient"));
        


        public void Menu_Navigation(string MenuName)
        {
            if (MenuName == "OutPatient")
            {
                this.Out_PatientMenu.Click();
                Thread.Sleep(2000);
            }
            
        }
    }
}
