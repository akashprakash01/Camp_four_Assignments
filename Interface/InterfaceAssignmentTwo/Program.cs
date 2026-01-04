namespace InterfaceAssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAnimals animal = new MyAnimals();

            Console.WriteLine("Enter body temperature:");
            animal.BodyTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Body Temperature is: " + animal.GetBodyTemp());

            Console.ReadKey();
        }
    }
}
