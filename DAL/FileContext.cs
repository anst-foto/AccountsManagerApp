namespace AccountsManagerApp.DAL;

public abstract class FileContext
{
    protected readonly string Path;

    protected FileContext(string path)
    {
        if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentNullException(nameof(path));
        }

        if (!File.Exists(path))
        {
            throw new ArgumentException(nameof(path));
        }
        
        Path = path;
    }
}