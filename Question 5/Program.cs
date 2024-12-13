namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = x;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y + '\n');
            x = 20;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("Changing the value of x doesn't affect the value of y");
        }
    }
}
