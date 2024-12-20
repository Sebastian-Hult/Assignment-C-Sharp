namespace Business.Interfaces;

// This interface defines the methods that the FileService class must implement
public interface IFileService
{
    bool SaveContentToFile(string content);
    string GetContentFromFile();
}
