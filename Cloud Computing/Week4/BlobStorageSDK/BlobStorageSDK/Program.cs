using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;

namespace BlobStorageSDK
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("List all blobs in a container using .NET SDK");

            string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

            BlobContainerClient container = new BlobContainerClient(connectionString, "pictures");
            await foreach (BlobItem blob in container.GetBlobsAsync())
            {
                Console.WriteLine($"{blob.Name}");
            }
          
            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}
