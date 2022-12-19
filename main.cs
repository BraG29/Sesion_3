using cliente;


internal class main
{
    public static void Main(string[] args)
    {
        Cliente cliente = new Cliente(
            "Pablo Gomez", "098534267", "Calle Durazno",
            "pablo@mail.com", true);
        Console.WriteLine(cliente); 
    }
}
