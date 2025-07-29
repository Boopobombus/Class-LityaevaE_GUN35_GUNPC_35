using System.Security.Cryptography.X509Certificates;
using Class_LityaevaE_GUN35_GUNPC_35.git;

Console.WriteLine("Подготовка к бою:");
Console.Write("Введите имя бойца:" );
string name =  Console.ReadLine();

Console.WriteLine("Введите начальное здоровье бойца (10-100):");
int.TryParse(s: Console.ReadLine(), out int health);
Unit unit = new Unit (name);
Console.WriteLine("Введите значение брони шлема от 0 до 1:");
Helm helm = new Helm ();

float.TryParse(s: Console.ReadLine(), out float armor); 
unit.EquipHelm(helm);

Console.WriteLine("Введите значение брони кирасы от 0 до 1:");
Shell shell = new Shell ();
float.TryParse(s: Console.ReadLine(), out float armor1);

Console.WriteLine("Введите значение брони сапог от 0 до 1:");
var boots = new Boots();
float.TryParse(s: Console.ReadLine(), out float armor2);


unit.EquipShell(shell);
unit.EquipBoots(boots);

Console.WriteLine("Введите минимальный урон оружия от 0 до 20:");
var weapon = new Weapon(name);
float.TryParse(s: Console.ReadLine(), out float _minDamage);
Console.WriteLine("Введите максимальный урон оружия от 20 до 40:");
float.TryParse(s: Console.ReadLine(), out float _maxDamage);
Console.WriteLine($"Общий показатель брони равен : ");
Console.Write("Фактическое значение здоровья равно:");
Console.WriteLine(unit.RealHealth());
float c = weapon.Durability;
Console.WriteLine($"Прочность равна: {c}");

var dungeon = new Dungeon();

Dungeon dungeons = new Dungeon();
dungeons.ShowRoom();

