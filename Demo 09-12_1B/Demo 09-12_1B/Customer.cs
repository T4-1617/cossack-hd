﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_12_1B
{
    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);


        }
    }
}
