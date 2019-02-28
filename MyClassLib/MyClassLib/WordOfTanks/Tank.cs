using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank : ITank
    {
        public Tank() : this("") { }
        public Tank(string name) : this(name, 0) { }
        public Tank(string name, int ammunitionLvl) : this(name, ammunitionLvl, 0) { }
        public Tank(string name, int ammunitionLvl, int armorLvl) : this(name, ammunitionLvl, armorLvl, 0) { }
        public Tank(string name, int ammunitionLvl, int armorLvl, int agilityLvl)
        {
            Name = name;
            AmmunitionLvl = ammunitionLvl;
            ArmorLvl = armorLvl;
            AgilityLvl = agilityLvl;
        }

        public string Name { get; private set; }
        public int AmmunitionLvl { get; private set; }
        public int ArmorLvl { get; private set; }
        public int AgilityLvl { get; private set; }

        public string GetInfo()
        {
            string str = string.Format("Tank name: {0}\nAmmunition level: {1}\nArmor level: {2}\nAgility level: {3}", Name, AmmunitionLvl, ArmorLvl, AgilityLvl);
            return str;
        }

        public static bool operator *(Tank t1, Tank t2)
        {   
            int count = 0;
            if (t1.AgilityLvl > t2.AgilityLvl) count++;
            if (t1.ArmorLvl > t2.ArmorLvl) count++;
            if (t1.AgilityLvl > t2.AgilityLvl) count++;

            if (count >= 2) return true;
            else return false; 
        }
    }
}
