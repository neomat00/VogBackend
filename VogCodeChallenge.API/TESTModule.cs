using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public static class TESTModule
    {
        public static object Test(object Input)
        {
            switch (Input)
            {
                case 1: return multiply((int)Input);
                case int value when value > 4: return value * 3;
                case int value when value < 1: throw new Exception();
                case float FloatValue when Math.Abs(FloatValue) == 1.0f || Math.Abs(FloatValue) == 2.0f: return 3.0f;
                case string StringValue: return StringValue.ToUpper();
                default: return Input; 
            }

            int multiply(int number) => number * 2;

        }


    }
}
