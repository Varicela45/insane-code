using Practica_III;

internal class Program
{
    private static void Main(string[] args)
    {
        Valor valor = new Valor();

        Console.Write("Ingrese numero:  ");
        valor.Numero = int.Parse(Console.ReadLine());

        if (valor.Numero >= 1)
        {
            Console.WriteLine("Su valor es positivo");
        }

        if (valor.Numero <= -1)
        {
            Console.WriteLine("Su valor es negativo");
        }

        if (valor.Numero == 0)
        {
            Console.WriteLine("Su valor es cero");
        }


        Console.ReadKey();
    }    
}