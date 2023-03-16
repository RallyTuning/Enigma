using System.Security.Cryptography;
using System.Text;

namespace Enigma
{
    internal class Hashy
    {
        private readonly byte[] TheBytes = Array.Empty<byte>();
        private readonly string TheText = string.Empty;
        private readonly string TheSalt = string.Empty;

        internal Hashy(string Text, string Salt)
        {
            TheText = Text;
            TheSalt = Salt;
        }

        internal Hashy(byte[] Bytes, string Salt)
        {
            TheBytes = Bytes;
            TheSalt = Salt;
        }

        internal string Calc()
        {
            try
            {
                byte[] TextToByte;

                if (TheBytes == Array.Empty<byte>())
                {
                    TextToByte = string.IsNullOrEmpty(TheSalt) ? Encoding.UTF8.GetBytes(TheText) : Encoding.UTF8.GetBytes(TheSalt + TheText);
                }
                else
                {
                    TextToByte = TheBytes;
                }

                byte[] TempBytesMD5 = MD5.Create().ComputeHash(TextToByte);
                byte[] TempBytesSHA1 = SHA1.Create().ComputeHash(TextToByte);
                byte[] TempBytesSHA256 = SHA256.Create().ComputeHash(TextToByte);
                byte[] TempBytesSHA384 = SHA384.Create().ComputeHash(TextToByte);
                byte[] TempBytesSHA512 = SHA512.Create().ComputeHash(TextToByte);

                StringBuilder SB = new();

                SB.AppendLine("# MD5");
                SB.AppendLine($"HEX:      {TempBytesMD5.ToHex()}");
                SB.AppendLine($"BASE64:   {TempBytesMD5.ToBase64()}");
                //SB.AppendLine($"STRING:   {TempBytesMD5.ToRString()}");
                SB.AppendLine();

                SB.AppendLine("# SHA1");
                SB.AppendLine($"HEX:      {TempBytesSHA1.ToHex()}");
                SB.AppendLine($"BASE64:   {TempBytesSHA1.ToBase64()}");
                //SB.AppendLine($"STRING:   {TempBytesSHA1.ToRString()}");
                SB.AppendLine();

                SB.AppendLine("# SHA256");
                SB.AppendLine($"HEX:      {TempBytesSHA256.ToHex()}");
                SB.AppendLine($"BASE64:   {TempBytesSHA256.ToBase64()}");
                //SB.AppendLine($"STRING:   {TempBytesSHA256.ToRString()}");
                SB.AppendLine();

                SB.AppendLine("# SHA384");
                SB.AppendLine($"HEX:      {TempBytesSHA384.ToHex()}");
                SB.AppendLine($"BASE64:   {TempBytesSHA384.ToBase64()}");
                //SB.AppendLine($"STRING:   {TempBytesSHA384.ToRString()}");
                SB.AppendLine();

                SB.AppendLine("# SHA512");
                SB.AppendLine($"HEX:      {TempBytesSHA512.ToHex()}");
                SB.AppendLine($"BASE64:   {TempBytesSHA512.ToBase64()}");
                //SB.AppendLine($"STRING:   {TempBytesSHA512.ToRString()}");

                return SB.ToString();
            }
            catch (Exception) { throw; }
        }
    }
}
