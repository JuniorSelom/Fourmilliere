using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class PersonnageAbstrait
    {
        protected static Random Hazard;
        public abstract string Name { get; set; }

        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract int Vie { get; set; }

        public abstract ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList);

        public abstract void AvanceUnTour(ZoneAbstraite position);

        public abstract void AvanceAuHazard(ZoneAbstraite position);
    }
}
