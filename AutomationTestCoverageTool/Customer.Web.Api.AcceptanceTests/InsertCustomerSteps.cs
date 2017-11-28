using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Customer.Web.Api.AcceptanceTests.Features.Helpers;
using Microsoft.Data.Edm.Library.Expressions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DataFormat = System.Windows.DataFormat;

namespace Customer.Web.Api.AcceptanceTests
{
    [Binding]
    public class InsertCustomerSteps
    {
        private CustomerData _customerData;

        [Given(@"there is no blob present for this ID")]
        public void GivenThereIsNoBlobPresentForThisID(Table table)
        {
            _customerData = table.CreateInstance<CustomerData>();

            var blobName = string.Format("{0}-{1}", _customerData.Id, _customerData.Name);
            AzureStorageHelper.DeleteJsonFromBlob(blobName);

        }

       

        [When(@"I send customer data to Web API")]
        public void WhenISendCustomerDataToWebAPI(Table table)
        {
            _customerData = table.CreateInstance<CustomerData>();
            SendDataToApi();
        }

        [Then(@"customer blob should be created")]
        public void ThenCustomerBlobShouldBeCreated(Table table)
        {
            _customerData = table.CreateInstance<CustomerData>();

            var blobName = string.Format("{0}-{1}", _customerData.Id, _customerData.Name);
            var blobfound=AzureStorageHelper.VerifyJsonFromBlob(blobName);
            Assert.IsTrue(blobfound);
        }


        public void SendDataToApi()
        {
            const string url = "http://automationtestcoveragetool.cloudapp.net/api/Storage";
                
                var client = new RestClient(url);

            var request = new RestRequest("", Method.POST) { RequestFormat = RestSharp.DataFormat.Json };

            var body=  JsonConvert.SerializeObject(_customerData);

            if (body != null)
            {
                request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
            }

            var response = client.Execute(request);

        }
       

    }
}
