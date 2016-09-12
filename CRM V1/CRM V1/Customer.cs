using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_V1
{
    class Customer
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public bool isActive { get; set; }


        public string fullName()
        {
            return string.Format("{0} {1}", fName, lName);
        }
    }
}
