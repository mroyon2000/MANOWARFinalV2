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
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="key"></param>
        /// 
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
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        public void FileDecrypt(string inputFile, string outputFile, string password)
        {
            string fileName = string.Empty;
            string secrateKey = string.Empty;

            try
            {
                clsEncLibrary objEncDec2 = new clsEncLibrary();
                DataTable _data = _db.getScheduleListByDate(DateTime.Now.ToString("yyyy-MM-dd"));
                foreach (DataRow row in _data.Rows)
                {
                    string callerCode = Global.ReceivedCallerID;// Global.personel_fingre_key_no;
                    DateTime truncatedDateTime = DateTime.Now;
                    string frequency = row["SCHEDULE_FREQ"].ToString();
                    secrateKey = row["SCHEDULE_SECRET"].ToString();
                    string filePath = inputFile;// @"C:\CF\sampleFile\Free_Test_Data_100KB_PDF.pdf";
                    //fileName = objEncDec2.FileDeccrypt(filePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}



