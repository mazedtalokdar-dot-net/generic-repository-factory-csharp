using Project_Of_1291163.Fectories;
using Project_Of_1291163.Testify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Of_1291163
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFectory repoFectory = new RepoFectoy();
            Test test = new Test(repoFectory);
            test.Run();
            Console.ReadKey();
        }
    }
}
