using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyLibrary;

public static class AsymmetricKeyGenerator
{
    public static (byte[] publicKey, byte[] privateKey) GenerateRsaKeyPair()
    {
        using RSA rsa = RSA.Create();
        byte[] publicKey = rsa.ExportRSAPublicKey();
        byte[] privateKey = rsa.ExportRSAPrivateKey();

        return (publicKey, privateKey);
    }

    public static (byte[] publicKey, byte[] privateKey) GenerateEcdsaKeyPair()
    {
        using ECDsa ecdsa = ECDsa.Create();

        byte[] publicKey = ecdsa.ExportSubjectPublicKeyInfo();
        byte[] privateKey = ecdsa.ExportPkcs8PrivateKey();

        return (publicKey, privateKey);
    }
}
