using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal static class AsymmetricEncryption
    {

        internal static int KeyBitSize = 2048;

        internal static class For_Encrypt
        {
            internal static RSA RsaAlg_Encrypt = RSA.Create(KeyBitSize);

            internal static byte[] Encrypt(string Message)
            {
                try
                {
                    RsaAlg_Encrypt.KeySize = KeyBitSize; // Set the key size in case is changed

                    return RsaAlg_Encrypt.Encrypt(Encoding.UTF8.GetBytes(Message), RSAEncryptionPadding.Pkcs1);
                }
                catch (Exception) { throw; }
            }


            internal static void ImportKeys(string Data)
            {
                try
                {
                    RsaAlg_Encrypt.ImportFromPem(Data);
                }
                catch (Exception) { throw; }
            }
        }



        internal static class For_Decrypt
        {
            internal static RSA RsaAlg_Decrypt = RSA.Create(KeyBitSize);
            internal static RSAParameters PrivateAndPublicKeys, PublicKeyOnly;


            internal static string Decrypt(byte[] CipherText)
            {
                try
                {
                    RsaAlg_Decrypt.KeySize = KeyBitSize; // Set the key size in case is changed

                    byte[] DecryptedMessage = RsaAlg_Decrypt.Decrypt(CipherText, RSAEncryptionPadding.Pkcs1);
                    return Encoding.UTF8.GetString(DecryptedMessage);
                }
                catch (Exception) { throw; }
            }


            internal static void CreatAsymmetriceKeys()
            {
                try
                {
                    RsaAlg_Decrypt = RSA.Create(KeyBitSize);
                    PrivateAndPublicKeys = RsaAlg_Decrypt.ExportParameters(true);
                    PublicKeyOnly = RsaAlg_Decrypt.ExportParameters(false);
                }
                catch (Exception) { throw; }
            }


            internal static string ExportPublicKey()
            {
                try
                {
                    byte[] spkiDer = RsaAlg_Decrypt.ExportSubjectPublicKeyInfo();

                    return new(PemEncoding.Write("PUBLIC KEY", spkiDer)); // as of .NET 7: ExportSubjectPublicKeyInfoPem;
                }
                catch (Exception) { throw; }
            }


            internal static string ExportPrivateKey()
            {
                try
                {
                    byte[] pkcs8Der = RsaAlg_Decrypt.ExportPkcs8PrivateKey();

                    return new(PemEncoding.Write("PRIVATE KEY", pkcs8Der)); // as of .NET 7: ExportPkcs8PrivateKeyPem;
                }
                catch (Exception) { throw; }
            }
        }


        internal static class Signature
        {
            internal static byte[] Sign(string Message, RSA RsaAlg)
            {
                try
                {
                    return RsaAlg.SignData(Encoding.UTF8.GetBytes(Message), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                }
                catch (Exception) { throw; }
            }


            internal static bool Verify(string Message, byte[] Signature, RSA RsaAlg)
            {
                try
                {
                    return RsaAlg.VerifyData(Encoding.UTF8.GetBytes(Message), Signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                }
                catch (Exception) { throw; }
            }
        }

    }
}
