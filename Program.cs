Console.Clear();

Console.WriteLine("Bem vindo ao pet hotel Patas alegres, Pressione uma tecla para começar o cadastro.");
Console.ReadKey(true);

Console.WriteLine("Por favor, digite a espécie do seu pet.");
string espécie = Console.ReadLine()!.ToUpper();

Console.WriteLine("Por favor, digite a raça do seu pet.");
string raça = Console.ReadLine()!.ToUpper();

Console.WriteLine("Por favor, digite o nome do seu pet.");
string nome = Console.ReadLine()!.ToUpper();

Console.WriteLine("Por favor, digite a idade do seu pet.");
int idade = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Por favor, digite a cor do seu pet.");
string cor = Console.ReadLine()!.ToUpper();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("                 Pet Hotel Patas Alegres                 ");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"Espécie: {espécie.PadLeft(19,'.')}");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"Raça: {raça.PadLeft(22,'.')}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"Atende pela alcunha de: {nome.PadLeft(33,'.')}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"Idade: {idade.ToString().PadLeft(2,'0')} Ano(s)");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("|");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write($"Pelagem/Cor: {cor.PadLeft(27, '.')}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");

Console.ResetColor();
