using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary.Tests;

public class AsymmetricKeyGeneratorTests
{
    [Fact]
    public void GenerateRsaKeyPair_ReturnsValidKeyPair()
    {
        // Act
        (byte[] publicKey, byte[] privateKey) = AsymmetricKeyGenerator.GenerateRsaKeyPair();

        // Assert
        Assert.NotNull(publicKey);
        Assert.NotNull(privateKey);
        Assert.True(publicKey.Length > 0, "Public key should not be empty.");
        Assert.True(privateKey.Length > 0, "Private key should not be empty.");
    }

    [Fact]
    public void GenerateEcdsaKeyPair_ReturnsValidKeyPair()
    {
        // Act
        (byte[] publicKey, byte[] privateKey) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();

        // Assert
        Assert.NotNull(publicKey);
        Assert.NotNull(privateKey);
        Assert.True(publicKey.Length > 0, "Public key should not be empty.");
        Assert.True(privateKey.Length > 0, "Private key should not be empty.");
    }

    [Fact]
    public void GenerateRsaKeyPair_KeysAreDistinct()
    {
        // Act
        (byte[] publicKey1, byte[] privateKey1) = AsymmetricKeyGenerator.GenerateRsaKeyPair();
        (byte[] publicKey2, byte[] privateKey2) = AsymmetricKeyGenerator.GenerateRsaKeyPair();

        // Assert
        Assert.NotEqual(publicKey1, publicKey2);
        Assert.NotEqual(privateKey1, privateKey2);
    }

    [Fact]
    public void GenerateEcdsaKeyPair_KeysAreDistinct()
    {
        // Act
        (byte[] publicKey1, byte[] privateKey1) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();
        (byte[] publicKey2, byte[] privateKey2) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();

        // Assert
        Assert.NotEqual(publicKey1, publicKey2);
        Assert.NotEqual(privateKey1, privateKey2);
    }
}
