namespace Ripple.BIN
{
    public class Link<classType> where classType : class
    {
        public uint Hash { get; set; }

        public Link(uint hash)
        {
            this.Hash = hash;
        }

        public static implicit operator Link<classType>(uint hash)
        {
            return new Link<classType>(hash);
        }

        public static implicit operator uint(Link<classType> link)
        {
            return link.Hash;
        }
    }
}
