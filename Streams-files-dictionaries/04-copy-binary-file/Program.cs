using System;
using System.IO;
using System.Linq;

namespace _04_copy_binary_file
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream streamReader = File.OpenRead(@"..\..\..\s.jpg"))
            {
                using (FileStream streamWriter = File.OpenWrite(@"..\..\..\d.jpg"))
                {
                    var binaryReader = new BinaryReader(streamReader);
                    var binaryWriter = new BinaryWriter(streamWriter);

                    var buffer = new Byte[1024];
                    int bytesRead = 0;

                    while((bytesRead = streamReader.Read(buffer, 0, 1024)) > 0)
                    {
                        streamWriter.Write(buffer, 0, bytesRead);
                    }

                }
            }
        }
    }
}
