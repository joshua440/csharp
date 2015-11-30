using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaPersonaje2._0
{
    class Item:ICloneable
    {
        private String name;
        private int prize, damage, defense;

        public Item(String name, int prize, int damage, int defense)
        {
            this.name = name;
            this.prize = prize;
            this.damage = damage;
            this.defense = defense;
        }

        public object Clone()
        {
            Item clone = (Item)this.MemberwiseClone();
            clone.name = String.Copy(name);
            return clone;
        }

        public override bool Equals(Object o)
        {
            bool answer = false;
            if(o != null && o is Item)
            {
                if (String.Equals(name, ((Item)o).name) &&
                     prize == ((Item)o).prize &&
                     damage == ((Item)o).damage &&
                     defense == ((Item)o).defense
                    )
                {
                    answer = true;
                }
            }
            return answer;
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
