using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace HospitalSystem
{
    //summary
    //Implement a waiting list of patient’s names in a hospital.
    //The person sending in the patients to the doctors room should
    //be able to find the next person to go in.
    //summary
    public class HospitalSystem
    {
        // Declare queue to store patients
        static Queue patientQueue = new Queue();


        #region Entry point
        static void Main(string[] args)
        {
            //call display menu
            while (true)
            {
                DisplayMenu();

                // get choice from the user
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterPatient();
                        break;
                    case "2":
                        ProcessNextPatient(); 
                        break;
                    case "3":
                        DisplayQueueStatus();
                        break;
                    case "4":
                        EmergencyCase();
                        break;
                    case "5":
                        Console.WriteLine("Exiting System");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Console.ReadKey();
                        break;

                }
            }
            
        }
        #endregion

        #region 1-DisplayMenu
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hospital management system");
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("\nMain Menu: ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Register New Patient");
            Console.WriteLine("2. Process New Patient");
            Console.WriteLine("3. View Current Queue");
            Console.WriteLine("4. Emergency case (Propriety)");
            Console.WriteLine("5. Exit System");
            Console.Write("Enter Your Choice (1-5): ");


        }
        #endregion

        #region 2 - RegisterPatient
        public static void RegisterPatient()
        {
            //input form the user
            Console.Write("Enter patient Name: ");
            string name = Console.ReadLine();

            //check Empty String
            if(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid: Patient name cannot be empty!");
                return;
            }

            //if valid add to Queue
            patientQueue.Enqueue(name);
            Console.WriteLine($"Patient '{name}' added to Queue. "+
                $"Queue Position: {patientQueue.Count}");
            //newline
            Console.WriteLine();
            Console.WriteLine("Press any key continue");
            Console.ReadKey();  
        }
        #endregion

        #region 3 - DisplayQueueStatus
        public static void DisplayQueueStatus()
        {
            //check whether the queue is empty or not
            if (patientQueue.Count == 0)
            {
                Console.WriteLine("No patients currently waiting");
                return;
            }
            //displaying total number of patients
            Console.WriteLine($"\nCurrent Queue ({patientQueue.Count} patients):");
            //displaying next patient to be checked
            Console.WriteLine($"\nNext patient to be processed is: " + patientQueue.Peek());

            //displaying full patient details
            Console.WriteLine("\nFull Queue List:");
            int position = 1;

            foreach (string patient in patientQueue)
            {
                Console.WriteLine($"{position++}. {patient}");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key continue");
            Console.ReadKey();
        }
        #endregion

        #region 4-ProcessNextPatient
        public static void ProcessNextPatient()
        {
            if (patientQueue.Count == 0)
            {
                Console.WriteLine("No patients.");
                return;
            }
            //get next patient to be processed
            string nextPatient = (string)patientQueue.Dequeue();
            Console.WriteLine($"Processing patient: {nextPatient}");
            Console.WriteLine($"{patientQueue.Count} patients remaining in queue.");

            Console.WriteLine();
            Console.WriteLine("Press any key continue");
            Console.ReadKey();


        }
        #endregion

        #region 5-Emergency case
        public static void EmergencyCase()
        {

            //input form the user

            Console.WriteLine(" Add Emergency patient ");

            Console.Write("Enter patient Name: ");
            string name = Console.ReadLine();


            //check Empty String
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid: Patient name cannot be empty!");
                return;
            }
            Queue emergencyQueue = new Queue();

            //if valid add to Emergency  Queue
            emergencyQueue.Enqueue(name);
            foreach (string patient in patientQueue)
            {
                emergencyQueue.Enqueue(patient);
            }

            //update the patient queue
            patientQueue = emergencyQueue;
           

            Console.WriteLine();
            Console.WriteLine("Press any key continue");
            Console.ReadKey();
        }
        #endregion

    }

}
