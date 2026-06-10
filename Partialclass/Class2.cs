using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    partial class Multimedia
    {
       
        
        internal void VideoPlay()
        {
            Console.WriteLine("Video is Playing...");
        }
    }
    partial class Education
    {
        int marks;
        public Education(int marks)
        {
            this.marks = marks;
        }
        internal void College()
        {
            Console.WriteLine("Student who are studying ofter 10th"+marks);
        }
    }
    internal class Class2
    {
    }
}
