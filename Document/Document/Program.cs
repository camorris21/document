using System;

using System.IO;

namespace Document
{

    class Document
    {

        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Document");

                Console.WriteLine("Enter the Document Name:");

                string name = Console.ReadLine();

                Console.WriteLine("Enter the Content of the Document:");

                string content = Console.ReadLine();

                string filename = name + ".txt";

                string path = Environment.CurrentDirectory + "/" + filename;

                if (!File.Exists(path))

                {

                    File.WriteAllText(path, content);

                }

                Console.WriteLine(filename + " was successfully saved. The document contains " + content.Length + " characters");

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }

        }

    }

}
