using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Customer.Web.Api.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;

namespace Customer.Web.Api
{
    public class CustomerProcessor : ICustomerProcessor
    {
        private IBlobUploader blobUploader;

        public CustomerProcessor(IBlobUploader blobUploader)
        {
            this.blobUploader = blobUploader;
        }

        public string Process(Models.Customer customer)
        {
            CloudBlobContainer blobContainerName = BlobContainerProvider.GetCloudBlobContainer();

            var blobName = GetBlobName(customer);
            if (blobName == null)
            {
                return null;
            }

            var blockBlob = blobContainerName.GetBlockBlobReference(blobName);

            var customerJson = ConvertToJson(customer);

            return blobUploader.UploadBlob(blockBlob, customerJson);
        }

        private static string ConvertToJson(Models.Customer customer)
        {
            var customerJson = JsonConvert.SerializeObject(customer);
            return customerJson;
        }

        private static string GetBlobName(Models.Customer customer)
        {
            if (customer.Id == 0 || customer.Name.IsNullOrWhiteSpace())
            {
                return null;
            }
            var blobName = string.Format("{0}-{1}", customer.Id, customer.Name);
            return blobName;
        }
    }
}