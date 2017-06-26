using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Collections.ObjectModel;

namespace FourmiliereMOC2
{
    public  class Objets
    {
        static Random Hazard = new Random();
        public string Type;
        public int X;
        public int Y;



        public Objets(int elX , int elY , string elType ="nourriture")
        {
            Type = elType;
            X = elX;
            Y = elY;
        }

        internal void PlaceHasard(int dimensionX, int dimensionY)
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
