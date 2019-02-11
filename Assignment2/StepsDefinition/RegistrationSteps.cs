using Assignment2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Assignment2.StepsDefinition 
{
    [Binding]
    public class RegistrationSteps :Hooks1
    {
        [Given(@"I Navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            driver.Navigate().GoToUrl("http://www.giftrete.com");
        }
        
        [When(@"i Click on registration button")]
        public void WhenIClickOnRegistrationButton()
        {
            loginpage.ClickSignin();
        }
        
        [When(@"I am on the registration page")]
        public void WhenIAmOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill the form")]
        public void WhenIFillTheForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am on the registration page")]
        public void ThenIAmOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
