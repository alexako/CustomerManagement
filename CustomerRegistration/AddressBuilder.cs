using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistration
{
    class AddressBuilder
    {
        private Address address = new Address();

        public AddressBuilder Address1(string addr1)
        {
            address.addr1 = addr1;
            return this;
        }

        public AddressBuilder Address2(string addr2)
        {
            address.addr2 = addr2;
            return this;
        }

        public AddressBuilder City(string city)
        {
            address.city = city;
            return this;
        }

        public AddressBuilder Province(string province)
        {
            address.province = province;
            return this;
        }

        public AddressBuilder Country(string country)
        {
            address.country = country;
            return this;
        }
    }
}
