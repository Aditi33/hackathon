using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Customer.Web.Api
{
    public interface IBlobUploader
    {
        string UploadBlob(CloudBlockBlob blockBlob, string customerJson);
    }
}
