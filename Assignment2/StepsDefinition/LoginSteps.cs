using Assignment2.PageObjects;
using Assignment2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Assignment2.StepsDefinition
{
    [Binding]
    public class LoginSteps : Hooks
    {
        LoginPage loginPage;

        public LoginSteps()

        {
            LoginPage loginpage;
            loginpage = new LoginPage();
           
        }

       // [Given(@"I navigate to the site")]
       // public void GivenINavigateToTheSite()
        

        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
           loginPage.TypeEmail();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            loginPage.Typepassword();
        }
        
        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
         
        }
    }

    public class Hooks
    {
    }
}
