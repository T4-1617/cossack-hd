using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_V2
{
    public class Employee
    {

        public string firstName { get; set; }

        public string lastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }
    }
}
