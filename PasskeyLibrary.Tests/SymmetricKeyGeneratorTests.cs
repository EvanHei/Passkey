using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary.Tests;

public class SymmetricKeyGeneratorTests
{
    [Fact]
    public void GenerateKey_ValidLength_ReturnsKeyOfCorrectLength()
    {
        // Arrange
        int keyLength = 256;

        // Act
        byte[] key = SymmetricKeyGenerator.GenerateKey(keyLength);

        // Assert
        Assert.NotNull(key);
        Assert.Equal(keyLength, key.Length);
    }

    [Fact]
    public void GenerateKey_DefaultLength_ReturnsKeyOfDefaultLength()
    {
        // Act
        byte[] key = SymmetricKeyGenerator.GenerateKey();

        // Assert
        Assert.NotNull(key);
        Assert.Equal(256, key.Length);
    }

    [Fact]
    public void GenerateKey_NegativeLength_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => SymmetricKeyGenerator.GenerateKey(-1));
    }

    [Fact]
    public void GenerateKey_ZeroLength_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => SymmetricKeyGenerator.GenerateKey(0));
    }

    [Fact]
    public void GenerateKey_DifferentCalls_ReturnsUniqueKeys()
    {
        // Act
        byte[] key1 = SymmetricKeyGenerator.GenerateKey(256);
        byte[] key2 = SymmetricKeyGenerator.GenerateKey(256);

        // Assert
        Assert.NotEqual(key1, key2);
    }
}
