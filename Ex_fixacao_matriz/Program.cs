using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite as qntd de Linha e Coluanas da matriz separados por um espaco: ");
            string[] lxc = Console.ReadLine().Split(' ');
            int linha = int.Parse(lxc[0]);
            int coluna = int.Parse(lxc[1]);

            int[,] matrizINT = new int[linha, coluna];

            //For para aramazenar os valores nas linha e colunas corretas
            for (int i = 0; i < linha; i++) { //Percorre as linhas da matriz

                Console.Write("Digite os valores da linha " + i + " separados por um espaco: ");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++) { //Percorre as colunas da matriz
                    matrizINT[i, j] = int.Parse(valores[j]);
                }
            }
            Console.Write("Digite o numero a ser encontrado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++) { //Percorre as linhas da matriz
                for (int j = 0; j < coluna; j++) { //Percorre as colunas da matriz

                    //Verificar se x existe na matriz
                    if (matrizINT[i, j] == x) {
                        Console.WriteLine();
                        Console.WriteLine("Na posicao: " + i + ", " + j);
                        Console.WriteLine();
                        //verifica se existe a esquerda
                        if (j - 1 >= 0) {
                            Console.WriteLine("Esquerda: " + matrizINT[i, j-1]);
                        }
                        //verifica se existe a diretira
                        if (j + 1 <= linha) {
                            Console.WriteLine("Direira: " + matrizINT[i, j+1]);
                        }
                        //verifica se existe acima
                        if (i - 1 >= 0) {
                            Console.WriteLine("Acima: " + matrizINT[i-1, j]);
                        }
                        //verifica se existe em baixo
                        if (i + 1 <= coluna) {
                            Console.WriteLine("Em baixo: " + matrizINT[i+ 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
