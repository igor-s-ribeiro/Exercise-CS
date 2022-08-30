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
