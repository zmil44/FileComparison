/*Zachary Miller
 * 01/16/2018
 * assignment 9.3
 * The purpose of this program is to determine the size of two files and compare their ratio to each other
 * FileComparison.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileComparison
{
    class FileComparison
    {
        static void Main(string[] args)
        {
            const string TXT_FILE = "Quotation.txt";
            const string WORD_FILE = "Quotation.docx";

            FileInfo file1 = new FileInfo(TXT_FILE);
            long txtLength = file1.Length;

            FileInfo file2 = new FileInfo(WORD_FILE);
            long wordLength = file2.Length;

            double ratioTxtToDoc = ((double)txtLength / wordLength);
            int ratioDocToTxt = ((int)wordLength / (int)txtLength);
            Display(TXT_FILE, WORD_FILE, txtLength, wordLength, ratioDocToTxt, ratioTxtToDoc);
        }

        public static void Display(string TXT_FILE, string WORD_FILE, long txtLength,long wordLength,int ratioDocToText, double ratioTxtToDoc)
        {
            Console.WriteLine("File Name: {0} Size: {1}", TXT_FILE, txtLength);
            Console.WriteLine("File Name: {0} Size: {1}", WORD_FILE, wordLength);
            Console.WriteLine("Text to Word Ratio: {0}", ratioTxtToDoc);
            Console.WriteLine("Word to Text Ratio: {0}", ratioDocToText);
            Console.ReadLine();
        }
    }
}
