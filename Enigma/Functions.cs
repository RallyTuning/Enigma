using System.Text;

namespace Enigma
{
    internal static class Functions
    {

        internal static string ToHex(this byte[] Bytes)
        {
            try
            { return Convert.ToHexString(Bytes); }
            catch (Exception)
            { return "// Error //"; }
        }

        internal static string ToBase64(this byte[] Bytes)
        {
            try
            { return Convert.ToBase64String(Bytes); }
            catch (Exception)
            { return "// Error //"; }
        }

        internal static string ToBinary(this byte[] Bytes)
        {
            try
            { return string.Join(" ", Bytes.Reverse().Select(x => Convert.ToString(x, 2).PadLeft(8, '0'))); }
            catch (Exception)
            { return "// Error //"; }
        }

        internal static string ToRString(this byte[] Bytes)
        {
            try
            { return System.Text.Encoding.UTF8.GetString(Bytes); }
            catch (Exception)
            { return "// Error //"; }
        }

        internal static byte[] CutPad(this string Str, int Length)
        {
            try
            {
                byte[] Tmp = System.Text.Encoding.UTF8.GetBytes(Str);
                return CutPad(Tmp, Length);
            }
            catch { return Array.Empty<byte>(); }
        }

        internal static byte[] MergeByte(this byte[] B, byte[] Merge)
        {
            try
            {
                Buffer.BlockCopy(B, 0, Merge, 0, Math.Min(B.Length, Merge.Length));

                return Merge;
            }
            catch { return Array.Empty<byte>(); }
        }

        internal static byte[] CutPad(this byte[] B, int Length)
        {
            try
            {
                if (B.Length == Length)
                    return B;

                byte[] Ret = new byte[Length];
                Buffer.BlockCopy(B, 0, Ret, 0, Math.Min(B.Length, Length));

                return Ret;
            }
            catch { return Array.Empty<byte>(); }
        }

        internal async static Task SaveFile(string FileName, string Data)
        {
            try
            {
                using FileStream FS = new(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan);
                FS.SetLength(0);

                using StreamWriter SW = new(FS, Encoding.UTF8);
                await SW.WriteAsync(Data);
            }
            catch { throw; }
        }

        internal async static Task<string> ImportFile(string FileName)
        {
            try
            {
                using FileStream FS = new(FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan);
                using StreamReader SR = new(FS);
                return await SR.ReadToEndAsync();
            }
            catch { throw; }
        }
    }
}
