using Project_Of_1291163.Models;
using Project_Of_1291163.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Of_1291163.Fectories
{
    public class RepoFectoy : IRepoFectory
    {
        public IRepo<T> CreateRepo<T>() where T : CommonFeild
        {
            return new GeniricRepo<T>();
        }
    }
}
