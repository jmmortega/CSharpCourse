using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    //This is an abstract class, you don't instance a abstract class
    public abstract class Media
    {
        //This a event, allow notificates state
        public event EventHandler OnPlaying;
        public event EventHandler OnStop;

        public Media()
        {}
            
        public Media(TimeSpan duration , MediaQuality quality)            
        {
            Duration = duration;
            Quality = quality;
        }

        public TimeSpan Duration { get; set; }
        public MediaQuality Quality { get; set; }
        public string Name { get; set; }

        //When method include virtual, this method may override
        public virtual void Play()
        {
            Console.WriteLine(string.Format("Play {0}", Name));

            if(OnPlaying != null)
            {
                var raisedEvent = OnPlaying;
                raisedEvent(this, new EventArgs());
            }
        }

        public virtual void Stop()
        {
            Console.WriteLine(string.Format("Stop {0}", Name));

            if(OnStop != null)
            {
                var raisedEvent = OnStop;
                raisedEvent(this, new EventArgs());
            }
        }

        //Remember! All of types inherit the System.Object class
        public override string ToString()
        {
            return Name;
        }
    }
}
