using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    public class FormDetails
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }


    public class BusinessDetails
    {
        

        public static string BusinessName { get; set; }
        public  static string CompanyRegNo { get; set; }
        public string CompanyTurnover { get; set; }
        public string NumberofEmployees { get; set; }
    }

    }




