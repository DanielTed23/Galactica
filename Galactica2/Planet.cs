using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica2
{
    // skal nedarve fra spaceobjets
    internal class Planet : SpaceObject
    {

        //Tilføj følgende properties: PlanetType, Diameter i m, RotationPeriod i timer,
        //RevolutionPeriod i dage 
        public double Diamter { get; set; }
        public double RotationsPeriod { get; set; }

        public double RevolutionPeriod { get; set; }
        public object PlanetType { get; set; }
        public object Type { get; internal set; }


        //tilføj en liste over Moon
        public List<Moon> moonList = new List<Moon>();
        public void Distance(Position first, Position second)

        {

            double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
        }


    }
}
