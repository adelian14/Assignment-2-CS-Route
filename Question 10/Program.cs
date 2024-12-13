namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            //Correct answer is: 7 7
            //
            //firstly the whole condition (!(num <= 0)) is true, so the first if block of code will be executed
            //
            //++num will result with 2 at the same time
            //z++ will leave z = 5, but later z will be updated to 6
            //so adding 2+5=7, the first number
            //
            //now z = 6, and ++z will make z = 7, the second number
        }
    }
}
