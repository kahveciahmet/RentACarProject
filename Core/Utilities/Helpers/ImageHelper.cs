using Microsoft.AspNetCore.Http;

namespace Core.Utilities
{
    public static class ImageHelper
    {
        public static string AddImage(IFormFile file, string folderName)
        {
            if (file == null || file.Length == 0)
                throw new Exception("Dosya bulunamadı.");

            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", folderName);

            if (Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            string filePath = Path.Combine(uploadPath, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return uniqueFileName;
        }

        public static string DeleteImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                return imagePath;
            }
            return imagePath;

        }
    }
}
