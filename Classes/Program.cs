namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the car class
            Car car = new Car();

            //Set values in the properties for the object
            car.Make = "Cheverolet";
            car.Model = "Impala";
            car.Year = 2007;

            //Print the values of each property to Console
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
        }
    }
}
