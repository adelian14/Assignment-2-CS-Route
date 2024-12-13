namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 0.0004f;
            float y = 0.0002f;
            float sum = x + y;
            Console.WriteLine(x + " + " + y + " = " + sum);
            if (sum != 0.0006f)
            {
                Console.WriteLine("sum doesn't equal exactly 0.0006, because of precision error");
            }
        }
    }
}
