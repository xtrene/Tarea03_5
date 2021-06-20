using System;

namespace Tarea03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 33;
            int B = 20;
            int C = 200;
            int D = 57;
            int temporal = 0;

            Console.WriteLine("Valores iniciales de las variables:");
            Console.WriteLine("Valor de A: {0}", A);
            Console.WriteLine("Valor de B: {0}", B);
            Console.WriteLine("Valor de C: {0}", C);
            Console.WriteLine("Valor de D: {0}", D);

            temporal = B;
            B = C;
            C = A;
            A = D;
            D = temporal;

            Console.WriteLine("Valores de las variables después del cambio:");
            Console.WriteLine("Valor de A: {0}", A);
            Console.WriteLine("Valor de B: {0}", B);
            Console.WriteLine("Valor de C: {0}", C);
            Console.WriteLine("Valor de D: {0}", D);

            Console.ReadKey();
        }
    }
}
