using Galactica2;
using static Galactica2.SpaceObject;

namespace Galactica2
{


    class Program
    {

        static void Main(string[] args)
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                Type = StarType.YellowDwarf.ToString(),
                Temperature = 5500

            };
        }
    }
}





        