using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        // RETO 2
        Console.Write(" Ingrese multiplicador: ");
        int multiplicador = int.Parse(Console.ReadLine());
        Console.Write(" Ingrese Multiplicando: ");
        int multiplicando = int.Parse(Console.ReadLine());
        Console.WriteLine("Resultdo: " + MultiplicacionRusa(multiplicando,multiplicador));
    }

    private static int MultiplicacionRusa (int mndo, int mdor)
    {
        List<int> multiplicandos = [mndo];
        int result = 0;
        do
        {
            if (mdor % 2 != 0)
            {
                result += mndo;
            }
            mndo *= 2;
            mdor /= 2;
        } while (mdor != 1);
        result += mndo;
        return result;
    }
}