using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masab
{
  
    class Program
    {
        static void Main(string[] args)
        {
            LocalPhone phn = new LocalPhone();
            NationalPhone nphn = new NationalPhone();
            InternationalPhone intphn = new InternationalPhone();
            phn.getinput();
            phn.display();
            nphn.displayNationalphn();
            intphn.displayInterNationalphn();
        }
    }
     class LocalPhone
    {
        public static String Studentid = "";
        public String name = "";
        public void getinput()
        {
            Console.WriteLine("Assignment no 1: CS411");
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your VU Id");
            Studentid = Console.ReadLine();

        }
        public void display()
        {
            String localphn = "";
            char[] chars = Studentid.ToCharArray();
            for (int i = 2; i < 9; i++)
            {
                localphn += chars[i];
            }
            Console.WriteLine("Owner Name is " + name);
            Console.WriteLine("Local phn no is " + localphn);
        }
    }
     class NationalPhone : LocalPhone
    {

        public void displayNationalphn()
        {
            string nationalphn = "";
            char[] chars = Studentid.ToCharArray();
            for (int i = 2; i < 5; i++)
            {
                nationalphn += chars[i];
            }
            nationalphn += "-";
            for (int i = 2; i < 9; i++)
            {
                nationalphn += chars[i];
            }

            Console.WriteLine("National Phn No is " + nationalphn);

        }
    }
    class InternationalPhone : NationalPhone
    {
        public void displayInterNationalphn()
        {
            string Internationalphn = "+";
            char[] chars = Studentid.ToCharArray();
            for (int i = 9; i < 11; i++)
            {
                Internationalphn += chars[i];
            }
            Internationalphn += "-";
            for (int i = 2; i < 5; i++)
            {
                Internationalphn += chars[i];
            }
            Internationalphn += "-";
            for (int i = 2; i < 9; i++)
            {
                Internationalphn += chars[i];
            }

            Console.WriteLine("InterNational Phn No is " + Internationalphn);
            Console.Read();

        }
    }
}

}