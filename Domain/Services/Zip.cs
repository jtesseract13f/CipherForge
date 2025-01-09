using Domain.Interfaces;
using System.IO.Compression;
namespace Domain.Services;

public class Zip : ICipher
{
    public string Name { get; set; } = "ZIP";

    public byte[] Compress(byte[] data)
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
            {
                deflateStream.Write(data, 0, data.Length);
            }
            return memoryStream.ToArray();
        }
    }

    public byte[] Decompress(byte[] data)
    {
        using (MemoryStream memoryStream = new MemoryStream(data))
        {
            using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
            {
                using (MemoryStream decompressedStream = new MemoryStream())
                {
                    deflateStream.CopyTo(decompressedStream);
                    return decompressedStream.ToArray();
                }
            }
        }
    }
}