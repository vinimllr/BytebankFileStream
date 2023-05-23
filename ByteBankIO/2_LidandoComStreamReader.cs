using ByteBankIO;

partial class Program
{
    static void LidandoComStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = converterStringParaContaCorrente(linha);
                var msg = $"Numero da conta = {contaCorrente.Numero} // Agencia = {contaCorrente.Agencia} // Saldo = {contaCorrente.Saldo} // Titular = {contaCorrente.Titular.Nome}";
                Console.WriteLine(msg);
            }
        }
    }
    static ContaCorrente converterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numeroConta = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var titular = campos[3];


        ContaCorrente conta = new ContaCorrente(agencia, numeroConta);
        conta.Depositar(saldo);
        conta.Titular = new Cliente();
        conta.Titular.Nome = titular;

        return conta;
    }
}