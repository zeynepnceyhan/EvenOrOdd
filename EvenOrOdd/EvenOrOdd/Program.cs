namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
              
            int number1;
            Console.WriteLine("Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());


            if (number1 % 2 == 0)
            {
                Console.WriteLine("The number is an even number..... ");
            }
            else
            {
                Console.WriteLine("The number is an odd number...");
            }

        }

    }

}