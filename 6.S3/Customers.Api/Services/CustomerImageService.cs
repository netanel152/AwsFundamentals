using Amazon.S3;
using Amazon.S3.Model;

namespace Customers.Api.Services
{
    public class CustomerImageService : ICustomerImageService
    {
        private readonly IAmazonS3 _s3;
        private readonly string _bucketName = "natkesawssource";
        public CustomerImageService(IAmazonS3 s3)
        {
            _s3 = s3;
        }

        public async Task<PutObjectResponse> UploadIamgeAsync(Guid id, IFormFile file)
        {
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"images/{id}",
                ContentType = file.ContentType,
                InputStream = file.OpenReadStream(),
                Metadata =
                {
                    ["x-amz-meta-originalname"] = file.FileName,
                    ["x-amz-meta-extention"] = Path.GetExtension(file.FileName)
                }
            };

            return await _s3.PutObjectAsync(putObjectRequest);
        }

        public async Task<GetObjectResponse> GetImageAsync(Guid id)
        {
            var getObjectRequest = new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = $"images/{id}"
            };

            return await _s3.GetObjectAsync(getObjectRequest);
        }

        public async Task<DeleteObjectResponse> DeleteImageAsync(Guid id)
        {
            var deleteObjectRequset = new DeleteObjectRequest
            {
                BucketName = _bucketName,
                Key = $"images/{id}"
            };

            return await _s3.DeleteObjectAsync(deleteObjectRequset);
        }

    }
}
