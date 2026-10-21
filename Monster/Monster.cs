using System;
using System.Collections.Generic;
using System.Text;

public class Monster
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public bool IsBoss { get; set; }


    public Monster(string name, string type, int level, int health, bool isBoss)
    {
        Name = name;
        Type = type;
        Level = level;
        Health = health;
        IsBoss = isBoss;
    }

    public string GetDangerLevel() => Level < 5 ? "Low" : Level < 10 ? "Medium" : "High";

    public string GetMonsterInfo() => $"Name: {Name} | Level: {Level} | Health: {Health}";


}
