using System;
using System.Security.Cryptography;
using System.Text;

namespace PasskeyLibrary;

/// <summary>
/// Provides methods for generating asymmetric cryptographic key pairs for RSA and ECDSA algorithms.
/// </summary>
public static class AsymmetricKeyGenerator
{
    /// <summary>
    /// Generates an RSA key pair in PEM format.
    /// </summary>
    /// <returns>A tuple containing the public and private keys as PEM-formatted strings.</returns>
    public static (string publicKeyPem, string privateKeyPem) GenerateRsaKeyPair()
    {
        using RSA rsa = RSA.Create(2048);

        byte[] publicKey = rsa.ExportSubjectPublicKeyInfo();
        byte[] privateKey = rsa.ExportPkcs8PrivateKey();

        string publicPem = $"-----BEGIN PUBLIC KEY-----\n{Convert.ToBase64String(publicKey, Base64FormattingOptions.InsertLineBreaks)}\n-----END PUBLIC KEY-----";
        string privatePem = $"-----BEGIN PRIVATE KEY-----\n{Convert.ToBase64String(privateKey, Base64FormattingOptions.InsertLineBreaks)}\n-----END PRIVATE KEY-----";

        return (publicPem, privatePem);
    }

    /// <summary>
    /// Generates an ECDSA key pair in PEM format.
    /// </summary>
    /// <returns>A tuple containing the public and private keys as PEM-formatted strings.</returns>
    public static (string publicKeyPem, string privateKeyPem) GenerateEcdsaKeyPair()
    {
        using ECDsa ecdsa = ECDsa.Create(ECCurve.NamedCurves.nistP256);

        byte[] publicKey = ecdsa.ExportSubjectPublicKeyInfo();
        byte[] privateKey = ecdsa.ExportPkcs8PrivateKey();

        string publicPem = $"-----BEGIN PUBLIC KEY-----\n{Convert.ToBase64String(publicKey, Base64FormattingOptions.InsertLineBreaks)}\n-----END PUBLIC KEY-----";
        string privatePem = $"-----BEGIN PRIVATE KEY-----\n{Convert.ToBase64String(privateKey, Base64FormattingOptions.InsertLineBreaks)}\n-----END PRIVATE KEY-----";

        return (publicPem, privatePem);
    }
}
