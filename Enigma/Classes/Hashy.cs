using System.Security.Cryptography;
using System.Text;

namespace Enigma.Classes
{
    internal class Hashy
    {
        private readonly string TheText;
        private readonly string SelSalt;

        internal Hashy(string Text)
        {
            TheText = Text;
            SelSalt = string.Empty;
        }

        internal Hashy(string Text, string Salt)
        {
            TheText = Text;
            SelSalt = Salt;
        }

        internal string Calc()
        {
            try
            {
                byte[] TextToByte = string.IsNullOrEmpty(SelSalt) ? Encoding.UTF8.GetBytes(TheText) : Encoding.UTF8.GetBytes(SelSalt + TheText);

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
            catch (Exception ex)
            { return ex.Message; }
        }
    }
}
