using RepositoryPattern.DataAccess.Repository.Concrete;
using RepositoryPattern.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork iow = new UnitOfWork(new DataAccess.SampleContext());
            var user = iow.User.GetUserWithAddress(1);
        }
    }
}
