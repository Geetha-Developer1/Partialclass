using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    class validation
    {
        string Uname="abc";
        string PW="abc123";
        public void validate(string uname,string pw)
        {
            if(Uname==uname && pw ==PW)
            {
                Console.WriteLine("Login Successfully and These are your Details: ");
                Bank b = new Bank(1, "abc", "ameerpet");
                b.BankDisplay();
            }
        }
    }
    sealed class Bank:validation
    {
        int bid;
        string bname;
        string bbranch;
        public Bank()
        {

        }
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
            Bank b = new Bank();
            Console.WriteLine("Enter Username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pw=Console.ReadLine();
            b.validate(name,pw);
        }
    }
}
