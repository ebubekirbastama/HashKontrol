using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EBSStringGizlemee
{
    public class hashkontrol
    {
        static WebClient client = new WebClient();
        public static void CalculateFileHash(string filePath, string Hash, string Hash1)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    Hash1 = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                }
            }
            client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            if (Hash1 != client.DownloadString("https://raw.githubusercontent.com/ebubekirbastama/HashKontrol/main/hash").ToUpper().Trim())
            {
                Application.Exit();
            }
            else
            {
                Application.Run(new Form1());
            }

        }
    }
}
