using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            //You get a error here!
            Media media = new Media();

            //But not here...
            Media rock70 = new CasetteMedia(TimeSpan.FromMinutes(90));

            //Because we instance with base class 'Media' we can't access to properties from CasetteMedia class :(
            rock70.ArtistName = "V.A";

            CasetteMedia rock80 = new CasetteMedia(TimeSpan.FromMinutes(90));
            rock80.ArtistName = "V.A";
            rock80.Name = "Rock Hits 80'";
            rock80.Tracks = 17;            

            //Other way to instance, and initialize properties in a class
            CasetteMedia rock90 = new CasetteMedia()
            {
                Duration = TimeSpan.FromMinutes(90),
                ArtistName = "V.A",
                Tracks = 15
            };

            Console.ReadKey();
        }
    }
}
