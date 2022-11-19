using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_fantasy.src.Classes
{
    public abstract class Characters
    {
        public Characters()
        {
            this.name = "hero";
            this.cls = "warrior";
            this.level = 1;
            this.hp = 20;
            this.mp = 20;
        }
        protected string name { get; set; }
        protected int level { get; set; }
        protected string cls { get; set; }
        protected int hp { get; set; }
        protected int mp { get; set; }

        public virtual void LevelUp()
        {

        }
        public override string ToString()
        {
            return this.name + "\n\tLv. " +
            this.level + " " + this.cls +
            "\n\tHP " + this.hp +
            "\n\tMP " + this.mp + "\n\n";
        }
        public string Status()
        {
            return this.name + " " + this.level + "\n\thp:" + this.hp + "\n\tmp:" + this.mp;
        }
        public virtual string Atack(string enemy)
        {
            return this.name + " Attack with his sword a " + enemy;
        }
    }
}