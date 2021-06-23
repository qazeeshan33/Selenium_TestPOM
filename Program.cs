using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using VeeDoc_POM.Pages;
using VeeDoc_POM.TestData;

namespace VeeDoc_POM
{
    class Program
    {


        static void Main(string[] args)
        {
            string Username = "zeeshan.hassan@veemed.com";
            string Password = "Yahoogmail5874";
            IWebDriver driver = new ChromeDriver();

            Veedoc_Login login = new Veedoc_Login(driver);
            login.goToPage();

            Data data = new Data();

            Data Getdata=  data.GetPartForTest();
            login.LoginApplication(Username, Password);

            Menu Navigate = new Menu(driver);
            Navigate.Menu_Navigation("OutPatient");

            OutPatientAppoitment_Page OutPt = new OutPatientAppoitment_Page(driver);

            OutPt.AddNew_Appoitment(Getdata);

            string VerifySuccess = OutPt.Get_SuccessfulName;
            VerifySuccess.Contains("Tedst");
            login.Close();







        }
    }
}
