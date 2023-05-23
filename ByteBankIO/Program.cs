using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var texto = File.ReadAllText("contas.txt");
        Console.WriteLine(texto);
    }
}