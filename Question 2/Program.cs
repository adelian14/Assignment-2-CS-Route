namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse("123abc");
            }
            catch (Exception e) {
                Console.WriteLine("Can't convert from string to int\n" +
                    "because the string contains non-numeric characters");
            }
        }
    }
}
