namespace AdmissionEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eligibility of admission for a professional course
            Console.WriteLine("----Check Your eligibility for the professional course");

            Console.Write("Enter your mark for   Mathematics: ");
            float mathsScore = int.Parse(Console.ReadLine());

            Console.Write("Enter your marks for Physics");
            float physicsScore = int.Parse(Console.ReadLine());

            Console.Write("Enter your marks for Chemistry");
            float chemistryscore = int.Parse(Console.ReadLine());

            float totalScore = mathsScore + physicsScore + chemistryscore;

            if (mathsScore >=65 && physicsScore >= 55 && chemistryscore >= 50 && totalScore>=180)
            {
                Console.WriteLine("You are eligible for this course");
            }
            else if (mathsScore >= 65 && totalScore >=140)
            {
                Console.WriteLine("You are eligible for this course");
            }
            else
            {
                Console.WriteLine("You are not eligible for this course");
            }



                Console.Write("Enter any key to exit: ");
            Console.ReadKey();

        }
    }
}
