using Domain.Interfaces;

namespace Domain.Services;

public class CaesarCipher(byte key) : ICipher
{
    public string Name { get; set; } = "Цезарь";
    byte Key { get; set; } = key;

    public byte[] Encrypt(byte[] data)
    {
        byte[] result = new byte[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            result[i] = (byte)((data[i] + Key)%256);
        }
        return result;
    }

    public byte[] Decrypt(byte[] data)
    {
        byte[] result = new byte[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            result[i] = (byte)((data[i] + ~Key + 1)%256);
        }
        return result;
    }
}