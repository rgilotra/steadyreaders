using RepositoryPattern.DataAccess.Domain;
using RepositoryPattern.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repository.Concrete
{
    class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(SampleContext context) : base(context) { 
            
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
