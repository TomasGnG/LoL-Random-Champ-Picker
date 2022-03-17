using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_Champion_Randomizer
{
    
    public class Champion
    {
        public String ChampionName;
        public Image ChampionImage;

        public Champion(String championName, Image championImage)
        {
            ChampionName = championName;
            ChampionImage = championImage;
        }

    }
}
