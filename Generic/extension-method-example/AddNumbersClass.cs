using System;
using System.Collections.Generic;
using System.Text;

namespace extension_method_example
{
    public static class AddNumbersClass
    {
        // extension method :
        public static string AddNumbers(this string value)
        {
            return value += "123";
        }
    }
}
