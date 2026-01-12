namespace AssignmentThree
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Email { get; set; }
            public string Skills { get; set; }

        }

        static void Main(string[] args)
        {
            string folderPath = "CV_Files";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created.");
            }

            List<Person> persons = new List<Person>
            {
                new Person { Name = "Aksah", Location = "Kottayam", Email = "akash@gmail.com", Skills = "C#, .NET" },
                new Person { Name = "Navya", Location = "kozhikode", Email = "navya@gmail.com", Skills = "Python, Django" }
            };

            foreach (var person in persons)
            {
                string fileName = person.Name + "_" + person.Location + ".txt";
                string filePath = Path.Combine(folderPath, fileName);

                string cvContent = "Curriculum Vitae\n" + $"Name     : {person.Name}\n" + $"Location : {person.Location}\n" + $"Email    : {person.Email}\n" + $"Skills   : {person.Skills}\n";

                File.WriteAllText(filePath, cvContent);

                Console.WriteLine(cvContent);
            }

            Console.WriteLine("Curriculum Vitae files generated successfully.");
            Console.ReadKey();
        }
    }

    
}
