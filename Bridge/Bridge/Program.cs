using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            Console.WriteLine("---------------Programing in C++ ---------------");
            Console.WriteLine();
            freelancer.DoWork();
            freelancer.EarnMoney();
            Console.WriteLine();
            freelancer.Language = new CSharpLanguage();
            Console.WriteLine("---------------Programing in C# ---------------");
            Console.WriteLine();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.ReadLine();
        }
    }
}
