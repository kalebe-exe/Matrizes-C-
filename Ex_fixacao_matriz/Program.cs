using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de linhas e colunas da matriz separados por um espaço: ");
            string[] lxc = Console.ReadLine().Split(' ');
            int linha = int.Parse(lxc[0]);
            int coluna = int.Parse(lxc[1]);

            int[,] matrizINT = new int[linha, coluna];

            // For para armazenar os valores nas linhas e colunas corretas
            for (int i = 0; i < linha; i++) { // Percorre as linhas da matriz

                Console.Write("Digite os valores da linha " + i + " separados por um espaço: ");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++) { // Percorre as colunas da matriz
                    matrizINT[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Digite o número a ser encontrado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++) { // Percorre as linhas da matriz
                for (int j = 0; j < coluna; j++) { // Percorre as colunas da matriz

                    // Verificar se x existe na matriz
                    if (matrizINT[i, j] == x) {
                        Console.WriteLine();
                        Console.WriteLine("Na posição: " + i + ", " + j);
                        Console.WriteLine();
                        // Verifica se existe à esquerda
                        if (j - 1 >= 0) {
                            Console.WriteLine("Esquerda: " + matrizINT[i, j - 1]);
                        }
                        // Verifica se existe à direita
                        if (j + 1 < coluna) {
                            Console.WriteLine("Direita: " + matrizINT[i, j + 1]);
                        }
                        // Verifica se existe acima
                        if (i - 1 >= 0) {
                            Console.WriteLine("Acima: " + matrizINT[i - 1, j]);
                        }
                        // Verifica se existe embaixo
                        if (i + 1 < linha) {
                            Console.WriteLine("Embaixo: " + matrizINT[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}