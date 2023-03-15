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
    }
}
