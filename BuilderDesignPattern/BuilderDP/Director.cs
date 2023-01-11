using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Director
    {
        public void PhoneGenerator(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.GetPhonedata();
            phoneBuilder.SetPrice();
        }
    }
}
