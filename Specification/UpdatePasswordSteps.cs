using System;
using TechTalk.SpecFlow;

namespace Specification
{
    [Binding]
    public class UpdatePasswordSteps
    {
        [Given(@"I have launched update password form")]
        public void GivenIHaveLaunchedUpdatePasswordForm()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
