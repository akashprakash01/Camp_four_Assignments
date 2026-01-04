namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intputOne;
            int intputTwo; ;
            int result;

            Console.WriteLine("Enter NUmber One: ");
            
            intputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NUmber Two: ");
             intputTwo = Convert.ToInt32(Console.ReadLine());

            try
            {
                result =  intputOne/intputTwo;
                Console.WriteLine(result);
            }
            catch (ArithmeticException e) 
            {
                Console.WriteLine(e);

            }
            Console.ReadKey();
        }
    }
}
