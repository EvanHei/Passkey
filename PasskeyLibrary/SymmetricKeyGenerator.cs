using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary;

/// <summary>
/// Provides functionality to generate cryptographically secure symmetric keys.
/// </summary>
public static class SymmetricKeyGenerator
{
    /// <summary>
    /// Generates a cryptographically secure symmetric key of the specified length.
    /// </summary>
    /// <param name="length">The length of the key in bits. Default is 256 bits.</param>
    /// <returns>A byte array representing the generated symmetric key.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified key length is less than 1.</exception>
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
