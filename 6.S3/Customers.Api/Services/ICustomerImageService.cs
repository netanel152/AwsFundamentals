using Amazon.S3.Model;

namespace Customers.Api.Services
{
    public interface ICustomerImageService
    {
        Task<PutObjectResponse> UploadIamgeAsync(Guid id, IFormFile file);

        Task<GetObjectResponse> GetImageAsync(Guid id);

        Task<DeleteObjectResponse> DeleteImageAsync(Guid id);
    }
}
