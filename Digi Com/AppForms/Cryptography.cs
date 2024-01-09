using ManOWarEncLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public class Cryptography
    {
        //Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);


        DB _db = new DB();


        /// <summary>
        /// FileEncrypt a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="secrateKey"></param>
        public string FileEncrypt(string inputFile, string secrateKey)
        {
            try
            {
                string fileName = string.Empty;
                clsEncLibrary objEncDec2 = new clsEncLibrary();
                fileName = objEncDec2.FileEncrypt(inputFile, secrateKey);
                return fileName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// FileDecrypt an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="secrateKey"></param>

        public string  FileDecrypt(string inputFile, string secrateKey)
        {
            string fileName = string.Empty;
            clsEncLibrary objEncDec2 = new clsEncLibrary();
            try
            {
                fileName = objEncDec2.FileDeccrypt(inputFile, secrateKey);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            objEncDec2.Dispose();
            return fileName;
        }




    }
}



