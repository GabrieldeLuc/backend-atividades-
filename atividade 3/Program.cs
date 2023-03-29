Console.WriteLine($"Bem vindo ao Sistema, por favor digite a primeira nota: ");
float nota1 = float.Parse (Console.ReadLine());

Console.WriteLine($"Agora por favor digite a segunda nota: ");
float nota2 = float.Parse (Console.ReadLine());

Console.WriteLine($"Agora, por favor digite a terceira nota: ");
float nota3 = float.Parse (Console.ReadLine());

Console.WriteLine($"Agora, por favor digite a quarta nota: ");
float nota4 = float.Parse (Console.ReadLine());

Console.WriteLine($"Agora, por favor digite a quinta nota: ");
float nota5= float.Parse (Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5)/5; 

Console.WriteLine($"a media de suas notas e {media}");




