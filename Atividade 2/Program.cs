Console.WriteLine($"Bem vindo ao Sistema, Por favor digite o ano em que voce nasceu");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano em que voce esta: ");
int anoatual = int.Parse (Console.ReadLine());

int idade = (anoatual - ano); 

double semana = (idade * 52.143);



Console.WriteLine($"Sua idade e igual a {idade} anos  e sua idade em semanas e igual a {semana} semanas");







