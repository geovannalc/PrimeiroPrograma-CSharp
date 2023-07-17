string nomecompleto;
const string texto = "Olá mundo, meu primeiro programa C#! Feito por ";
int idade;

Console.WriteLine("Qual seu nome completo?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( texto + nomecompleto + " que tem " + idade + " anos");