using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace WebAPI
{
    public static class CarImageManager
    {
        public static CarImage CarImageNamefixer(IFormFile file, CarImage carImage)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string filePath = Environment.CurrentDirectory + @"\wwwroot\carImages\" + Guid.NewGuid() + fileInfo.Extension;

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            carImage.ImagePath = filePath;
            carImage.Date = DateTime.Now;
            return carImage;
        }
    }
}
