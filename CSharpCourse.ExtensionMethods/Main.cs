using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using CSharpCourse.ExtensionMethods;

namespace CSharpCourse.ExtensionMethodsMain
{
    public class Main
    {
        public void Main()
        {
            GenesisGame genesisGame = new GenesisGame();
            genesisGame.Stages = 3;
            int bosses = genesisGame.HowMuchBossesHere(3);

            
            
        }
    }
}
