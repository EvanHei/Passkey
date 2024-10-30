using System;
using System.Security.Cryptography;

namespace PasskeyLibrary;

/// <summary>
/// Provides methods for generating a salt and deriving cryptographic keys from a password.
/// </summary>
public static class KeyDeriver
{
    /// <summary>
    /// Generates a random salt value to be used in key derivation.
    /// </summary>
    /// <returns>A 32-byte array containing a cryptographically secure random salt.</returns>
    public static byte[] GenerateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[32];
        rng.GetBytes(salt);
        return salt;
    }

    // TODO: Add more hashing algorithms and iteration options to UI

    /// <summary>
    /// Derives a cryptographic key from the specified password and salt using the PBKDF2 algorithm.
    /// </summary>
    /// <param name="password">The password to derive the key from.</param>
    /// <param name="salt">A salt value to make the derived key more secure. Defaults to an empty byte array if none is provided.</param>
    /// <param name="length">The length of the derived key in bytes. Default is 32 bytes.</param>
    /// <param name="iterations">The number of iterations to apply in the key derivation function. Default is 1000.</param>
    /// <param name="algorithm">The hashing algorithm to use in key derivation. Default is SHA-256.</param>
    /// <returns>A byte array containing the derived cryptographic key of the specified length.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the provided password is null.</exception>
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
