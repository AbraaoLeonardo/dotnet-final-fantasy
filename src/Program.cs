using final_fantasy.src.Classes;

Wizard luna = new Wizard(name: "luna");
Warrior haro = new Warrior(name: "haro");
Thief marcs = new Thief(name: "marcs");
Wizard gabriela = new Wizard(name: "gabriela");
Console.WriteLine(luna);
Console.WriteLine(haro);
Console.WriteLine(marcs);
Console.WriteLine(gabriela);
luna.LevelUp();
haro.LevelUp();
marcs.LevelUp();
gabriela.LevelUp();
Console.WriteLine(luna.Atack(enemy: "Goblin"));
Console.WriteLine(haro.Atack(enemy: "Goblin"));
Console.WriteLine(marcs.Atack(enemy: "Goblin"));
Console.WriteLine(gabriela.Atack(enemy: "Goblin"));


