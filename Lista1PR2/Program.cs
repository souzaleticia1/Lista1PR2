using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1.


            //int m;
            //float cent, mili;

            //Console.WriteLine("Digite o metro: ");
            //m = int.Parse(Console.ReadLine());

            //cent = m * 100;
            //mili = m * 1000;

            //Console.WriteLine("O metro " + m + " em centímetros é: " + cent); 
            //Console.WriteLine("O metro " + m + " em milímetros é: " + mili);

            //Console.ReadKey();


            //Exercício 2.A


            //float f, c;

            //Console.WriteLine("Digite o valor em graus Fahrenheit: ");
            //f = float.Parse(Console.ReadLine());

            //c = (f - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("O valor em graus Celsius é: " + c);

            //Console.ReadKey();


            //Exercício 2.B


            //int f, c;

            //Console.WriteLine("Digite o valor em graus Fahrenheit: ");
            //f = int.Parse(Console.ReadLine());

            //c = (f - 32) * (5 / 9);

            //Console.WriteLine("O valor em graus Celsius é: " + c);

            //Console.ReadKey();

            //O resultado é 0 porque a variável int é para inteiros e 5/9 dá 0,555... e por isso ele só conta o 0 e todo número multiplicado por 0 é 0.


            //Exercício 3.

            //int p;
            //float h, r;

            //Console.WriteLine("Digite o seu peso em kg: ");
            //p = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a sua altura: ");
            //h = float.Parse(Console.ReadLine());

            //r = (p / (h * h));

            //Console.WriteLine("Resultado: " + r);

            //Console.ReadKey();


            //Exercício 4.


            //int p1, p2, p3;
            //float n1, n2, n3, mp;

            //Console.WriteLine("Digite um valor: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor: ");
            //n3 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um peso: ");
            //p1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um peso: ");
            //p2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um peso: ");
            //p3 = int.Parse(Console.ReadLine());

            //mp = ((p1 * n1 + p2 * n2 + p3 * n3) / (p1 + p2 + p3));

            //Console.WriteLine("A média ponderada é: " + mp);

            //Console.ReadKey();


            //Exercício 5.


            //float d, t, vm;

            //Console.WriteLine("Digite a distância percorrida: ");
            //d = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o tempo gasto: ");
            //t = float.Parse(Console.ReadLine());

            //vm = ((d / t) * 3.6f);

            //Console.WriteLine("A velocidade média é: " + vm + "km/h");

            //Console.ReadKey();


            //Exercício 6.


            //float s, sf;

            //Console.WriteLine("Digite o seu salário: ");
            //s = float.Parse(Console.ReadLine());

            //sf = ((s * 0.25f) + s);

            //Console.WriteLine("Seu novo salário é: " + sf);

            //Console.ReadKey();


            //Exercício 7.

            //float r, cd, d;

            //Console.WriteLine("Digite o valor em real: ");
            //r = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a cotação do dólar: ");
            //cd = int.Parse(Console.ReadLine());

            //d = r / cd;

            //Console.WriteLine("Resultado: US$" + d);

            //Console.ReadKey();


            //Exercício 8.


            //int n, s, a, r;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //s = n * 3 + 1;
            //a = n * 2 - 1;
            //r = s + a;

            //Console.WriteLine("Resultado: " + r);

            //Console.ReadKey();


            //Exercício 9.

            //int  n, p, s, t, q;

            //Console.WriteLine("Digite um número de 4 dígitos: ");
            //n = int.Parse(Console.ReadLine());

            //p = n / 1000;
            //s = n / 100 - p * 10;
            //t = n / 10 - p * 100 - s * 10;
            //q = n - p * 1000 - s * 100 - t * 10;

            //Console.WriteLine(p);
            //Console.WriteLine(s);
            //Console.WriteLine(t);
            //Console.WriteLine(q);

            //Console.ReadKey();


            //Exercício 10.


            //float r = 1000, pd = 3.4f / 100, sd = 2.8f / 100, td = 14 / 100, qd = 8.5f / 100, vpd, vsd, vtd, vqd;

            //vpd = r - pd;
            //vsd = vpd + sd;
            //vtd = vsd + td;
            //vqd = vtd - qd;

            //Console.WriteLine("O valor atual dos investimentos de Marquesito é de: R$" + vqd);

            //Console.ReadKey();


            //Exercício 11.


            //int n, q, c;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //q = n * n;
            //c = n * n * n;

            //Console.WriteLine("O número " + n + " ao quadrado é " + q + " e ao cubo é " + c);

            //Console.ReadKey();


            //Exercício 12.


            //String g;
            //float h, pi;

            //Console.WriteLine("Você é homem ou mulher? ");
            //g = Console.ReadLine();

            //if(g == "homem")
            //{
            //    Console.WriteLine("Digite a sua altura: ");
            //    h = float.Parse(Console.ReadLine());

            //    pi = (72.7f * h) - 58;

            //    Console.WriteLine("Peso ideal: " + pi);
            // }
            //else 
            //{
            //    Console.WriteLine("Digite a sua altura: ");
            //    h = float.Parse(Console.ReadLine());

            //    pi = (62.1f * h) - 44.7f;

            //    Console.WriteLine("Peso ideal: " + pi);
            //}
            //Console.ReadKey();


            //Exercício 13.

            //O que é o GIT?
            //O GIT é um sistema de controle gratuito. Ele é utilizado para a criação de um código-fonte de projetos de desenvolvimento de software.
            //O que é o GITHUB?
            //O GITHUB é um repositório remoto, criado como um serviçço online de hospedagem de repositórios do GIT.

            //10 comandos do GIT:
            //Git Init:Dá origem a um reositório novo ou reinicializa um já existente.
            //Git Clone:Faz uma cópia do projeto em um repositório e salva no computador.
            //Git Commit:Move os arquivos da state area para um repositório local.
            //Git Add:Precisamos usar este comando para incluir as alterações feitas no nosso próximo commit.
            //Git Push:Envia arquivos de um repositório local para um repositório remoto.
            //Git Pull:Traz um arquivo de um repositório remoto para um repositório local.
            //Git Merge:Serve para unir arquivos alterados ao arquivo original de um projeto.
            //Git Log:Permite a visualização do histórico de um arquivo ou usuário, ou o acesso de uma versão específica.
            //Git Branch:Usando as Branches´, vários desenvolvedores conseguem trabalhar em paralelo no mesmo projeto simultaneamente.
            //Git Checkout:Usado para trocar de uma branch para outra. Também ode ser usado para fazer o chekout de arquivos e commits.
        }
    }
}
