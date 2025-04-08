using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace PPT13
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "Pa$$w0rd";
            var salt = "S@lt";
            
            var rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

            var algorithm = new AesManaged();

            var rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            var rgbIV = rgb.GetBytes(algorithm.BlockSize / 8);

            var bufferstream = new FileStream("C:\\Files\\secretdata.txt", FileMode.OpenOrCreate);

            var algo = algorithm.CreateEncryptor(rgbKey, rgbIV);

            var cryptostream = new CryptoStream(bufferstream, algo, CryptoStreamMode.Write);

            byte[] transform = Encoding.Unicode.GetBytes("This is to be encrypted!!");

            cryptostream.Write(transform, 0, transform.Length);
            cryptostream.FlushFinalBlock();

            cryptostream.Close();
            bufferstream.Close();


            Console.WriteLine("Text encrypted");
            
            
            byte[] decryptedbuffer=new byte[100];
            var decalgo = algorithm.CreateDecryptor(rgbKey, rgbIV);
            var filestream = new FileStream("C:\\Files\\secretdata.txt", FileMode.OpenOrCreate);
            
            var cryptostreamnew = new CryptoStream(filestream , decalgo, CryptoStreamMode.Read);
            cryptostreamnew.Read(decryptedbuffer, 0, 100);
            
            string s=Encoding.Unicode.GetString(decryptedbuffer);
            Console.WriteLine(s);

            Console.ReadLine();

// Asymmetric




            var plainText = "hello world...";

            var rawBytes = Encoding.Default.GetBytes(plainText);

            var decryptedText = string.Empty;

            DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
            
           
            using (var rsaProvider = new RSACryptoServiceProvider())
            {

                var useOaepPadding = true;

              
                var encryptedBytes = rsaProvider.Encrypt(rawBytes,useOaepPadding);

                var decryptedBytes = rsaProvider.Decrypt(encryptedBytes,useOaepPadding);
                

                decryptedText = Encoding.Default.GetString(decryptedBytes);

            }

         //  Console.WriteLine("Asymmetric");


         //  Console.WriteLine(decryptedText);

           Console.ReadLine();

            

            
        }
    }
}
