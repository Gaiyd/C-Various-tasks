using System;
using System.IO;

namespace Assignment4
{
    public class ThisEventArgs : EventArgs
    {
        public string? LineRead { get; set; }
    }
    public static class TextFileProcessor
    {
        public delegate void Delegate(string message);
        public static event Delegate LineRead;

        public static void RaiseEvent(string input)
        {
            if (LineRead != null) LineRead(input);
        }



        public static string [] Read(string samplefile)
        {
            string readText = File.ReadAllText(samplefile);
            string[] lines = readText.Split('\n');
            
            foreach (string s in lines)
            {
                //Console.WriteLine(s);
                RaiseEvent(s);

            }
            string [] lineLINQ = lines;
            //Console.WriteLine("File read successfuly");
            //Console.WriteLine("No of shapes in the file is " +lines.Length);
            return lineLINQ;
        }

        public class HelloWorld
        {
            public static void contentofFile(string message)
            {
                Console.WriteLine(message);
            }
            /*static void Main()
            {
                TextFileProcessor.LineRead += new TextFileProcessor.Delegate(contentofFile);
                TextFileProcessor.Read("shapes.txt");
            }*/
        }
    }
}

