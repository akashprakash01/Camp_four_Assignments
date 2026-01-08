using System.ComponentModel;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a file
            string filepath = "notes.txt";

            //checking if the file exist
            if (!File.Exists(filepath))
            {
                //creating file if not exist
                FileStream createFile = File.Create(filepath);
                createFile.Close();
                Console.WriteLine("File created");
            }
            
            else
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                string line;
                //Read the first line of text
                line = sr.ReadLine();
                //checking the length of the text
                if (line.Length<7)
                {
                    Console.WriteLine("Text is too short");

                }
                else
                {
                    //if length greater than 7 print the 5 charater starting from the 3rd character
                    for (int i = 2; i < 7; i++)
                    {
                        Console.Write(line[i]);
                    }
                    sr.Close();
                }
                    
                Console.WriteLine();

            }
                Console.WriteLine("Enter any key to exit..");
            Console.ReadKey();
            
        }
    }
}
