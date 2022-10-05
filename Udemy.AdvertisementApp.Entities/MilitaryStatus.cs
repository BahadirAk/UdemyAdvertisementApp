using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.AdvertisementApp.Entities
{
    public class MilitaryStatus : BaseEntity
    {
        public string Definition { get; set; }

        //Navigation Properties
        public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
    }
}
