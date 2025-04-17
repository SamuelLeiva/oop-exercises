namespace OOP_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer impresora = new Printer("ajk-567");

            impresora.imprimirNumSerie();

            Computer computer = new Computer();

            computer.encender();

            Console.WriteLine("Ejemplo de suma: " + computer.sumar(78,69));
        }
    }
}
