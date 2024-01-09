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



            //string filePath = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1.txt";

            //objEncDec2.FileEncrypt(filePath, callerCode, truncatedDateTime, frequency, secrateKey);


            //string filePath2 = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1_FR#.txt_#RF_SE#136#AT_.m-o-war";

            //objEncDec2.FileDeccrypt(filePath2);


            List<string> originalList = new List<string>
        {
            "a",
            "b",
            "c"
        };
            byte[] byteArray = objEncDec2.ListToByteArray(originalList);

            // Convert byte array to string
            string byteArrayString = objEncDec2.ByteArrayToString(byteArray);

            // Convert string back to byte array
            byte[] reversedByteArray = objEncDec2.StringToByteArray(byteArrayString);

            // Convert byte array back to list
            List<string> reversedList = objEncDec2.ByteArrayToList(reversedByteArray);


            Console.WriteLine("Original List:");
            foreach (var obj in originalList)
            {
                Console.WriteLine($"{obj}");
            }

            Console.WriteLine("\nList after serialization and deserialization:");
            foreach (var obj in reversedList)
            {
                Console.WriteLine($"{obj}");
            }

            objEncDec2.Dispose();

            Console.Read();
        }
    }
}
