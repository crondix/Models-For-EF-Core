namespace BlazorApp1.Interface
{
    public interface IImageService
    {
        Task<string> SaveImageAsync(IFormFile image, string folderPath);
    }
}
