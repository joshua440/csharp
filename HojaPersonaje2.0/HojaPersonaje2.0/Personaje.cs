using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaPersonaje2._0
{
    class Personaje:ICloneable
    {
        private String name, clase, race, skin, hair;
        private int level, age, money, health, mana, energy, ki, magicdefense, defense, stamina, initiative;
        private int agilidad, carisma, combate, constitucion, destreza, inteligencia, invocacion, ingenio, fuerza, percepcion, precision, resistencia, suerte;
        private bool genere; // false:male, true:female
        private Item[] bag = new Item[16];
        private Spell[] spells = new Spell[16];

        public Personaje(String name, String clase, String race, String skin, String hair, bool genere,
            int agilidad, int carisma, int combate, int constitucion, int destreza, int inteligencia, int invocacion, int ingenio, int fuerza, int percepcion, int precision, int resistencia, int suerte)
        {
            this.name = name; this.clase = clase; this.race = race; this.skin = skin; this.hair = hair; this.genere = genere;
            this.agilidad = agilidad; this.carisma = carisma; this.combate = combate; this.constitucion = constitucion; this.destreza = destreza; this.inteligencia = inteligencia; this.invocacion = invocacion; this.ingenio = ingenio; this.fuerza = fuerza; this.percepcion = percepcion; this.precision = precision; this.resistencia = resistencia; this.suerte = suerte;
        }

        public Object Clone()
        {
            int i;
            Personaje clone = (Personaje)this.MemberwiseClone();
            clone.name = String.Copy(name);
            clone.clase = String.Copy(clase);
            clone.race = String.Copy(race);
            clone.skin = String.Copy(skin);
            clone.hair = String.Copy(hair);
            bag = (Item[])bag.Clone();
            for (i = 0; i < bag.Length; i++)
            {
                if (bag[i] != null)
                {
                    clone.bag[i] = (Item)bag[i].Clone();
                }
            }
            bag = (Item[])bag.Clone();
            for (i = 0; i < spells.Length; i++)
            {
                if (spells[i] != null)
                {
                    clone.spells[i] = (Spell)spells[i].Clone();
                }
            }
            return clone;
        }

        public override bool Equals(Object o)
        {
            bool answer = false;
            int i;
            if(o != null && o is Personaje)
            {
                if( String.Equals(this.name, ((Personaje)o).name) &&
                    String.Equals(this.clase, ((Personaje)o).clase) &&
                    String.Equals(this.race, ((Personaje)o).race) &&
                    String.Equals(this.skin, ((Personaje)o).skin) &&
                    String.Equals(this.hair, ((Personaje)o).hair) &&
                    level == ((Personaje)o).level && age == ((Personaje)o).age &&
                    money == ((Personaje)o).money && health == ((Personaje)o).health &&
                    mana == ((Personaje)o).mana && energy == ((Personaje)o).energy &&
                    ki == ((Personaje)o).ki && magicdefense == ((Personaje)o).magicdefense &&
                    defense == ((Personaje)o).defense && stamina == ((Personaje)o).stamina &&
                    initiative == ((Personaje)o).initiative && agilidad == ((Personaje)o).agilidad &&
                    carisma == ((Personaje)o).carisma && combate == ((Personaje)o).combate &&
                    constitucion == ((Personaje)o).constitucion && destreza == ((Personaje)o).destreza &&
                    inteligencia == ((Personaje)o).inteligencia && invocacion == ((Personaje)o).invocacion &&
                    ingenio == ((Personaje)o).ingenio && fuerza == ((Personaje)o).fuerza &&
                    percepcion == ((Personaje)o).percepcion && precision == ((Personaje)o).precision &&
                    resistencia == ((Personaje)o).resistencia && suerte == ((Personaje)o).suerte
                    )
                {
                    answer = true;
                    for (i=0;i<spells.Length && answer;i++)
                    {
                        answer = answer && spells[i].Equals(((Personaje)o).spells);
                    }
                    for (i = 0; i < bag.Length && answer; i++)
                    {
                        answer = answer && bag[i].Equals(((Personaje)o).bag);
                    }
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
