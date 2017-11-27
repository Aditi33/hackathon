using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Customer.Web.Api
{
    public class BlobContainerProvider 
    {
        public static CloudBlobContainer GetCloudBlobContainer()
        {
            var storageAccountConnectionString = "DefaultEndpointsProtocol=https;AccountName=as206deunassetrtsdpystor;AccountKey=yPrap/1aGuBqUa4osirAp2byceritAGewtHliJluKTlGn/xAAXbaINVvVDakmQWOoe9ShMgRnQuT4YvlSAe0uw==";
            var containerName = "customerdata";

            var storageAccount = CloudStorageAccount.Parse(storageAccountConnectionString);

            var cloudBlobClient = storageAccount.CreateCloudBlobClient();

            var blobContainerName = cloudBlobClient.GetContainerReference(containerName);

            blobContainerName.CreateIfNotExists();

            SetPublicContainerPermissions(blobContainerName);

            return blobContainerName;
        }

        private static void SetPublicContainerPermissions(CloudBlobContainer container)
        {
            var permissions = container.GetPermissions();
            permissions.PublicAccess = BlobContainerPublicAccessType.Container;
            container.SetPermissions(permissions);
        }
    }
}