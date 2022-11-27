
namespace Extension
{
    public static class DoubleExtension
    {
        public static int Round(this double dbl)
        {
            int num = (int)dbl;
            double plus = num + 0.5;
            if (dbl == plus || dbl > plus)
            {
                num = num + 1;
            }
            return num;
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {
            int i = 2.4.Round();  // i = 2
            int j = 2.5.Round();  // j = 3
            Console.WriteLine(i);
            Console.WriteLine(j);
        }

        
    }
}