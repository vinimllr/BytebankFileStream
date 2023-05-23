using ByteBankIO;
using System.Text;
using System.Xml;

partial class Program
{
    static void EscritaBinaria()
    {
        var enderecoArquivo = "contaEmBinario.txt";
        using(var fs = new FileStream(enderecoArquivo, FileMode.Create))
        using(var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);           //número da Agência
            escritor.Write(546544);   //número da conta
            escritor.Write(4000.50); //Saldo
            escritor.Write("Gustavo Braga");
        }
    }
    static void LeituraEmBinario()
    {
        var enderecoArquivo = "contaEmBinario.txt";
        using(var fs = new FileStream(enderecoArquivo, FileMode.Open))
        using(var leitor =  new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var conta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia}/{conta} {titular} {saldo}");
        }
    }
}