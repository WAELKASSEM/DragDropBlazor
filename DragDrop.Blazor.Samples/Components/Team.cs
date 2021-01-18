using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragDrop.Blazor.Samples.Components
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public Team()
        {
            Players = new List<Player>();
        }
    }
}
