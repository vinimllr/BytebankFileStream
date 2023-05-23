using System.Text;

partial class Program
{
    static void LidandoComFilestremaDiretamente()
    {
        var enderecoArquivo = "contas.txt";
        using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }
            fluxoDoArquivo.Close();
            Console.ReadKey();
        }

    }

    static void EscreverBuffer(byte[] buffer, int numeroDeBytes)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, numeroDeBytes);
        Console.Write(texto);
    }

}