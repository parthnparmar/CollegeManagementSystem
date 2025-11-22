using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Utilities
{
    public static class FileHelpers
    {
        public static async Task<string?> SaveFileAsync(IFormFile file, string folderPath)
        {
            if (file == null || file.Length == 0)
                return null;

            Directory.CreateDirectory(folderPath);
            var fileName = $"{Guid.NewGuid()}_{file.FileName}";
            var filePath = Path.Combine(folderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
                await file.CopyToAsync(stream);

            return fileName;
        }

        public static void DeleteFile(string folderPath, string fileName)
        {
            var filePath = Path.Combine(folderPath, fileName);
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
