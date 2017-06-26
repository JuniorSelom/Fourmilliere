using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAbstraite;

namespace LibMetier
{
    public class Fourmis : PersonnageAbstrait
    {
        protected static Random Hazard = new Random();
        public override string Name { get; set; }
        public override int X { get; set; }
        public override int Y { get; set; }
        public override int Vie { get; set; }

        public Fourmis(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
            
        }

        public override void AvanceAuHazard(ZoneAbstraite position)
        {
            throw new NotImplementedException();
        }

        public override void AvanceUnTour(ZoneAbstraite position)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite ChoixZoneSuivante(List<LibAbstraite.AccesAbstrait> accesList)
        {
            throw new NotImplementedException();
        }

        
        

    }
}
