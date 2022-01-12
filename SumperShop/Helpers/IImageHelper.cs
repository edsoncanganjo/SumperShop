using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SumperShop.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile formFile, string folder);
    }
}
