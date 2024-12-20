using Business.Interfaces;

namespace Business.Services;

// This class is responsible for reading and writing content to a file
public class FileService : IFileService
{
    // The path to the directory where the file is located or will be created
    private readonly string _directoryPath;

    // The path to the file itself
    private readonly string _filePath;

    // The constructor takes the directory path and the file name as parameters and combines them to create the file path
    public FileService(string directoryPath, string fileName)
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }

    /*  
        -This method reads the content from the file
        -It Ckecks if the file exists. If it does, read its content and return it
        -If the file does not exist, return null 
    */
    public string GetContentFromFile()
    {
        if (File.Exists(_filePath))
            return File.ReadAllText(_filePath);
        
        return null!;
    }

    /*
        -This method saves the content to the file
        -It checks if the directory does not exist, if it doesn't, it creates one
        -Writes the content to the file and returns true to indicate that the operation was successful
    */
    public bool SaveContentToFile(string content)
    {
        
        if (!Directory.Exists(_directoryPath))
            Directory.CreateDirectory(_directoryPath);

        File.WriteAllText(_filePath, content);
        return true;
    }
}
