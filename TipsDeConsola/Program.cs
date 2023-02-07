namespace TipsDeConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texto normal");
            impresiones(3);

            //Limpiar pantalla
            //Console.Clear();

            Console.WriteLine("Color de la fuente");
            Console.ForegroundColor = ConsoleColor.Green;
            impresiones(3);

            Console.WriteLine("Color de fondo");
            Console.BackgroundColor = ConsoleColor.Gray;
            impresiones(3);

            Console.WriteLine("Indicamos ancho de la ventana en cantidad de columnas");
            Console.BufferWidth = 120; // Tener en cuenta que no puede ser un tamaño menor al de una ventana por defecto.
            impresiones(3);

            Console.WriteLine("Indicamos ancho de la ventana en cantidad de columnas");
            Console.BufferHeight = 40; // Tener en cuenta que no puede ser un tamaño menor al de una ventana por defecto.
            impresiones(3);

            Console.WriteLine("Coloca ventana en una determinada posición");
            Console.WindowWidth = 80;
            Console.WindowHeight = 20;
            impresiones(3);
            Console.WindowLeft= 5;
            Console.WindowTop= 2;



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