using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary.Tests;

public class KeyDeriverTests
{
    [Fact]
    public void GenerateSalt_ReturnsValidSalt()
    {
        // Arrange (no setup needed)

        // Act
        byte[] salt = KeyDeriver.GenerateSalt();

        // Assert
        Assert.NotNull(salt);
        Assert.Equal(32, salt.Length);
    }

    [Fact]
    public void DeriveKey_ValidInput_ReturnsDerivedKey()
    {
        // Arrange
        string password = "SecurePassword123";
        byte[] salt = KeyDeriver.GenerateSalt();
        int keyLength = 32;

        // Act
        byte[] derivedKey = KeyDeriver.DeriveKey(password, salt, keyLength);

        // Assert
        Assert.NotNull(derivedKey);
        Assert.Equal(keyLength, derivedKey.Length);
    }

    [Fact]
    public void DeriveKey_NullPassword_ThrowsArgumentNullException()
    {
        // Arrange
        byte[] salt = KeyDeriver.GenerateSalt();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => KeyDeriver.DeriveKey(null, salt));
    }

    [Fact]
    public void DeriveKey_DefaultSaltAndAlgorithm_ReturnsDerivedKey()
    {
        // Arrange
        string password = "SecurePassword123";
        int keyLength = 32;

        // Act
        byte[] derivedKey = KeyDeriver.DeriveKey(password, length: keyLength);

        // Assert
        Assert.NotNull(derivedKey);
        Assert.Equal(keyLength, derivedKey.Length);
    }

    [Fact]
    public void DeriveKey_EmptySalt_ReturnsDerivedKey()
    {
        // Arrange
        string password = "SecurePassword123";
        byte[] salt = new byte[0];
        int keyLength = 32;

        // Act
        byte[] derivedKey = KeyDeriver.DeriveKey(password, salt, keyLength);

        // Assert
        Assert.NotNull(derivedKey);
        Assert.Equal(keyLength, derivedKey.Length);
    }
}
