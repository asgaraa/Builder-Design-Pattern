using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class OldPhoneBuilder : IPhoneBuilder
    {
        PhoneDB model = new PhoneDB();
      

        public void GetPhonedata()
        {
            model.Brand = "Nokia";
            model.Model = "8800 shaphire";
        }

        public void SetPrice()
        {
            model.Price = "300";
        }
        public PhoneDB GetData()
        {
            return model;
        }
    }
}
