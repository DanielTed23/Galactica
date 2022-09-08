using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Galactica2
{

    //Opret en ny klasse : Star
    // klassen nedarver fra spaceobjets
    class Star : SpaceObject
    {
        //Tilføj følgende properties: Type (Startype), Temperature
        public string Type { get; set; }
        public int Temperature { get; set; }

        //Tilføj en liste over Planet


        public List<Planet> planetList = new List<Planet>();

        public new Position position { get; }
        public Star()


        {
            this.position = new Position(0, 0);

        }
        enum StarType
        {
            YellowDwarf,
            White,
            BlueNeutron,
            RedGiant


        }
    }
}
