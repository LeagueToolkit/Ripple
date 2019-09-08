using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ripple.BIN.Classes;

namespace Ripple.Content
{
    public class MapData
    {
        public List<MapPointLightType> PointLightTypes { get; set; } = new List<MapPointLightType>();
        public MapData(Dictionary<Type, List<object>> serialized)
        {

        }
    }
}
