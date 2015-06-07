using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.LinqI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VHSVideo> myVideoLibrary = GetMyVideoLibrary();

            var actionMovies = myVideoLibrary.Where(x => x.Genre == VideoGenre.Action);

            //Instead of

            List<VHSVideo> oldWayActionMovies = new List<VHSVideo>();

            foreach(var videoMovie in myVideoLibrary)
            {
                if(videoMovie.Genre == VideoGenre.Action)
                {
                    oldWayActionMovies.Add(videoMovie);
                }
            }

            //Select allows convert collection in another one. 
            //For sample, Director Cuts include 10 minutes more of duration we include with select.
            var directorCutsMovies = myVideoLibrary.Select(x => x.Duration.Add(TimeSpan.FromMinutes(10)));

            //Instead of
            
            foreach(var videoMovie in myVideoLibrary)
            {
                videoMovie.Duration.Add(TimeSpan.FromMinutes(10));
            }


            if(myVideoLibrary.Any(x => x.Name == "Jurasic Park"))
            {
                Console.WriteLine("I have in my library, Jurasic Park movie!");
            }

            //Instead of

            foreach(var videoMovie in myVideoLibrary)
            {
                if(videoMovie.Name == "Jurasic Park")
                {
                    Console.WriteLine("I have in my library, Jurasic Park movie!");
                }
            }

            //The most of linq queries return IEnumerable<T> for this reason you may join several Linq queries in only line.

            var actionDirectorCutsMovies = myVideoLibrary.Where(x => x.Genre == VideoGenre.Action).Select(x => x.Duration.Add(TimeSpan.FromMinutes(10)));

            //Instead of

            List<VHSVideo> oldWayActionDirectorCutMovies = new List<VHSVideo>();

            foreach(var videoMovie in myVideoLibrary)
            {
                if(videoMovie.Genre == VideoGenre.Action)
                {
                    videoMovie.Duration.Add(TimeSpan.FromMinutes(10));
                    oldWayActionDirectorCutMovies.Add(videoMovie);
                }
            }

            Console.ReadKey();
        }

        private static List<VHSVideo> GetMyVideoLibrary()
        {
            List<VHSVideo> videoMedia = new List<VHSVideo>();

            videoMedia.Add(new VHSVideo(TimeSpan.FromMinutes(70)) { Name = "Jurasic Park" , Genre = VideoGenre.Action });
            videoMedia.Add(new VHSVideo(TimeSpan.FromMinutes(70)) { Name = "Die Hard" , Genre = VideoGenre.Action });
            videoMedia.Add(new VHSVideo(TimeSpan.FromMinutes(70)) { Name = "Die Hard 2" , Genre = VideoGenre.Action});
            videoMedia.Add(new VHSVideo(TimeSpan.FromMinutes(70)) { Name = "Toy Story" , Genre = VideoGenre.Animation});
            videoMedia.Add(new VHSVideo(TimeSpan.FromMinutes(70)) { Name = "American Pie" , Genre = VideoGenre.Comedy});

            return videoMedia;

        }
    }
}
