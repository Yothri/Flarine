using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace Flarine.Network.Web
{
    public static class WPDUtil
    {
        public static string Transform(string sMessage, string sType)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.KeySize = 128;
            rijndaelManaged.BlockSize = 128;
            byte[] bytes = Encoding.UTF8.GetBytes("dpdldldptm!@#");
            byte[] array = new byte[16];
            int num = bytes.Length;
            if (num > array.Length)
            {
                num = array.Length;
            }
            Array.Copy(bytes, array, num);
            rijndaelManaged.Key = array;
            rijndaelManaged.IV = array;
            ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
            byte[] array2 = (!sType.Equals("E")) ? rijndaelManaged.CreateDecryptor().TransformFinalBlock(Convert.FromBase64String(sMessage), 0, Convert.FromBase64String(sMessage).Length) : Encoding.UTF8.GetBytes(sMessage);
            return (!sType.Equals("E")) ? Encoding.UTF8.GetString(array2) : Convert.ToBase64String(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
        }

        public static string ZipToBase64(string text)
        {
            UTF8Encoding uniEncode = new UTF8Encoding();
            byte[] bytesToCompress = uniEncode.GetBytes(text);
            string b64 = string.Empty;
            using (var fileToCompress = new MemoryStream())
            {
                using (GZipStream compressionStream = new GZipStream(fileToCompress, CompressionMode.Compress))
                {
                    compressionStream.Write(bytesToCompress, 0, bytesToCompress.Length);
                }
                b64 = Convert.ToBase64String(fileToCompress.ToArray());
            }
            return b64;
        }
    }
}