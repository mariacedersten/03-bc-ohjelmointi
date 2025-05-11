using System.Runtime.InteropServices.Marshalling;

namespace BC_Ohjelmointi
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write("Anna numero:");
            int numero = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + "*" + i + "=" + numero * i);
            }
            Console.ReadKey();
        }
    }
}
