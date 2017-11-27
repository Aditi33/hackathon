using System.Net;
using System.Net.Http;
using Microsoft.Ajax.Utilities;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;

namespace Customer.Web.Api
{
    public class BlobUploader : IBlobUploader
    {
        public string UploadBlob(CloudBlockBlob blockBlob,string customerJson)
        {
            if (customerJson == null)
            {
                return null;
            }

            blockBlob.UploadText(customerJson);

            return blockBlob.Uri.AbsoluteUri;
        }
    }
}