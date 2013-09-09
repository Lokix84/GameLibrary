using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork.CharacterProperties
{
    public class Affinity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GameFrameWork.Types.Resistance Potency { get; set; }
        public GameFrameWork.Types.Status StatusType { get; set; }
        public GameFrameWork.Types.Element ElementType { get; set; }
    }
}
