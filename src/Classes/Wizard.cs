using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_fantasy.src.Classes
{
    public class Wizard : Characters
    {
        public Wizard(string name)
        {
            this.name = name;
            this.cls = "Mage";
            this.level = 1;
        }
        public override string Atack(string enemy)
        {
            return this.name + " Attack with his wand a " + enemy;
        }
        public string Magic(string magic, string enemy)
        {
            return this.name + " Use " + magic + " in the " + enemy;
        }
        public override void LevelUp()
        {
            base.LevelUp();
            int ClassBonus = 4;
            Console.WriteLine("\n\n{0} level up {1} -> {2}", this.name, this.level, this.level + 1);
            Console.WriteLine("\thp {0} -> {1}", this.hp, (this.hp + this.level * ClassBonus));
            Console.WriteLine("\tmp {0} -> {1}\n\n", this.mp, (this.mp + this.level * ClassBonus));
            this.level += 1;
            this.hp += this.level * ClassBonus;
            this.mp += this.level * (ClassBonus * 2);
        }
    }
}