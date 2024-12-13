namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a string: ");
            string s;
            s = Console.ReadLine();
            int x, y;
            Console.Write("Enter start index: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter end index: ");
            y = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("The substring from " + x + " to " + y + ": " + s.Substring(x-1,y-x+1));
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
