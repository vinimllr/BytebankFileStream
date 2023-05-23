using ByteBankIO;
using System.Text;
using System.Xml;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var dadosNovaConta = "316,3254,3350.37,Leonardo";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(dadosNovaConta);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "ContasExportadas.csv";
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 1000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                Console.WriteLine($"linha {i} escrita");
                Console.ReadKey();
            }
        }
    }
}