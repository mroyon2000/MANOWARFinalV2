using ManOWarEncLibrary;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {

            clsEncLibrary objEncDec2 = new clsEncLibrary();
            string originalStr = "Hello wrold";
            string key = "secretIE11bHRpLWVkaXQgaXMgZnVKey";
            
            string callerCode = "CAL01";
            DateTime truncatedDateTime = DateTime.Now;
            string frequency = "FRE0091";
            string secrateKey = "secretKey";

            //Console.WriteLine("Starting encryption process.");

            //var blockByte = objEncDec2.EncryptMaster_v2(callerCode, truncatedDateTime, frequency, secrateKey, originalStr);

            //Console.WriteLine("Time to encrypte: " + DateTime.Now.ToString("HH mm ss"));
            //Console.WriteLine("Starting decryption process.");
            //var decString = objEncDec2.DecryptMaster_v2(blockByte.Item1, blockByte.Item2);
            //Console.WriteLine("Time to decrypte: " + DateTime.Now.ToString("HH mm ss"));



            string filePath = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1.txt";

            objEncDec2.FileEncrypt(filePath, callerCode, truncatedDateTime, frequency, secrateKey);


            string filePath2 = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1_FR#.txt_#RF_SE#136#AT_.m-o-war";

            objEncDec2.FileDeccrypt(filePath2);

            objEncDec2.Dispose();

            Console.Read();
        }
    }
}
