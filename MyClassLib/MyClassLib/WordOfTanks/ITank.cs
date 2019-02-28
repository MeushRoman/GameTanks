using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public interface ITank
    {

        string Name { get; }
        int AmmunitionLvl { get; }
        int ArmorLvl { get; }
        int AgilityLvl { get; }

        string GetInfo();

    } 
}
