using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ freelancer works ]");

            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.WriteLine("[ corporate programmer works ]");

            Programmer corporateProgrammer = new CorporateProgrammer(new CSharpLanguage());
            corporateProgrammer.DoWork();
            corporateProgrammer.EarnMoney();

            Console.Read();
        }
    }
}