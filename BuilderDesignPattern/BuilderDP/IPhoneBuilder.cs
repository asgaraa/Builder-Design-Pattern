using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public interface IPhoneBuilder
    {
        void GetPhonedata();
        void SetPrice();
        PhoneDB GetData();
    }
}
