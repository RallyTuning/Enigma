using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal class AsymmetricEncryption
    {

        //            Console.WriteLine("***** Asymmetric encryption demo *****");

        //            var unencryptedMessage = "To be or not to be, that is the question, whether tis nobler in the...";
        //            Console.WriteLine("Unencrypted message: " + unencryptedMessage);

        //            // 1. Create a public / private key pair.
        //            RSAParameters privateAndPublicKeys, publicKeyOnly;
        //            using (var rsaAlg = RSA.Create())
        //            {
        //                privateAndPublicKeys = rsaAlg.ExportParameters(includePrivateParameters: true);
        //                publicKeyOnly = rsaAlg.ExportParameters(includePrivateParameters: false);
        //            }

        //             // 2. Sender: Encrypt message using public key
        //              var encryptedMessage = AsymmetricEncryption.Encrypt(unencryptedMessage, publicKeyOnly);
        //              Console.WriteLine("Sending encrypted message: " + encryptedMessage.ToHex());

        //           // 3. Receiver: Decrypt message using private key
        //           var decryptedMessage = AsymmetricEncryption.Decrypt(encryptedMessage, privateAndPublicKeys);
        //          Console.WriteLine("Recieved and decrypted message: " + decryptedMessage);

        //          Console.Write(Environment.NewLine);




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
