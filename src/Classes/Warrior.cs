using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_fantasy.src.Classes
{
    public class Warrior : Characters
    {
        public Warrior(string name)
        {
            this.name = name;
            this.cls = "Warrior";
            this.level = 1;
        }
        public override string Atack(string enemy)
        {
            return this.name + " Attack with his sword" + enemy;
        }
        public string Protect(string enemy)
        {
            return this.name + " Defende using the shild the " + enemy + " Atack";
        }
        public override void LevelUp()
        {
            base.LevelUp();
            int ClassBonus = 10;
            Console.WriteLine("\n\n{0} level up {1} -> {2}", this.name, this.level, this.level + 1);
            Console.WriteLine("\thp {0} -> {1}", this.hp, (this.hp + this.level * ClassBonus));
            Console.WriteLine("\tmp {0} -> {1}\n\n", this.mp, (this.mp + this.level * ClassBonus));
            this.level += 1;
            this.hp += this.level * ClassBonus;
            this.mp += this.level * (ClassBonus / 2);
        }
    }
}