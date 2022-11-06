namespace Calculator6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my C#-calculator\r");
            Console.WriteLine("...........................\n");
            Console.Write("Enter a number and hit Enter: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number and press Enter: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            switch (Console.ReadLine()) { 
            }

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);

            Console.Write("Press any key to close this window...");

            Console.ReadLine();


        }
    }
}