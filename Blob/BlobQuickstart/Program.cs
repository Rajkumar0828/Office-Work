using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;


string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

var blobServiceClient = new BlobServiceClient(connectionString);

string containerName = "quickstartblobs" + Guid.NewGuid().ToString();


BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);






// Create a local file in the ./data/ directory for uploading and downloading
string localPath = "data";
Directory.CreateDirectory(localPath);

// Specify the path of the file you want to upload
string fileName = "workingfile.txt"; // Replace 'YourFileName.txt' with your actual file name
string localFilePath = Path.Combine(localPath, fileName);

// Get a reference to a blob
BlobClient blobClient = containerClient.GetBlobClient(fileName);

Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

// Upload data from the local file, overwrite the blob if it already exists
await blobClient.UploadAsync(localFilePath, true);

string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOADED.txt");

Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);

// Download the blob's contents and save it to a file
await blobClient.DownloadToAsync(downloadFilePath);


