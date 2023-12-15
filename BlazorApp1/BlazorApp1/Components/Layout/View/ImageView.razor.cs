using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using System.IO.Pipelines;
using System.Drawing;

namespace BlazorApp1.Components.Layout.View
{
    public partial class ImageView
    {
       
        private async Task LoadFiles(InputFileChangeEventArgs e)
        {
            isLoading = true;
            loadedFiles.Clear();
            message = string.Empty;

            if (e.FileCount > maxAllowedFiles)
            {
                message = $"Try again with no more than {maxAllowedFiles} files.";
            }
            else
            {
                

                    foreach (var file in e.GetMultipleFiles())
                {
                    var extension = Path.GetExtension(file.Name);
                    var trustedFileNameForFileStorage = $"{Path.GetRandomFileName()}{extension}";
                    var path = Path.Combine(Environment.ContentRootPath,
                            Environment.EnvironmentName, "unsafe_uploads",
                            trustedFileNameForFileStorage);
                    await using FileStream fs = new(path, FileMode.Create);

                    try
                    {
                        await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                        loadedFiles.Add(file);
                    }
                    catch (Exception ex)
                    {
                        fs.Close();
                        File.Delete(path);
                        Logger.LogError("File: {Filename} Error: {Error}",
                            file.Name, ex.Message);
                        message = "Upload error(s). See logs for details.";
                    }
                }
                
                
            }

            isLoading = false;
        }
        //private async Task UploadImage(List<byte[]> ImageBytes)
        //{ 
        //    foreach (var imageByte in ImageBytes)
        //    {
        //        MemoryStream ms = new MemoryStream(imageByte);

        //        Image image = await Task.Run(() => Image.FromStream(ms));
        //        // Важно: Task.Run используется для асинхронного выполнения синхронной операции.

        //        // Пример сохранения в файл (ваш код может отличаться в зависимости от требований):
        //        string filePath = Path.Combine("/images", $"image_{Guid.NewGuid()}.png");
        //        Console.WriteLine($"Image Save path:{filePath}");
        //        image.Save(filePath);

        //    }
        //}
    }
}
