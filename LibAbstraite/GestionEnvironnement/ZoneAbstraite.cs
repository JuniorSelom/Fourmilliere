using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAbstraite
{
    public abstract class ZoneAbstraite
    {
        
        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract List<ObjetAbstrait> ObjetsList {get;set;}

        //public abstract void AjouteAcces(AccesAbstrait acces);
        public abstract void AjouteObjet(ObjetAbstrait unObjet);
        public abstract void AjoutePersonnage(PersonnageAbstrait unPersonnage);
        public abstract void RetirerPersonnage(PersonnageAbstrait unPersonnage);
       // public (int x, int y);

    }
}
