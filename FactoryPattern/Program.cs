namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want too create:");
            int wheelCount;
            var input = int.TryParse(Console.ReadLine(), out wheelCount);
        }
    }   
}