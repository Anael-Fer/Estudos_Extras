using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Estudos___2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Faça um programa para mostrar na tela todas as tabuadas de multiplicar de 1 até 10.

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = " + i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            //2.Faça um programa que leia números do teclado, calcule e mostre o quadrado de cada
            //número até entrar um número múltiplo de 6 que deverá ter seu quadrado também impresso.

            double n;

            do
            {
                Console.WriteLine("Digite um número para calcular seu quadrado: ");
                n = double.Parse(Console.ReadLine());

                Console.WriteLine($"O seu número ao quadrado é: " + Math.Pow(n, 2));

            } while (n % 6 != 0);

            Console.ReadLine();

            //3. Faça um programa que receba a quantidade de pessoas que assistiram a uma partida de
            //futebol e mostre as mensagens de acordo com a tabela:
            //menos que 1.000 – “público baixo”
            //entre 1.001 e 10.000 – “público médio”
            //acima de 10.000 – “público bom”

            int quant;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a quantidade de pessoas que assistiram uma partida de futebol: ");
                quant = int.Parse(Console.ReadLine());

                if (quant < 1000)
                    Console.WriteLine("público baixo");
                else if (quant >= 1001 && quant <= 10000)
                    Console.WriteLine("público médio");
                else
                    Console.WriteLine("público bom");
            }

            Console.ReadLine();

            //4.Faça um programa que leia dois valores, um representando o saldo de uma pessoa e o outro
            //representando o valor que será depositado ou retirado da conta de acordo com a seguinte
            //regra.Se o valor do saldo for maior que o segundo valor digitado, seu programa faz a retirada
            //do menor valor do saldo.Caso contrário, seu programa irá depositar este valor na conta,
            //aumentando-o ao saldo. Mostre o saldo final.

            double saldo, depOuret;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Leia o valor do saldo: ");
                saldo = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um segundo valor a ser retirado ou depositado: ");
                depOuret = double.Parse(Console.ReadLine());

                if (saldo > depOuret)
                    saldo -= depOuret;

                if (saldo < depOuret)
                    saldo += depOuret;

                Console.WriteLine($"Saldo atual: {saldo}");
            }

            Console.ReadLine();

            //5.Escreva um programa que leia o peso de um indivíduo.Considere que serão lidos os pesos
            //de 30 pessoas.Calcule e mostre:
            //-A média aritmética dos pesos das pessoas que possuem mais de 60 Kg
            //- O valor do peso da pessoa mais pesada

            double peso, media = 0, soma = 0, maiorP = double.MinValue;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite o seu peso: ");
                peso = double.Parse(Console.ReadLine());

                if (peso > maiorP)
                    maiorP = peso;

                soma += peso;
            }

            media = soma / 30;

            //Console.WriteLine($"Média dos pesos: {media}");
            //Console.WriteLine($"Maior peso registrado: {maiorP}");
            //Console.ReadLine();

            //6.Criar um programa para identificar o valor a ser pago por um plano de saúde dada a idade
            //do conveniado considerando que todos pagam R$ 100 mais um adicional conforme a seguinte
            //tabela:
            //1) crianças com menos de 10 anos pagam R$180;
            //2) conveniados com idade entre 10 e 30 anos pagam R$150;
            //3) conveniados com idade entre 40 e 60 anos pagam R$195;
            //4) conveniados com mais de 60 anos pagam R$230.

            int idade;

            do
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 1 && idade <= 10)
                    Console.WriteLine($"valor a ser pago: R$280.00");
                else if (idade >= 10 && idade <= 30)
                    Console.WriteLine($"valor a ser pago: R$250.00");
                else if (idade >= 40 && idade <= 60)
                    Console.WriteLine($"valor a ser pago: R$295.00");
                else if (idade > 60)
                    Console.WriteLine($"valor a ser pago: R$330.00");

            } while (idade != 0);

            Console.ReadLine();

            //7.Escrever um programa que leia um número n que indica quantos valores devem ser lidos a
            //seguir.Para cada número lido, mostre uma tabela contendo o valor lido e o fatorial deste
            //valor.

            int n;

            double fatorial = 1, s = 1;

            Console.WriteLine("Digite um valor a ser lido: ");
            n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                s += i;
                fatorial *= i;
            }

            Console.WriteLine($"O somatório de 1 até {n} é: {s}");
            Console.WriteLine($"O fatorial de {n} é: {fatorial}");
            Console.ReadLine();

            //8.Faça um programa que realize e mostre o produto entre 2 números inteiros A e B, através
            //de somas sucessivas. Os números deverão ser lidos do teclado.


            static void Soma(ref int x, ref int y, out int z)
            {
                z = x + y; // 7 + 2 = 9
                x = y * 2; // 2 * 2 = 4
                y = x * y; // 4 * 2 = 8
            }

            static void Calcular(ref int x, ref int y, out int z)
            {
                x = x + y; // 3 + 4 = 7
                y = y / 2; // 4 / 2 = 2
                z = x * y; // 7 * 2 = 14
                Soma(ref x, ref y, out z); // Chama o método Soma
            }


            int x = 3;
            int y = 4;
            int z;
            Calcular(ref x, ref y, out z);

            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            Console.ReadLine();

            double a = 0, b = 1, c, n;


            Console.WriteLine("de um numero para n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write(b);

            for (int i = 2; i <= n; i++) // Começa de 2 porque 0 e 1 já foram exibidos
            {
                c = a + b; // Soma dos dois números anteriores
                Console.Write(c);

                // Atualiza os valores para o próximo cálculo
                a = b;
                b = c;
            }
            Console.WriteLine();

            Console.ReadLine();

            static bool verifica(int numero)
            {
                int parte1 = numero / 100;
                int parte2 = numero % 100;

                int soma = parte1 + parte2;

                int resultado = soma * soma;

                return resultado == numero;

            }

            Console.WriteLine();

            for (int i = 1000; i <= 9999; i++)
            {
                if (verifica(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

            string nome, I = "";

            Console.WriteLine("Digite um nome: ");
            nome = Console.ReadLine();

            // Criar a string reversa
            for (int i = nome.Length - 1; i >= 0; i--)
            {
                I += nome[i]; // Adiciona o caractere da posição i à string I
            }

            // Verifica se o nome é um palíndromo
            if (I == nome)
                Console.WriteLine("É palíndromo");
            else
                Console.WriteLine("Não é palíndromo");


            Console.ReadLine();
        }

        static void Media(int[,] idades, double[] medias)
        {

            for (int j = 0; j < 8; j++)
            {
                double soma = 0;

                for (int i = 0; i < 8; i++)
                {
                    soma += idades[i, j];
                }
                medias[j] = soma / 8;
            }

        }


    }
}
