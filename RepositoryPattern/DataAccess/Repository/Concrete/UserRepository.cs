using RepositoryPattern.DataAccess.Domain;
using RepositoryPattern.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repository.Concrete
{
    class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SampleContext context) : base(context) { 
        
        }

        public User GetUserWithAddress(int id)
        {
            return SampleContext.Users.Include("Address").SingleOrDefault(x => x.UserId == id);
        }
        public SampleContext SampleContext
        {
            get
            {
                return Context as SampleContext;
            }
        }
    }
}
