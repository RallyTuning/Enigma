namespace Enigma
{
    internal static class Functions
    {

        internal static bool OpenForm(this Panel P, Form F)
        {
            try
            {
                P.SuspendLayout();
                P.Controls.Clear();

                F.TopLevel = false;         // First
                P.Controls.Add(F);         // Then
                F.Dock = DockStyle.Fill;  // Finally
                F.Show();

                P.ResumeLayout();

                return true;
            }
            catch (Exception) { return false; }
        }

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
                return CutPad(Tmp,Length);
            }
            catch { return Array.Empty<byte>(); }
        }

        internal static byte[] CutPad(this byte[] B, int Length)
        {
            try
            {
                if (B.Length == Length)
                    return B;

                byte[] Ret = new byte[Length - 1 + 1];
                Buffer.BlockCopy(B, 0, Ret, 0, Math.Min(B.Length, Length));

                return Ret;
            }
            catch { return Array.Empty<byte>(); }
        }
    }
}
