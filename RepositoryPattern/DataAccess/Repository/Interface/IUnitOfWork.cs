using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repository.Interface
{
    interface IUnitOfWork
    {
        IUserRepository User { get; }
        int Complete();
    }
}
