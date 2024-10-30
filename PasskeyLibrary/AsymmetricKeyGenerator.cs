using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary;

/// <summary>
/// Provides methods for generating asymmetric cryptographic key pairs for RSA and ECDSA algorithms.
/// </summary>
public static class AsymmetricKeyGenerator
{
    /// <summary>
    /// Generates an RSA key pair.
    /// </summary>
    /// <returns>A tuple containing the public and private keys as byte arrays.</returns>
    public static (byte[] publicKey, byte[] privateKey) GenerateRsaKeyPair()
    {
        using RSA rsa = RSA.Create();
        byte[] publicKey = rsa.ExportRSAPublicKey();
        byte[] privateKey = rsa.ExportRSAPrivateKey();

        return (publicKey, privateKey);
    }

    /// <summary>
    /// Generates an ECDSA key pair.
    /// </summary>
    /// <returns>A tuple containing the public and private keys as byte arrays.</returns>
    public static (byte[] publicKey, byte[] privateKey) GenerateEcdsaKeyPair()
    {
        using ECDsa ecdsa = ECDsa.Create();

        byte[] publicKey = ecdsa.ExportSubjectPublicKeyInfo();
        byte[] privateKey = ecdsa.ExportPkcs8PrivateKey();

        return (publicKey, privateKey);
    }
}
