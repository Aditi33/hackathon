using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.RetryPolicies;
using Newtonsoft.Json;

namespace Customer.Web.Api.Controllers
{
    public class StorageController : ApiController
    {
        private readonly ICustomerProcessor customerProcessor;

        public StorageController()
        {
            if (this.customerProcessor == null)
            {
                BlobUploader blobUploader = new BlobUploader();
                customerProcessor = new CustomerProcessor(blobUploader);
            }
        }

        public HttpResponseMessage Post([FromBody] Models.Customer customer)
        {
            var blobPathUrl= customerProcessor.Process(customer);

            if (blobPathUrl == null)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            var response = new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent(string.Format("Blob Path URL:{0}", blobPathUrl))
            };
            return response;
        }
    }
}