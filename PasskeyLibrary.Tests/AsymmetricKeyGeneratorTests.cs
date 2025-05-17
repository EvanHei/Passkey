using System;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace PasskeyLibrary.Tests;

public class AsymmetricKeyGeneratorTests
{
    [Fact]
    public void GenerateRsaKeyPair_ReturnsValidKeyPair()
    {
        // Act
        (string publicPem, string privatePem) = AsymmetricKeyGenerator.GenerateRsaKeyPair();

        // Assert
        Assert.False(string.IsNullOrWhiteSpace(publicPem), "Public key PEM should not be null or empty.");
        Assert.False(string.IsNullOrWhiteSpace(privatePem), "Private key PEM should not be null or empty.");

        byte[] publicBytes = DecodePem(publicPem, "PUBLIC KEY");
        byte[] privateBytes = DecodePem(privatePem, "PRIVATE KEY");

        Assert.NotEmpty(publicBytes);
        Assert.NotEmpty(privateBytes);
    }

    [Fact]
    public void GenerateEcdsaKeyPair_ReturnsValidKeyPair()
    {
        // Act
        (string publicPem, string privatePem) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();

        // Assert
        Assert.False(string.IsNullOrWhiteSpace(publicPem), "Public key PEM should not be null or empty.");
        Assert.False(string.IsNullOrWhiteSpace(privatePem), "Private key PEM should not be null or empty.");

        byte[] publicBytes = DecodePem(publicPem, "PUBLIC KEY");
        byte[] privateBytes = DecodePem(privatePem, "PRIVATE KEY");

        Assert.NotEmpty(publicBytes);
        Assert.NotEmpty(privateBytes);
    }

    [Fact]
    public void GenerateRsaKeyPair_KeysAreDistinct()
    {
        // Act
        var (pub1, priv1) = AsymmetricKeyGenerator.GenerateRsaKeyPair();
        var (pub2, priv2) = AsymmetricKeyGenerator.GenerateRsaKeyPair();

        // Assert
        Assert.NotEqual(pub1, pub2);
        Assert.NotEqual(priv1, priv2);
    }

    [Fact]
    public void GenerateEcdsaKeyPair_KeysAreDistinct()
    {
        // Act
        var (pub1, priv1) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();
        var (pub2, priv2) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();

        // Assert
        Assert.NotEqual(pub1, pub2);
        Assert.NotEqual(priv1, priv2);
    }

    private static byte[] DecodePem(string pem, string section)
    {
        string header = $"-----BEGIN {section}-----";
        string footer = $"-----END {section}-----";

        int start = pem.IndexOf(header) + header.Length;
        int end = pem.IndexOf(footer, start);

        string base64 = pem[start..end].Replace("\n", "").Replace("\r", "").Trim();
        return Convert.FromBase64String(base64);
    }
}
