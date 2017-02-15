using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataProvider
{
    public class Calculator
    {
        public T Add<T>(T a, T b)
        {
            return (T)((dynamic)a + (dynamic)b);
        }

        public T Divide<T>(T a, T b)
        {
            return (T)((dynamic)a / (dynamic)b);
        }

        public T Multiply<T>(T a, T b)
        {
            return (T)((dynamic)a * (dynamic)b);
        }

        public T Subtract<T>(T a, T b)
        {
            return (T)((dynamic)a - (dynamic)b);
        }

        public T Modulus<T>(T a, T b)
        {
            return (T)((dynamic)a % (dynamic)b);
        }
    }
}
