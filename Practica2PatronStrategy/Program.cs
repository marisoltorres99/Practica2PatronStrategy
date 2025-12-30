using Practica2PatronStrategy.Service;

public class Program
{
    static void Main(string[] args)
    {
        var calculadoraPago = new CalculadoraPago(new PagoBilleteraVirtual());
        Console.WriteLine(calculadoraPago.ProcesarPago());
    }
}