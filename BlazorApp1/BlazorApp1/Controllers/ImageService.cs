using BlazorApp1.Interface;

namespace BlazorApp1.Controller
{
    public class ImageService : IImageService
    {
        public async Task<string> SaveImageAsync(IFormFile image, string folderPath)
        {
            if (image == null || image.Length == 0)
            {
                return null;
            }

            var filePath = Path.Combine(folderPath, image.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return filePath;
        }
    }
}
