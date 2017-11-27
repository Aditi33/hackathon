using System;
using Castle.Core.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Storage.Blob;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Customer.Web.Api.UnitTests
{
    [TestFixture]
    public class CustomerProcessorTests
    {
        private Mock<IBlobUploader> mockblobUploader;
        private ICustomerProcessor customerProcessor;

        [SetUp]
        public void Setup()
        {
            mockblobUploader = new Mock<IBlobUploader>();
            mockblobUploader.Setup(x => x.UploadBlob(It.IsAny<CloudBlockBlob>(), It.IsAny<string>())).Returns("https://as206deunassetrtsdpystor.blob.core.windows.net/customerdata/2-Megha");

            customerProcessor = new CustomerProcessor(mockblobUploader.Object);

        }

        [TestCase(0,"Aditi")]
        [TestCase(1, " ")]
        public void Return_Null_When_Customer_Is_Invalid(int id, string name)
        {
            var customer = new Models.Customer
            {
                Id = id,
                Name = name,
                ContactNumber = "+91-58962347",
                EmailAddress = "aditi@gmail.com"
            };

            var blobPath = customerProcessor.Process(customer);

            NUnit.Framework.Assert.That(blobPath.IsNullOrEmpty());
        }

        [Test]
        public void Return_BlobPath_When_Customer_Is_valid()
        {
            var customer = new Models.Customer
            {
                Id = 1,
                Name = "Aditi",
                ContactNumber = "+91-58962347",
                EmailAddress = "aditi@gmail.com"
            };

            var blobPath = customerProcessor.Process(customer);

            NUnit.Framework.Assert.IsNotEmpty(blobPath);
            mockblobUploader.Verify(x => x.UploadBlob(It.IsAny<CloudBlockBlob>(), It.IsAny<string>()), Times.Once);
        }
    }
}
