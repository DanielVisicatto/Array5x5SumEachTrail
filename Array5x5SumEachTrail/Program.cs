int[,] table = new int[5, 5];
Popular();
int[] somaLinhas = SomaLinhas();
int[] somaColunas = SomaColunas();
int somaDiagonalPrincipal = SomaDiagonalPrincipal();
int somaDiagonalSecundaria = SomaDiagonalSecundaria();
ImprimirTabela();
ImprimeSomas();


int Popular()
{
    int[] entradasInt = new int [5]; 
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Digite os valores para as posições separando por vírgula:");
        string[] entradas = Console.ReadLine().Split(',');

        table[i, 0] = int.Parse(entradas[0]);
        table[i, 1] = int.Parse(entradas[1]);
        table[i, 2] = int.Parse(entradas[2]);
        table[i, 3] = int.Parse(entradas[3]);
        table[i, 4] = int.Parse(entradas[4]);

        entradasInt= entradas.Select(int.Parse).ToArray();       
    }
    return entradasInt.Sum();
}
void ImprimeSomas()
{
    Console.WriteLine();
    for (int i = 0; i < somaLinhas.Length; i++)
    {
        Console.WriteLine("A soma da linha {0} é: {1}", i + 1, somaLinhas[i]);
    }

    Console.WriteLine();
    for (int i = 0; i < somaColunas.Length; i++)
    {
        Console.WriteLine("A soma da coluna {0} é: {1}", i + 1, somaColunas[i]);
    }

    Console.WriteLine();
    Console.WriteLine("A soma da diagonal principal é: {0}", somaDiagonalPrincipal);   
    Console.WriteLine("A soma da diagonal secundária é: {0}", somaDiagonalSecundaria);

}
void ImprimirTabela()
{
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            Console.Write("{0} ", table[linha, coluna]);
        }
        Console.WriteLine();
    }
}
int[] SomaLinhas()
{
    int[] somaLinhas = new int[5];
    for (int i = 0; i < 5; i++)
    {
        int somaLinha = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            somaLinha += table[i, j];
        }
        somaLinhas[i] = somaLinha;
    }
    return somaLinhas;
}
int[] SomaColunas()
{
    int[] somaColunas = new int[5];
    for (int j = 0; j < table.GetLength(1); j++)
    {
        int somaColuna = 0;
        for (int i = 0; i < 5; i++)
        {
            somaColuna += table[i, j];
        }
        somaColunas[j] = somaColuna;
    }
    return somaColunas;
}
int SomaDiagonalPrincipal()
{
    int soma = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        soma += table[i, i];
    }
    return soma;
}
int SomaDiagonalSecundaria()
{
    int soma = 0;
    int j = table.GetLength(1) - 1; 
    for (int i = 0; i < table.GetLength(0); i++)
    {
        soma += table[i, j];
        j--; 
    }
    return soma;
}