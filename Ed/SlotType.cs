﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ed
{
    public partial class EdTypes
    {
        public class SlotType // a.k.a. Spoiler Type
        {
            public uint CarTypeNameHash;
            public uint CarSlotID;
            public uint SlotTypeHash; // SPOILER, SPOILER_CARRERA, SPOILER_HATCH, SPOILER_PORSCHES
            public uint SlotType2Hash; // SPOILER_AS2, SPOILER_CARRERA_AS2, SPOILER_HATCH_AS2, SPOILER_PORSCHES_AS2
            public uint SlotType3Hash; // 0xC2F6EBB0 = SPOILER_AS
            public uint SlotType4Hash;
            public uint SlotType5Hash;
            public uint SlotType6Hash;
        }
    }
}
