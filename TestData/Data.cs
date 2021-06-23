using System;
using System.Collections.Generic;
using System.Text;

namespace VeeDoc_POM.TestData
{
    public class Data
    {

        string Username = "zeeshan.hassan@veemed.com";
        string Password = "Yahoogmail5874";


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Email { get; set; }
        public string Reason { get; set; }
        public String PhoneNumber { get; set; }
        public string TaskID { get; set; }



  

    public Data() { }

        //Bele added by KHI
        public Data(String Add_Appointment)
        {
            if (Add_Appointment == "New")
            {
                FirstName = "Asad";
                LastName = "Javed";
                PhoneNumber = "3463911243";
                //  PartLocation = "OFFICE";
                Reason = "Testing";
                Email = "Aasad@gmail.com";

            }


        }

        public Data GetPartForTest()
        {
            Data part = null;
           
                part = new Data("New");
            


            return part;
        }

    }
}
