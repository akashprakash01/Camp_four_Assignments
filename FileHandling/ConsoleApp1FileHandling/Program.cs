namespace ConsoleApp1FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - defining a file
            string filepath = "books.txt";

            //open file in a append mode write , share - none 
            using (FileStream fileStream = new FileStream(filepath,
                FileMode.Append, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine("New data appended at " + DateTime.Now);
                }
            }
            Console.WriteLine("Data Appended  to the file");

            //Read from the file (shared lock)
            using (FileStream fileStream = new FileStream(filepath,
              FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }


            ////2 - check if the file exists
            //if(!File.Exists(filepath)) //false
            //{
            //    //create the file if not exist
            //    FileStream fs = File.Create(filepath);
            //    fs.Close();
            //    Console.WriteLine("File created");
            //}
            ////3 - writing string data into the file
            //string[] contents = { "Akash Prakash, Kairali Bhavan S N Puram po Pampady Kottaym" };
            //File.WriteAllLines(filepath, contents);

            //Console.WriteLine("Data written to the file");



            //4 - read data from the file as a string

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();  
        }
    }
}
