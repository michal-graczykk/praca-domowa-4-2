using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa4_2
{
    class GetString
    {
        public string FizzBuzz(int argument)
        {
            if ((argument % 3 == 0) && (argument % 5 == 0))
                return "FizzBuzz";

            else if (argument % 3 == 0)
                return "Fizz";

            else if (argument % 5 == 0)
                return "Buzz";
            //else
            //    return " ";
            else
                return argument.ToString();
        }
    }
}
