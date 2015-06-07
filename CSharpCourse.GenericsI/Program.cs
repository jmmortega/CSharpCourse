using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.GenericsI
{
    class Program
    {
        //NOTE: To reuse code, in this project there add the project CSharpCourse.ClassInterfacesAndStructs
        static void Main(string[] args)
        {
            Library<IVideoMedia> videoLibrary = new Library<IVideoMedia>();

            VHSVideo jurasicPark = new VHSVideo(TimeSpan.FromMinutes(80));
            BetaVideo madMax = new BetaVideo(TimeSpan.FromMinutes(74));
            CasetteMedia rock80 = new CasetteMedia();

            videoLibrary.Add(jurasicPark);
            videoLibrary.Add(madMax);

            //We instance a generic Library with type IVideoMedia interface, then, we only include objects with this interface.
            videoLibrary.Add(rock80);

            Console.WriteLine(videoLibrary.CountOfTitles);
            Console.WriteLine(videoLibrary.LastTitleAdded);


            Console.ReadKey();
        }
    }
}
