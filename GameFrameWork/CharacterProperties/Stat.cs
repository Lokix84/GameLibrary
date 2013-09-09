using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork.CharacterProperties
{
    public class Stat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GameFrameWork.Types.Modifier Type { get; set; }
        public int Value { get; set; }
    }
}
