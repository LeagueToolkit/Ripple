using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripple.BIN
{
    public class Entry<classType>
    {
        public uint Hash { get; set; }
        public classType Class { get; set; }

        public Entry(uint hash, classType @class)
        {
            this.Hash = hash;
            this.Class = @class;
        }

        public static implicit operator classType(Entry<classType> entry)
        {
            return entry.Class;
        }

        public static implicit operator uint(Entry<classType> entry)
        {
            return entry.Hash;
        }
    }
}
