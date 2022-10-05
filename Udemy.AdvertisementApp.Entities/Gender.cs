using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.AdvertisementApp.Entities
{
    public class Gender : BaseEntity
    {
        public string Definition { get; set; }

        //Navigation Properties
        public List<AppUser> AppUsers { get; set; }
    }
}
