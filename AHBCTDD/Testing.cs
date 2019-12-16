using System;
using System.Collections.Generic;
using System.Text;

namespace AHBCTDD
{
    public class Testing
    {
        public string Name { get; set; }

        public static string AddString(Testing testObject)
        {
            return testObject.Name + "1234";
        }
    }
}
