using System.Text;
using Domain.Services;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void TestCaesar()
    {
        var Caesar = new CaesarCipher(255);
        var str = "For HEAVY METAL we will die";
        byte[] data = Encoding.ASCII.GetBytes(str);
        var encrypted = Caesar.Encrypt(data);
        var decrypted = Caesar.Decrypt(encrypted);
        Assert.Equal(str, Encoding.ASCII.GetString(decrypted));
    }
    [Fact]
    public void TestZip()
    {
        var zip = new Zip();
        var str = "glory hammer";
        byte[] data = Encoding.ASCII.GetBytes(str);
        var compressed = zip.Compress(data);
        var decompressed = zip.Decompress(compressed);
        Assert.Equal(data, decompressed);
        Assert.Equal(str, Encoding.ASCII.GetString(decompressed));
    }
}