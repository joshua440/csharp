using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaPersonaje2._0
{
    class Spell:ICloneable
    {
        private String name, description, resource;
        private int level, resourcecost;
        private int[] damage = new int[4];

        public Spell(String name, String description, String resource, int level, int resourcecost, int[] damage)
        {
            this.name = name;
            this.description = description;
            this.resource = resource;
            this.level = level;
            this.resourcecost = resourcecost;
            this.damage = damage;
        }

        public Object Clone()
        {
            Spell clone = (Spell)this.MemberwiseClone();
            clone.name = String.Copy(name);
            clone.description = String.Copy(description);
            clone.resource = String.Copy(resource);
            clone.damage = (int[])damage.Clone();
            return clone;
        }

        public override bool Equals(Object o)
        {
            bool answer = false;
            if (o != null && o is Spell)
            {
                if( String.Equals(this.name, ((Spell)o).name) &&
                    String.Equals(this.description, ((Spell)o).description) &&
                    String.Equals(this.resource, ((Spell)o).resource)
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
