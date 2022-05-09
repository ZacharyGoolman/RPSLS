using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv3
{
    internal class Players
    {
        
            public List<string> Gestures = new List<string>();
            //Gestures.Add("Rock");
           public Players()
        {
            this.Gestures.Add("Rock");
            this.Gestures.Add("Paper");
            this.Gestures.Add("Scissors");
            this.Gestures.Add("Lizard");
            this.Gestures.Add("Spock");


        }

    }
}
