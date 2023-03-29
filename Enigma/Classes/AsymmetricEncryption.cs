using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal static class AsymmetricEncryption
    {

        internal static RSAParameters PrivateAndPublicKeys, PublicKeyOnly;


        internal static void CreatAsymmetriceKeys()
        {
            try
            {
                using RSA RsaAlg = RSA.Create();

                PrivateAndPublicKeys = RsaAlg.ExportParameters(true);
                PublicKeyOnly = RsaAlg.ExportParameters(false);
            }
            catch (Exception) { throw; }
        }


        internal static byte[] Encrypt(string Message, RSAParameters RsaParameters)
        {
            try
            {
                using RSA RsaAlg = RSA.Create(RsaParameters);
                return RsaAlg.Encrypt(Encoding.UTF8.GetBytes(Message), RSAEncryptionPadding.Pkcs1);
            }
            catch (Exception) { throw; }
        }


        internal static string Decrypt(byte[] CipherText, RSAParameters RsaParameters)
        {
            try
            {
                using RSA RsaAlg = RSA.Create(RsaParameters);
                byte[] DecryptedMessage = RsaAlg.Decrypt(CipherText, RSAEncryptionPadding.Pkcs1);
                return Encoding.UTF8.GetString(DecryptedMessage);
            }
            catch (Exception) { throw; }
        }


    }
}
