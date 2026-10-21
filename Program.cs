// Create Monster Database

Repository<Monster> monsterRepository = new Repository<Monster>();


monsterRepository.Add(new Monster("Goblin", "Beast", 3, 30, false));
monsterRepository.Add(new Monster("Dragon", "Dragon", 10, 300, true));
monsterRepository.Add(new Monster("Troll", "Giant", 7, 150, false));
monsterRepository.Add(new Monster("Vampire", "Undead", 5, 80, false));
monsterRepository.Add(new Monster("Werewolf", "Beast", 6, 120, false));
monsterRepository.Add(new Monster("Hydra", "Mythical", 12, 500, true));
monsterRepository.Add(new Monster("Zombie", "Undead", 2, 40, false));
monsterRepository.Add(new Monster("Phoenix", "Mythical", 15, 400, true));

List<Monster> monsters = monsterRepository.GetAll();


// Dangerous Monsters

List<Monster> dangerousMonsters = monsters
    .Where(monster => monster.Level >= 10)
    .ToList();

Console.WriteLine("DANGEROUS MONSTERS\n");

foreach (Monster monster in dangerousMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}

Console.WriteLine();


// Boss Monsters


List<Monster> bossMonsters = monsters
    .Where(monster => monster.IsBoss)
    .ToList();

Console.WriteLine("BOSS MONSTERS\n");


foreach (Monster monster in bossMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}

Console.WriteLine();



// Sort Monsters By Level


List<Monster> monstersByLevel = monsters
    .OrderByDescending(monster => monster.Level)
    .ToList();

Console.WriteLine("MONSTERS BY LEVEL\n");


foreach (Monster monster in monstersByLevel)
{
    Console.WriteLine(monster.GetMonsterInfo());
}


Console.WriteLine();



// Monster Database Statistics

Console.WriteLine("===Monsters Database Statistics===\n");

int monsterCount = monsters.Count();
Console.WriteLine($"Total number of monsters: {monsterCount}");
double averageLevel = monsters.Average(monster => monster.Level);
Console.WriteLine($"Average level of monsters: {averageLevel:F1}");
int highestHealth = monsters.Max(monster => monster.Health);
Console.WriteLine($"Highest health among monsters: {highestHealth}");
int numberOfBosses = monsters.Count(monster => monster.IsBoss);
Console.WriteLine($"Number of Boss monsters: {numberOfBosses}");


Console.WriteLine();


// Strongest Monster

Console.WriteLine("===Strongest Monster===\n");
Monster strongestMonster = monsters
    .OrderByDescending(monster => monster.Health)
    .First();

Console.WriteLine($"The strongest monster is: {strongestMonster.Name}\nHealth: {strongestMonster.Health}\nLevel: {strongestMonster.Level}");


Console.WriteLine();


// Search By Level Range

Console.WriteLine("Enter a Minimum Level:");
int minLevel = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a Maximum Level:");
int maxLevel = int.Parse(Console.ReadLine()) ;
Console.WriteLine();
List<Monster> monstersInRange = monsters
    .Where(monster => monster.Level >= minLevel && monster.Level <= maxLevel)
    .ToList();


Console.WriteLine($"=== Monsters between {minLevel} and {maxLevel} ===\n");
foreach (Monster monster in monstersInRange)
{
    Console.WriteLine(monster.Name);
}


Console.WriteLine();


// Search By Monster Type

Console.WriteLine("Enter a monster type (Beast, Dragon, Giant, Undead, Mythical):\n");

string inputType = Console.ReadLine();
Console.WriteLine();
List<Monster> matchingMonsters = monsters
    .Where(monster => monster.Type.ToLower() == inputType.ToLower())
    .ToList();

foreach (Monster monster in matchingMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}


