namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);

            // Correct answer is: A value 1 will be assigned to d.
            // because 30 < 20 is false, so !(30 < 20) is true, and true will be converted to 1
        }
    }
}
