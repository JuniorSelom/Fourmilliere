using System;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FourmiliereMOC2
{
    public class Fourmi
    {
        static Random Hazard = new Random();
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int Vie { get; set; }
        public string Description { get;set;}

        public ObservableCollection<Etape> EtapesList { get; set; }

        public Fourmi() { }
        public Fourmi(int elX, int elY, int vie , string elName) 
        {
            this.X = elX;
            this.Y = elY;
            this.Name = elName;
            Vie = vie;
            int nbEtapes = Hazard.Next(10);
            Description = Name + " Vie:" + Vie;
            EtapesList = new ObservableCollection<Etape>();
            for (int i = 0; i < nbEtapes; i++)
            {
                EtapesList.Add(new Etape());
            }
        
        }
        public Fourmi(int maxDimX, int maxDimY, string aName = "Anonyme" )
        {
            Name = aName;
            X = Hazard.Next(maxDimX);
            Y = Hazard.Next(maxDimY);
            Vie = 100;
            Description = Name + " Vie:" +Vie ;
            EtapesList = new ObservableCollection<Etape>();
            int nbEtapes = Hazard.Next(10);
            for (int i = 0; i < nbEtapes; i++)
            {
                EtapesList.Add(new Etape());
            }
        }

        public override string ToString()
        {
            return "(Brouillon) " + Name;
        }

        internal void AvanceUnTour(int dimX, int dimY)
        {
            AvanceAuHasard(dimX, dimY);
            EtapesList.Add(new Etape() { Lieu = X + "" + Y });
            Vie -= 1;
        }

        internal void test()
        {
            IList<Coord> listCord = new List<Coord>();
            foreach(var fourmi in App.FourmiliereVM.ListFourmis)
            {
                if (fourmi.X - 1 > 0 )
                {
                    listCord.Add(new Coord(-1 , 0));
                    listCord.Add(new Coord(-1 , 1));
                    listCord.Add(new Coord(-1 , 0));
                }
                if (fourmi.Y - 1 > 0)
                {
                    
                }
            }
        }
        
        public virtual void AnalyseSituation()
        {

        }

        internal void AvanceAuHasard(int dimensionX, int dimensionY)
        {
            int newX = X + Hazard.Next(3) - 1;
            int newY = Y + Hazard.Next(3) - 1;
            if ((newX >= 0) && (newX < dimensionX))
            {
                X = newX;
            }
            if ((newY >= 0) && (newY < dimensionY))
            {
                Y = newY;
            }
        }
    }
}