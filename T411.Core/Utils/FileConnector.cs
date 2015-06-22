using System;
using System.IO;

namespace T411.Core
{
    public static class FileConnector
    {
        public static void WriteFile(string filePath, byte[] bufferLine)
        {
            try
            {
                if(File.Exists(filePath))
                    File.Delete(filePath);

               File.WriteAllBytes(filePath, bufferLine);
            }
            catch (Exception)
            {
            }
        }

        public static void WriteFile(string filePath, string stringLine)
        {
            try
            {
                if(File.Exists(filePath))
                    File.Delete(filePath);

                var monStreamWriter = new StreamWriter(filePath);
                monStreamWriter.Write(stringLine);
                monStreamWriter.Close();
            }
            catch (Exception)
            {
            }
        }

        public static string ReadFileLine(string filePath)
        {
            var monStreamReader = new StreamReader(filePath);
            return monStreamReader.ReadLine();
        }
    }
}
