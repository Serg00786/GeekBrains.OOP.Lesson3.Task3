using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson3.Task3
{
    class FileOperation
    {
        public void SearchMail(ref string s)
        {
            string[] words = s.Split(' ');
            s = null;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("@"))
                {
                    s+=words[i]+" ";
                }

            }
            
        }
        internal string ReadFromFile()
        {
            string path = @"C:\Users\HomePC\source\repos\GeekBrains\GeekBrains.OOP.Lesson3.Task3\Names.txt";

            string readText = File.ReadAllText(path);
            return readText;
        }
        internal void CreateFile(string inputstring)
        {
            string path = @"C:\Users\HomePC\source\repos\GeekBrains\GeekBrains.OOP.Lesson3.Task3\Emails.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllText(path, inputstring, Encoding.UTF8);
            }
        }
    }
}
