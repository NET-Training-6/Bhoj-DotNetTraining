namespace WokrforceManagement.Web.Helpers;

public static class IFormFileExtensions
{
    public static string SaveImage( this IFormFile profileImage)
    {
        var fileName = profileImage.FileName;
        var uniqueFileName = $"{Guid.NewGuid()}_{fileName}"; 
        var relativePath = $"/images/profiles/{uniqueFileName}";
        var currentAppPath = Directory.GetCurrentDirectory();
        var fullFilePath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

        using var stream = File.Create(fullFilePath);
        profileImage.CopyTo(stream);

        return relativePath;
    }
}
