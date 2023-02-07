namespace TipsDeConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texto normal");
            impresiones(5);
            Console.ReadKey();
        }

        public static void impresiones(int n)
        {
            int x = 0;
            int y = 0;

            for (x = 0; x < n; x++)
            {
                for (y = 0; y < 100; y++)
                    Console.Write(y % 10);

                Console.WriteLine();
            }
        }
    }
}