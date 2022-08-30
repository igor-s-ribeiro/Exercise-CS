// Elabore um algoritmo que calcule a idade média de 5 alunos.

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

media=(idade1+idade2+idade3+idade4+idade5) / 5;
Console.WriteLine("A média entre as idades é: " +media);

 Console.ReadKey();