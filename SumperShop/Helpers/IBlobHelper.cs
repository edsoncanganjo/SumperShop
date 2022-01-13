using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Helpers
{
    public interface IBlobHelper
    {
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName);
        Task<Guid> UploadBlobAsync(byte[] file, string containerName);
        Task<Guid> UploadBlobAsync(string image, string containerName);
    }
}
