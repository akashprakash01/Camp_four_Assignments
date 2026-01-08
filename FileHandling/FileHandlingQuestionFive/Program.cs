namespace FileHandlingQuestionFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a file
            string filePath = "notes.txt";
            //string newFilePath = "E:/Faithinfotech/.Net/Camp4/PropelSep2025/Assignments/FileHandling/notes.txt";

            //userInputPath of new destination
            Console.Write("Enter the location path correctly to copy the text file: ");
            string userInputPath = Console.ReadLine();

            //checking if the file exist//
            if (!File.Exists(filePath))
            {
                //Creating file if not exist
                using (FileStream createFile = File.Create(filePath))
                {

                }
                //after file creation writing text to the file
                using (StreamWriter createWriter = new StreamWriter(filePath))
                {
                    createWriter.WriteLine("New file has been created and added this text using coding");
                }
               

                // getting the file information(file path)
                FileInfo fileInfo = new FileInfo(filePath);

                //coping the file to a new location
                fileInfo.CopyTo(userInputPath,true);
                Console.WriteLine("File Created and copied to another destination");
               
            }
            else
            {
                // getting the file information(file path)
                FileInfo fileInfo = new FileInfo(filePath);
                //coping the file to a new location
                fileInfo.CopyTo(userInputPath, true);
                Console.WriteLine("File copied to another destination");

            }

            Console.ReadKey();
        }
    }
}
