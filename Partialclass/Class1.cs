using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    partial class Multimedia
    {
        
        internal void AudioPlay()
        {
            Console.WriteLine("Audio is Playing...");
        }
    }
    partial class Education
    {
        string sub;
        public Education(string sub)
        {
            this.sub = sub;
        }
        internal void School()
        {
            Console.WriteLine("Students who are studying 1 to 10"+sub);
        }
    }
    internal class Class1
    {
    }
}
