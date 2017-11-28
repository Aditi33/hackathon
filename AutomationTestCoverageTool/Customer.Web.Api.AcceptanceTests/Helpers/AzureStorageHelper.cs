using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using TechTalk.SpecFlow.Plugins;


namespace Customer.Web.Api.AcceptanceTests.Features.Helpers
{
    public class AzureStorageHelper
    {
        private static CloudBlobContainer GetBlobContainer()
        {
            var blobContainerName = CloudConfigurationManager.GetSetting("BlobContainerName");

            var storageAccountConnectionString =
                CloudConfigurationManager.GetSetting("StorageAccountForBlob");

            var storageAccount = CloudStorageAccount.Parse(storageAccountConnectionString);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(blobContainerName);

            container.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            return container;
        }

        public static void DeleteJsonFromBlob(string blobName)
        {
            var container = GetBlobContainer();
            foreach (var blob in container.ListBlobs().OfType<CloudBlockBlob>().Where(blob => blob.Name.Contains(blobName)))
            {
                blob.DeleteIfExists();
            }
        }

        public static bool VerifyJsonFromBlob(string blobName)
        {
            var container = GetBlobContainer();
            var jsonFound = false;

            foreach (
                var blob in
                container.ListBlobs()
                    .OfType<CloudBlockBlob>())
            {
                if (blob.Name.Contains(blobName))
                {
                    jsonFound = true;
                    break;
                }
            }
            return jsonFound;
        }

    }
}