namespace InheritanceAssignmentSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Console.WriteLine("Cat Cry: " + cat.Cry());
            cat.Fly();
            cat.Walk();

            Console.WriteLine("----------------");

            Animal dog = new Dog();
            Console.WriteLine("Dog Cry: " + dog.Cry());
            dog.Fly();
            dog.Walk();

            Console.WriteLine("----------------");

            Animal goat = new Goat();
            Console.WriteLine("Goat Cry: " + goat.Cry());
            goat.Fly();
            goat.Walk();

            Console.WriteLine("----------------");

            Animal crow = new Crow();
            Console.WriteLine("Crow Cry: " + crow.Cry());
            crow.Fly();
            crow.Walk();

            Console.WriteLine("----------------");

            Animal chicken = new Chicken();
            Console.WriteLine("Chicken Cry: " + chicken.Cry());
            chicken.Fly();
            chicken.Walk();

            Console.ReadKey();
        }
    }
}
