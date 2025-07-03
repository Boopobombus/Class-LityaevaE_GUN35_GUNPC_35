using System.Security.Cryptography.X509Certificates;
using Class_LityaevaE_GUN35_GUNPC_35.git;

Console.WriteLine("Подготовка к бою:");
string name = Console.ReadLine();
Console.WriteLine("Введите начальное здоровье бойца (10-100):");
int.TryParse(s: Console.ReadLine(), out int health);
var unit = new Unit (name, health);