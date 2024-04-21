int maiorIdade = 0, menorIdade = 0, idade=0;

for (int i=1; i<=10; i++)
{
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());
    {

        if (idade >= 18)
        {
            maiorIdade++;
        }

        else
        {
            menorIdade++;
        }
    }
  
}
{
    Console.WriteLine("Quantidade de maiores de idade:" + maiorIdade);
    Console.WriteLine("Quantidade de menores de idade" + menorIdade);
}
