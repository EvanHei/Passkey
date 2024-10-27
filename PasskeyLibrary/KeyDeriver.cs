using System;
using System.Security.Cryptography;

namespace PasskeyLibrary;

public static class KeyDeriver
{
    public static byte[] GenerateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[32];
        rng.GetBytes(salt);
        return salt;
    }

    public static byte[] DeriveKey(string password, byte[] salt = default, int length = 32, int iterations = 1000, HashAlgorithmName algorithm = default)
    {
        if (password == null)
            throw new ArgumentNullException("Password cannot be null.");

        if (salt == default)
        {
            salt = new byte[0];
        }

        if (algorithm == default)
        {
            algorithm = HashAlgorithmName.SHA256;
        }

        using Rfc2898DeriveBytes pbkdf2 = new(password, salt, iterations, algorithm);
        return pbkdf2.GetBytes(length);
    }
}
