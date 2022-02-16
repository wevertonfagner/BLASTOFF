int idadeI, idadeJ, idadeK, idadeX, idadeY;
int mediaIdades;

Console.WriteLine("Digite idade I: ");
idadeI = int.Parse(Console.ReadLine());

Console.WriteLine("Digite idade J: ");
idadeJ = int.Parse(Console.ReadLine());

Console.WriteLine("Digite idade K: ");
idadeK = int.Parse(Console.ReadLine());

Console.WriteLine("Digite idade X: ");
idadeX = int.Parse(Console.ReadLine());

Console.WriteLine("Digite idade Y: ");
idadeY = int.Parse(Console.ReadLine());

mediaIdades = (idadeI + idadeJ + idadeK + idadeX + idadeY) / 5;
Console.WriteLine("A média de idade é: " + mediaIdades);

Console.ReadKey();
