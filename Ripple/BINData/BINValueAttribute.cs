using System;
using Fantome.Libraries.League.Helpers.Cryptography;

namespace Ripple.BIN
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BINValueAttribute : Attribute
    {
        public uint Hash { get; private set; }
        public bool IsHash { get; private set; }
        public bool IsLink { get; private set; }

        public BINValueAttribute(string name, bool isHash = false, bool isLink = false) : this(Cryptography.FNV32Hash(name), isHash, isLink)
        {

        }

        public BINValueAttribute(uint hash, bool isHash = false, bool isLink = false)
        {
            this.Hash = hash;
            this.IsHash = isHash;
            this.IsLink = isLink;
        }
    }
}
