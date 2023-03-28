using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal class SymmetricEncryption
    {

        internal static byte[] Encrypt(string Message, string Key, string IV)
        {
            try
            {
                using Aes AesAlg = Aes.Create();
                AesAlg.Key = Encoding.UTF8.GetBytes(Key).CutPad(32);
                AesAlg.IV = Encoding.UTF8.GetBytes(IV).CutPad(16);

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


        internal static string Decrypt(string CipherText, string Key, string IV)
        {
            try
            {
                return Decrypt(Encoding.UTF8.GetBytes(CipherText), Key, IV);
            }
            catch (Exception) { throw; }
        }


        internal static string Decrypt(byte[] ChiperBytes, string Key, string IV)
        {
            try
            {
                using Aes AesAlg = Aes.Create();
                AesAlg.Key = Encoding.UTF8.GetBytes(Key).CutPad(32);
                AesAlg.IV = Encoding.UTF8.GetBytes(IV).CutPad(16);

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
