﻿// Elabore um algoritmo que calcule a idade média de 5 alunos.

double media = 0;
double idade1 = 0;
double idade2 = 0;
double idade3 = 0;
double idade4 = 0;
double idade5 = 0;


Console.WriteLine("Programa que calcula a idade media de cinco alunos");
Console.Write("Informe a idade do 1° aluno: ");
idade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do 2° aluno: ");
idade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do 3° aluno: ");
idade3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do 4° aluno: ");
idade4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do 5° aluno: ");
idade5 = Convert.ToDouble(Console.ReadLine());

media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
Console.WriteLine("A média entre as idades é: " + media);

Console.ReadKey();


// Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
// Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

Double salario = 0;
Double salarioNovo = 0;
Console.WriteLine("Efetua o reajuste salarial");
for (int i = 0; i < 3; i++)
{
    Console.Write("Informe o salário: ");
    salario = Convert.ToDouble(Console.ReadLine());
    if (salario <= 300)
    { //50%
        salarioNovo = salario * 1.50;
    }
    else
    { //30%
        salarioNovo = salario + ((salario * 30) / 100);
    }
    Console.WriteLine("Salário reajustado: " + salarioNovo);
}
Console.ReadKey();

// Crie um algoritmo que verifique se um número informado é par ou impar


int result = 0;
int num = 0;

Console.WriteLine("Determina se o número é par ou impar \r\n");
Console.Write("Informe um número: ");
num = Convert.ToInt32(Console.ReadLine());
result = num % 2;

if (result == 1)
{
    Console.WriteLine("O número informado é impar");
}
else
{
    Console.WriteLine("O número informado é par");
}

// Faça um algoritmo que leia a altura e a matricula de dez aluno. 
// Mostre a matricula do aluno mais alto e do aluno mais baixo.

String maMatricula, meMatricula, Matricula;
Double maAltura, meAltura, Altura = 0;

Console.WriteLine("Determina o maior aluno e o menor aluno.");

Console.Write("Informe a matricula do aluno: ");
Matricula = Console.ReadLine();

Console.WriteLine("Informe a altura do aluno: ");
Altura = Convert.ToDouble(Console.ReadLine());

maAltura = Altura;
meAltura = Altura;
maMatricula = Matricula;
meMatricula = Matricula;
int i = 1;

while (i < 5)
{
    Console.Write("Informe a matricula do aluno: ");
    Matricula = Console.ReadLine();

    Console.Write("Informe a altura do aluno: ");
    Altura = Convert.ToDouble(Console.ReadLine());

    if (maAltura < Altura)
    {
        maMatricula = Matricula;
        maAltura = Altura;
    }

    if (meAltura > Altura)
    {
        meMatricula = Matricula;
        meAltura = Altura;
    }
    i++;
}
Console.WriteLine("Maior aluno");
Console.WriteLine("Matricula: {0}, Altura: {1}", maMatricula, maAltura);
Console.WriteLine("Menor aluno");
Console.WriteLine("Matricula: {0}, Altura: {1}", meMatricula, meAltura);
