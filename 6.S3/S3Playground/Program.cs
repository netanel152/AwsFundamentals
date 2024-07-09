
using Amazon.S3;
using Amazon.S3.Model;
using System.Text;

var s3Client = new AmazonS3Client();

/*
 * Upload file / image to S3 bucket
await using var inputStream = new FileStream("./movies.csv", FileMode.Open, FileAccess.Read);

var putObjRequest = new PutObjectRequest
{
    BucketName = "natkesawssource",
    Key = "files/movies.csv",
    ContentType = "text/csv",
    InputStream = inputStream
};

await s3Client.PutObjectAsync(putObjRequest);
*/


/*
 * Get data from csv file from S3 bucket 
var getObjectRequest = new GetObjectRequest
{
    BucketName = "natkesawssource",
    Key = "files/movies.csv"
};

var response = await s3Client.GetObjectAsync(getObjectRequest);

using var memoryStream = new MemoryStream();
response.ResponseStream.CopyTo(memoryStream);

var text = Encoding.Default.GetString(memoryStream.ToArray());

Console.WriteLine(text);
*/