using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Text;

namespace AutomationPractice
{
    [TestClass]
    public class CorePage
    {
        public static GlobalEnv pGlobalEnv = new GlobalEnv();



        private const string tbSearchBox = "//input[@name='search_query']";

        private const string tbheader = "//a [@title='Contact Us']";

        private const string tbSignIn = "//a[@class='login']";

        private const string tbWomen = "//a[@title='Women']";

        private const string tbDresses = "//a[@title='Dresses']";

        private const string tbT_shirts = "//a[@title='T-shirts']";

        private const string tbCart = "//a[@title='View my shopping cart']";

        private const string tbIcon_phone = "//i[@class='icon-phone']";

        private const string tbUper_image = "//img[@class='img-responsive']";

        private const string tbYour_Logo = "//img[@class='logo img-responsive']";

        private const string newsletter_input = "//input[@id='newsletter-input']";


        public Boolean bType_SearchBox(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbSearchBox);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;
        }

        public Boolean bType_header(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbheader);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_SignIn(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbSignIn);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_Women(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbWomen);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_Dresses(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbDresses);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_T_Shirts(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbT_shirts);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_Cart(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbCart);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_IconPhone(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbIcon_phone);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_Uperimage(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbUper_image);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_YourLogo(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", tbYour_Logo);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

        public Boolean bType_NewsletterInput(string strText)
        {



            IWebElement webElement = pGlobalEnv.weFind_Element("xpath", newsletter_input);
            //object p = pGlobalEnv.utils.bType_Text(webElement, strText);
            return true;

        }

    }
}