using GameFrameWork.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork.CharacterTypes
{
    public class RPG
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int XPLevel { get; set; }
        public List<GameFrameWork.CharacterProperties.Stat> Stats { get; set; }
        public List<GameFrameWork.CharacterProperties.Affinity> Resistances { get; set; }
        public List<GameFrameWork.CharacterProperties.Ability> Abilities { get; set; }
        public List<GameFrameWork.CharacterProperties.Spell> Spells { get; set; }

        RPG()
        {
            //Defaults
        }
    }
}
