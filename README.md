# Bytebank
## Lidando com FileStream e arquivos
>>> Status do projeto: Finalizado.

Projeto desenvolvido para aprendizado sobre arquivos e FileStream em C#. O projeto tinha como objetivo desenvolver as habilidades de:
- Aprender a trabalhar com diferentes tipos de arquivos externos.
- Aprender como funciona o fluxo de arquivo ou FileStream e como manipular o uso de memória durante a execução de arquivos externos.
- Utilizar StreamWriter e StreamReader para escrever arquivos e ler arquivos respectivamente.
- Trabalhar com arquivos binários.

## Explicando o projeto:
O projeto é dividido em quatro arquivos para execução das funcionalidades, manipulando os arquivos da pasta net6.0.
- 1_LidandoComFilestreamDiretamente.cs
Funcionalidade para manipular os dados do arquivo "contas.txt", onde vai ler seus dados em um buffer, delimitando o consumo de memória da operação e usar o método EscreverBuffer() para escrever no console os dados do arquivo.
- 2_LidandoComStreamReader.cs
Funcionalidade parecida com o do primeiro arquivo, porém processo é mais simples utilizando a ajuda da classe StreamReader que já vem com métodos prontos para o processo, além disso temos outro método chamado converterStringParaContaCorrente() que vai converter os dados em um objeto do tipo ContaCorrente cujo modelo está como "ContaCorrente.cs" dentro do projeto, e exibir todas contas no console.
- 3_CriandoArquivo.cs
Processo contrário do anterior, agora no método CriarArquivo() sem auxilio do StreamWriter cria o arquivo na pasta com os dados da variavel "dadosNovaConta". Já o método CriarArquivoComWriter() faz a mesma coisa, mas com auxilio do StreamWriter.
Foi feito uma alteração para demonstração do método Flush() para garantir que os dados que estão armazenados no buffer sejam gravados no destino final imediatamente, por conta da natureza de aprendizado do projeto resolvi manter assim.
- 4_LidandoComArquivosBinarios.cs
Função para criar e ler arquivos em binário, eles serem transferidos em binário torna possível uma economia relevante de memória.
- Program.cs
Resolvi demonstrar uma Funcionalidade da classe File que deixa mais fácil ainda o processo de manipulação de arquivo, porém ainda é recomendável saber todos métodos demonstrados para manipular da melhor forma para cada caso o uso de memória durante a aplicação.
## End