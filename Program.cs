namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");

            int var1;

            while (true)
            {
                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("you can only int number");
                    
                }
           
            }

            Console.WriteLine("Enter Second Number");
            int var2 = int.Parse(Console.ReadLine());

            int sum = Sum(var1, var2);
            Console.WriteLine("sum is: " + sum);
   
        }
        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}