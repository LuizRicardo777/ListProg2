using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float laranjas, resu;

            //Console.WriteLine("quantas laranjas você comprou?");
            //laranjas = float.Parse(Console.ReadLine());

            //if (laranjas < 12) 
            //{
            //    resu = laranjas * 0.35f;
            //    Console.WriteLine("o preço da sua compra foi de " + resu);
            //}
            //else
            //{
            //    resu = laranjas * 0.28f;
            //    Console.WriteLine("o preço da sua compra foi de " + resu);
            //}
            //Console.ReadKey();

            //1- exercico da laranja 

            //int resu, idade;

            //Console.WriteLine("qual o ano que você nasceu?");
            //idade = int.Parse(Console.ReadLine());

            //resu = 2026 - idade;

            //if (resu >= 16) {
            //    Console.WriteLine("você poderá votar na proxima eleição");
            //}
            //else
            //{
            //    Console.WriteLine("você não poderá votar na proxima eleição");
            //}
            //Console.ReadKey();
            //2-exercico da eleição

            //float lado1, lado2, lado3;

            //Console.WriteLine("qual o valor do lado 1?");
            //lado1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do lado 2?");
            //lado2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do lado 3?");
            //lado3 = float.Parse(Console.ReadLine());

            //if (lado1 == lado2 && lado3==lado1)
            //{
            //    Console.WriteLine("esse triangulos é equilatero ");
            //}
            //else
            //{
            //    if ( lado1==lado2 && lado2!=lado3 || lado1==lado3 && lado1!= lado2 || lado2==lado3&&lado1!=lado3){
            //        Console.WriteLine("esse triangulo é isóceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("esse triangulo é escaleno");
            //    }
            //}
            //Console.ReadKey();
            //3- exercicio dos triangulos 

            //double a, b, c, x, delta;
            //Console.WriteLine("qual o valor de a?");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor de b?");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor de c?");
            //c = double.Parse(Console.ReadLine());

            //delta = b * b - 4 * a * c;

            //if (delta < 0)
            //{
            //    Console.WriteLine("Não existem raízes reais para a equação.");
            //}
            //else if (delta == 0)
            //{
            //    x = -b / (2 * a);
            //    Console.WriteLine("A equação possui uma raiz real: x = " + x);
            //}
            //else
            //{
            //    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //    Console.WriteLine("A equação possui duas raízes reais: x1 = " + x1 + " e x2 = " + x2);  
            //}
            // Console.ReadKey();
            //4- descobrir as raizes

            //int numero;

            //Console.WriteLine("digite um numero");
            //numero = int.Parse(Console.ReadLine());

            //if (numero % 3 == 0 && numero % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 5 e 3 ");
            //}
            //else if (numero % 3== 0)
            //{
            //    Console.WriteLine("numero é divisivel por 3");
            //}
            //else if (numero % 5== 0)
            //{
            //    Console.WriteLine("numero é divisivel por 5");
            //}
            //else
            //{
            //    Console.WriteLine("numero nao é divisivel por nenhum dos dois");
            //}
            //Console.ReadKey();
            //5- exercicio divisor 3 e 5

            //int ang1,ang2, ang3;
            //Console.WriteLine("digite o valor do angulo 1 ");
            //ang1= int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do angulo 2 ");
            //ang2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do angulo 3 ");
            //ang3 = int.Parse(Console.ReadLine());

            //if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            //{
            //    Console.WriteLine("o triangulo é um triangulo retangulo");
            //}
            //else if (ang1<90 && ang2 < 90 && ang3 < 90)
            //{
            //    Console.WriteLine("este triangulo é acutângulo");
            //}
            //else
            //{
            //    Console.WriteLine("esse triangulo é obsângulo");
            //}
            //Console.ReadKey();
            //6-exercicio trianguloI(angulos)

            //int val1, val2, val3,temp;
            //Console.WriteLine("fale um numero");
            //val1=int.Parse(Console.ReadLine());
            //Console.WriteLine("fale um numero diferente do anterior");
            //val2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("fale um numero diferente dos anteriores");
            //val3 = int.Parse(Console.ReadLine());

            //if (val1 > val2)
            //{
            //     temp = val1;
            //    val1 = val2;
            //    val2 = temp;
            //}

            //if (val2 > val3)
            //{
            //     temp = val2;
            //    val2 = val3;
            //    val3 = temp;
            //}

            //if (val1 > val2)
            //{
            //    temp = val1;
            //    val1 = val2;
            //    val2 = temp;
            //}

            //Console.WriteLine($"Os valores em ordem crescente são: {val1}, {val2} e {val3}");

            //Console.ReadKey();
            //7-exercicio de organizar os numeros 

            //int ano;

            //Console.WriteLine("qual o ano que você deseja sabe");
            //ano=int.Parse(Console.ReadLine());

            //if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            //{
            //    Console.WriteLine($"{ano} é um ano bissexto.");
            //}
            //else
            //{
            //    Console.WriteLine($"{ano} não é um ano bissexto.");
            //}
            //    Console.ReadKey();
            //8- exercicio do ano bissexto


            //double num1, num2,resul;
            //char carac;

            //Console.WriteLine("digite um numero");
            //num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite outro numero");
            //num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite um caracter(+,-,/,*)");
            //carac = char.Parse(Console.ReadLine());

            //if (carac == '+')
            //{
            //    resul = num1 + num2;
            //    Console.WriteLine($"o resultado dos dados é {resul}");
            //}
            //else if (carac == '-')
            //{
            //    resul = num1 - num2;
            //    Console.WriteLine($"o resultado dos dados é {resul}");
            //}
            //else if (carac == '/')
            //{
            //    resul = num1 / num2;
            //    Console.WriteLine($"o resultado dos dados é {resul}");
            //}
            //else if (carac == '*')
            //{ 
            //    resul = num1 * num2;
            //    Console.WriteLine($"o resultado dos dados é {resul}");
            //}
            //else
            //{
            //    Console.WriteLine("esse caracter não era esperado, volte e digite outro");
            //}
            //Console.ReadKey();
            //9-exercico das contas

            //10- Para gerar números aleatórios em C#, use a classe Random. Para gerar um número inteiro aleatório em um intervalo, use o método Next(minValue, maxValue). Para gerar um número real aleatório em um intervalo, use o método NextDouble() e ajuste o valor multiplicando pelo tamanho do intervalo e adicionando ao valor mínimo.
        }
    }
}
