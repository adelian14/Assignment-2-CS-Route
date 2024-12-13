namespace Question_6
{

    internal class point
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            p1.x = 5;
            p1.y = 6;
            point p2 = p1;
            Console.WriteLine("p1: x = " + p1.x + ", y = " + p1.y);
            Console.WriteLine("p2: x = " + p2.x + ", y = " + p2.y);
            p1.x = 8;
            Console.WriteLine("After change");
            Console.WriteLine("p1: x = " + p1.x + ", y = " + p1.y);
            Console.WriteLine("p2: x = " + p2.x + ", y = " + p2.y);
            Console.WriteLine("Changing the value of p1 affects the value of p2, because it's reference type");
        }
    }
}
