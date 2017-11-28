using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customer.Web.Api.UnitTests;
using TechTalk.SpecFlow;

namespace Customer.Web.Api.AcceptanceTests
{
    [Binding]
    public class CoverageStep: Steps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        CustomerProcessorTests customerProcessorTests = new CustomerProcessorTests();

        [Given(@"InsertCustomerFeature")]
        public void GivenInsertCustomerFeature(Table table)
        {
            Given(@"there is no blob present for this ID", table);
            When(@"I send customer data to Web API", table);
            Then(@"customer blob should be created", table);
        }

        [When(@"Code Coverage Required")]
        public void WhenCodeCoverageRequired()
        {
            customerProcessorTests.Setup();
            customerProcessorTests.Return_BlobPath_When_Customer_Is_valid();
        }

        [Then(@"Execute UnitTestCases")]
        public void ThenExecuteUnitTestCases()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
