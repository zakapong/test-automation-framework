using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;
using WordpressAutomation.WorkFlows;


namespace WordpressTests
{
    public class WordpressTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            PostCreator.Initialize();

            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("Qazwsx!24").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
           PostCreator.Cleanup();
            Driver.Close();
        }
    }
}
