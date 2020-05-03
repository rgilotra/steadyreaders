using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Domain
{
    class User
    {
        [Key]
        public int UserId { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }
        

        //public int AddressId { get; set; }

        //[ForeignKey("AddressId")]
        //public virtual ICollection<Address> Addresses { get; set; }

    }
}
