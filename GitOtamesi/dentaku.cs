using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitOtamesi
{
    internal class dentaku
    {
        public int pushequal(string num1,string kigou,string num2)
        {
            int ans=0;
            if (kigou == "+")
            {
                ans=int.Parse(num1)+ int.Parse(num2);
            }
            return ans;
        }
    }
}
