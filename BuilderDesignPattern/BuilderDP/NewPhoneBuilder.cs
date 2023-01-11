using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class NewPhoneBuilder : IPhoneBuilder
    {
        PhoneDB model = new PhoneDB();
       

        public void GetPhonedata()
        {
            model.Brand = "Apple";
            model.Model = "IPhone X";
        }

        public void SetPrice()
        {
            model.Price = "800";
        }
        public PhoneDB GetData()
        {
            return model;
        }
    }
}
