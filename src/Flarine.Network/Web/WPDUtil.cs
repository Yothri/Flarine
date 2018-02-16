using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebCommon;

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

        public static string UnZipFromBase64(string Compressedvalue)
        {
            byte[] buffer = Convert.FromBase64String(Compressedvalue);
            MemoryStream memoryStream = new MemoryStream(buffer);
            Stream stream = memoryStream;
            if (stream == null)
            {
                throw new ArgumentException();
            }
            if (!stream.CanRead)
            {
                throw new ArgumentException();
            }
            MemoryStream memoryStream2 = new MemoryStream();
            using (GZipStream gzipStream = new GZipStream(stream, CompressionMode.Decompress))
            {
                byte[] buffer2 = new byte[31457280];
                int num;
                do
                {
                    num = gzipStream.Read(buffer2, 0, 31457280);
                }
                while (num == 31457280);
                memoryStream2.Write(buffer2, 0, num);
            }
            byte[] bytes = memoryStream2.ToArray();
            memoryStream.Close();
            memoryStream.Dispose();
            stream.Close();
            stream.Dispose();
            memoryStream2.Close();
            memoryStream2.Dispose();
            return Encoding.UTF8.GetString(bytes);
        }
    }
}