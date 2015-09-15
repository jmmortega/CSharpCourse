using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Collections
{
    class Program
    {
        //NOTE: To reuse code, in this project there add the project CSharpCourse.ClassInterfacesAndStructs
        static void Main(string[] args)
        {
            ListOfVideos();
            StackOfCassetes();
            MyMediaCollection();
            QueueOfGenesisGames();

            Console.ReadKey();
        }
        
        private static void ListOfVideos()
        {
            List<VHSVideo> vhsVideos = new List<VHSVideo>();

            vhsVideos.Add(new VHSVideo(TimeSpan.FromMinutes(50)));
            vhsVideos.Add(new VHSVideo(TimeSpan.FromMinutes(73)));
            vhsVideos.Add(new VHSVideo(TimeSpan.FromMinutes(80)));
            vhsVideos.Add(new VHSVideo(TimeSpan.FromMinutes(101)));            
        }

        private static void StackOfCassetes()
        {
            Stack<CasetteMedia> stackOfCassetes = new Stack<CasetteMedia>();

            stackOfCassetes.Push(new CasetteMedia() { Name = "Rock 70" });
            stackOfCassetes.Push(new CasetteMedia() {Name = "Rock 80"});
            stackOfCassetes.Push(new CasetteMedia() { Name = "Rock 90" });

            CasetteMedia myFirstCassete = stackOfCassetes.Pop();
        }

        private static void MyMediaCollection()
        {
            Dictionary<int, Media> collection = new Dictionary<int, Media>();

            collection.Add(1, new VHSVideo(TimeSpan.FromMinutes(53)));
            collection.Add(2, new CasetteMedia());
            collection.Add(3, new GenesisGame());
            
            //Ups...
            collection.Add(1, new BetaVideo(TimeSpan.FromMinutes(63)));            
        }

        private static void QueueOfGenesisGames()
        {
            Queue<GenesisGame> genesisGames = new Queue<GenesisGame>();

            genesisGames.Enqueue(new GenesisGame() { Name = "Sonic 1" });
            genesisGames.Enqueue(new GenesisGame() { Name = "Sonic 2" });
            genesisGames.Enqueue(new GenesisGame() { Name = "Sonic 3" });

            //Nope! I don't play this game in a genesis...
            genesisGames.Enqueue(new NesGame() { Name = "Super Mario Bros" });

            GenesisGame whichSonic = genesisGames.Dequeue();


        }        
    }
}
