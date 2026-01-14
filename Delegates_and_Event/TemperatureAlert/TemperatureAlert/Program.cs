namespace TemperatureAlert
{
    //defining Delegate
    public delegate void TemperataureCalculationHandler (int temperature);
    internal class Program
    {
        //event 
        public static event TemperataureCalculationHandler TemperatureEvent;
        static void Main(string[] args)
        {
            //initialize variable
            int temperature;
            Console.Write("Eter the temperature: ");
            //while loop to check the input validation using try catch 
            while (true)
            {
                try
                {
                    temperature = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("IInvalid input");
                }
            }


            //subscribe
            TemperatureEvent += TemperaturePrediction;

            //invoking delegate through event 
            TemperatureEvent.Invoke(temperature);
            Console.ReadKey();
        }

        //method to predict the temperature 
        static void TemperaturePrediction(int temperature)
        {
           

            if (temperature >= 100 )
            {
                Console.WriteLine($"Temperature is above 100");
            }
            else if (temperature <= 0 )
            {
                Console.WriteLine($"Temperature is below 0");

            }
            else
            {
                Console.WriteLine("Normal Temperature");
            }
        }
    }
}
