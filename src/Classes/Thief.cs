using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_fantasy.src.Classes
{
    public class Thief : Characters
    {
        public Thief(string name)
        {
            this.name = name;
            this.cls = "Thief";
            this.level = 1;
        }
        public override string Atack(string enemy)
        {
            return this.name + " Attack with his knife " + enemy;
        }
        public string Steel(string enemy)
        {
            Random change = new Random();
            int hit = change.Next(0, 2);
            if (hit == 1)
            {
                return this.name + " stole a potion from" + enemy;
            }
            else if (hit == 2)
            {
                return this.name + " The " + enemy + " don't have item";
            }
            {
                return "Steal fail";
            }
        }
        public override void LevelUp()
        {
            base.LevelUp();
            int ClassBonus = 6;
            Console.WriteLine("\n\n{0} level up {1} -> {2}", this.name, this.level, this.level + 1);
            Console.WriteLine("\thp {0} -> {1}", this.hp, (this.hp + this.level * ClassBonus));
            Console.WriteLine("\tmp {0} -> {1}\n\n", this.mp, (this.mp + this.level * ClassBonus));
            this.level += 1;
            this.hp += this.level * ClassBonus;
            this.mp += this.level * (ClassBonus / 2);
        }
    }
}