using InheritanceQuestionThree.Model;

namespace InheritanceQuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating class for the child class Executive
            Executive ExecutiveOne = new Executive();
            ExecutiveOne.ReadData();
            Console.WriteLine(ExecutiveOne);

            Console.WriteLine("Enter eny  key to exit");
            Console.ReadKey();
        }
    }
}
