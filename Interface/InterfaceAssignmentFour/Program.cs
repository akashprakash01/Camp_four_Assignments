namespace InterfaceAssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.SaySomething();
            dog.SaySomething();
            Console.ReadKey();
        }
    }
}
