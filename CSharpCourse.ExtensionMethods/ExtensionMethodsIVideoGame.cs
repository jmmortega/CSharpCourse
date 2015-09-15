using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ExtensionMethods
{
    public static class ExtensionMethodsIVideoGame
    {
        public static int HowMuchBossesHere(this IVideoGame videoGame , int bossesPerStage)
        {
            return videoGame.Stages / bossesPerStage;
        }
    }
}
