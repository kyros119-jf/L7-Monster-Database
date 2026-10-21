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

List<Monster> dangerousMonsters = monsters
    .Where(monster => monster.Level >= 10)
    .ToList();

foreach (Monster monster in dangerousMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}
Console.WriteLine();
List<Monster> bossMonsters = monsters
    .Where(monster => monster.IsBoss)
    .ToList();

foreach (Monster monster in bossMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}

Console.WriteLine();

Console.WriteLine("Enter a monster type:");

string inputType = Console.ReadLine();

List<Monster> matchingMonsters = monsters
    .Where(monster => monster.Type.ToLower() == inputType.ToLower())
    .ToList();

foreach (Monster monster in matchingMonsters)
{
    Console.WriteLine(monster.GetMonsterInfo());
}