using System;
using System.Diagnostics;
using System.IO;

namespace Project_Shapes
{
    static class FileIO
    {
        public static string ReadFile(string fileName)
        {
            Debug.Assert(fileName.Trim().Length > 0, "File Name specified was empty!");

            //Handles open and closing of the file as well.. so it's pretty easy.
            string fileContent = File.ReadAllText(fileName);

            return fileContent;
        }
        public static void WriteFile(string fileName, string outputString)
        {
            Debug.Assert(fileName.Trim().Length > 0, "File Name to write into was not provided!");

            Console.Write(outputString.ToString());

            File.WriteAllText(fileName, outputString.ToString());
        }
    }
}
