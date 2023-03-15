using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal class SymmetricEncryption
    {

        //internal static void SymmetricEncryptionDemo()
        //{
        //    Console.WriteLine("***** Symmetric encryption demo *****");

        //    var unencryptedMessage = "To be or not to be, that is the question, whether tis nobler in the...";
        //    Console.WriteLine("Unencrypted message: " + unencryptedMessage);

        //    // 1. Create a key (shared key between sender and reciever).
        //    byte[] key, iv;
        //    using (Aes aesAlg = Aes.Create())
        //    {
        //        key = aesAlg.Key;
        //        iv = aesAlg.IV;
        //    }

        //    // 2. Sender: Encrypt message using key
        //    byte[] encryptedMessage = Encrypt(unencryptedMessage, "", "");
        //    Console.WriteLine("Sending encrypted message: " + Convert.ToHexString(encryptedMessage));

        //    // 3. Receiver: Decrypt message using same key
        //    string decryptedMessage = Decrypt(encryptedMessage, "", "");
        //    Console.WriteLine("Recieved and decrypted message: " + decryptedMessage);

        //    Console.Write(Environment.NewLine);
        //}



        internal byte[] Encrypt(string Message, string Key, string IV)
        {
            try
            {
                byte[] key2, iv2;
                using (Aes aesAlg2 = Aes.Create())
                {
                    key2 = aesAlg2.Key;
                    iv2 = aesAlg2.IV;
                }





                using Aes AesAlg = Aes.Create();
                AesAlg.Key = Encoding.UTF8.GetBytes("12345678901234561234567890123456");// Encoding.UTF8.GetBytes(Key).CutPad(32);
                AesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456");//Encoding.UTF8.GetBytes(IV).CutPad(16);

                ICryptoTransform Encryptor = AesAlg.CreateEncryptor(AesAlg.Key, AesAlg.IV);

                using MemoryStream MS = new();
                using CryptoStream CS = new(MS, Encryptor, CryptoStreamMode.Write);
                using (StreamWriter SW = new(CS))
                {
                    SW.Write(Message);
                }

                return MS.ToArray();
            }
            catch (Exception) { throw; }
        }

        internal string Decrypt(string CipherText, string Key, string IV)
        {
            try
            {
                return Decrypt(Encoding.UTF8.GetBytes(CipherText), Key, IV);
            }
            catch (Exception) { throw; }
        }

        internal string Decrypt(byte[] ChiperBytes, string Key, string IV)
        {
            try
            {
                using Aes AesAlg = Aes.Create();
                AesAlg.Key = Encoding.UTF8.GetBytes("12345678901234561234567890123456");//Encoding.UTF8.GetBytes(Key).CutPad(32);
                AesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456");//Encoding.UTF8.GetBytes(IV).CutPad(16);

                ICryptoTransform Decryptor = AesAlg.CreateDecryptor(AesAlg.Key, AesAlg.IV);

                using MemoryStream MS = new(ChiperBytes);
                using CryptoStream CS = new(MS, Decryptor, CryptoStreamMode.Read);
                using StreamReader SR = new(CS);

                return SR.ReadToEnd();
            }
            catch (Exception) { throw; }
        }
    }
}
