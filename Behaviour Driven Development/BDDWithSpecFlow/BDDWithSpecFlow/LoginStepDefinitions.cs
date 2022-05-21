using System;
using TechTalk.SpecFlow;

namespace BDDWithSpecFlow
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"enter Username:")]
        public void GivenEnterUsername(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"Enter Password:")]
        public void GivenEnterPassword(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"when username and password entered Click login button")]
        public void WhenWhenUsernameAndPasswordEnteredClickLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"Check welcome message and assert it")]
        public void ThenCheckWelcomeMessageAndAssertIt()
        {
            throw new PendingStepException();
        }
    }
}
