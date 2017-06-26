using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class ObjetAbstrait
    {
        public abstract string Nom { get; set; }

        public abstract ZoneAbstraite Position {get;set;}

        public abstract string Type { get; set; }

        public ObjetAbstrait(ZoneAbstraite position, string pType)
        {
            Position = position;
            Type = pType;
        }

    }
}
