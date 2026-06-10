using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    sealed class Bank
    {
        int bid;
        string bname;
        string bbranch;
        public Bank(int bid, string bname, string bbranch)
        {
            this.bid = bid;
            this.bname = bname;
            this.bbranch = bbranch;
        }
        public void BankDisplay()
        {
            Console.WriteLine("Bank Id is :" + bid);
            Console.WriteLine("Bank Name is :" + bname);
            Console.WriteLine("Bank Branch is :" + bbranch);
        }
    }
    class dc //: Bank
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Multimedia m=new Multimedia();
            m.AudioPlay();
            m.VideoPlay();
            m.Display();
            Console.WriteLine("\n=====================\n");
            Education e=new Education();
            e.School();
            e.College();
            e.HigherEducation();
            Console.WriteLine("\n==========Sealed Class===========\n");
            Bank b = new Bank(1231, "ABC Bank", "Ameerpet Branch");
            b.BankDisplay();
        }
    }
}
