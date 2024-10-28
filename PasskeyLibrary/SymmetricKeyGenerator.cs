using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary;

public static class SymmetricKeyGenerator
{
    public static byte[] GenerateKey(int length = 256)
    {
        if (length < 1)
            throw new ArgumentException("Key length must be greater than 0.", nameof(length));

        byte[] key = new byte[length];
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        rng.GetBytes(key);

        return key;
    }
}
