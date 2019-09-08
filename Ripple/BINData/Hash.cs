using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripple.BIN
{
    public class Hash
    {
        public uint Value { get; set; }

        public Hash()
        {
            this.Value = 0;
        }

        public Hash(uint hash)
        {
            this.Value = hash;
        }

        public static implicit operator Hash(uint value)
        {
            return new Hash(value);
        }

        public static implicit operator uint(Hash hash)
        {
            return hash.Value;
        }
    }
}
