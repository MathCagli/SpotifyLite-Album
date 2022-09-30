using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace SpotifyLiteAlbum.Application
{
    public class AzureBlobStorage
    {
        private readonly IConfiguration configuration;

        public AzureBlobStorage(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public async Task<string> UploadFile(string fileName, Stream buffer, string directory = "")
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(this.configuration["BlobStorageConnection"]);
            BlobContainerClient container = null;

            if (string.IsNullOrWhiteSpace(directory) == false)
            {
                container = blobServiceClient.GetBlobContainerClient($"capas/{directory}");
                await container.UploadBlobAsync(fileName, buffer);
                return $"{this.configuration["BlobStorageBasePath"]}/capas/{directory}/{fileName}";
            }

            container = blobServiceClient.GetBlobContainerClient($"capas");
            await container.UploadBlobAsync(fileName, buffer);

            return $"{this.configuration["BlobStorageBasePath"]}/capas/{fileName}";

        }
    }
}
