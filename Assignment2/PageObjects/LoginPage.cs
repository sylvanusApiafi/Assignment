using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.PageObjects
{
    class LoginPage
    {
       //driver.FindElement(By .Linktext("Login")
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login;


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;


        [FindsBy(How = How.ClassName, Using = "le- input")]
        private IWebElement passwordElement;

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;

        public void ClickSignin()

        {
            signin.Click();
        }








         public void Typepassword()


        {
           passwordElement.SendKeys("mypasswordissecured ");
        }

        public void TypeEmail()
        {
            emailElement.SendKeys("Apiafi@test.com");

        }


        public void ClickLogin()

        {
           login.Click();

        }


    }


}
