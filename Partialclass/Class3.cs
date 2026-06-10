using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    partial class Multimedia
    {
        
        internal void Display()
        {
            Console.WriteLine("Display Content..");
        }
    }
    partial class Education
    {
        char grade;
        public Education(char grade)
        {
            this.grade = grade;
        }
        internal void HigherEducation()
        {
            Console.WriteLine("Students who are studying Masters"+grade);
        }
    }
    internal class Class3
    {
    }
}
