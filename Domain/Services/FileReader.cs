using Domain.Interfaces;

namespace Domain.Services;

public class FileReader: ICipher
{
    public string Name { get; set; } = "File reader";

    public byte[] ReadFile(string filePath)
    {
        return File.ReadAllBytes(filePath);
    }
}