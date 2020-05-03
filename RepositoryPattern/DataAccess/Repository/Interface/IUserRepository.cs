using RepositoryPattern.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repository.Interface
{
    interface IUserRepository : IRepository<User>
    {
        User GetUserWithAddress(int id);
    }
}
