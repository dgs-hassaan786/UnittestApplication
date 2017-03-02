using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Auto.Consoler
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericImplementor imp = new GenericImplementor();
            imp.GetPizza();

            Console.ReadKey();
            return;
            //datatypes
            //string functioning
            //Object

            //Boxing
            //Value type to object type
            int aa = 101;
            string bb = "Ri";

            object aa1 = aa;
            object bb1 = bb;            
            
            //Unboxing
            //Object type to value type conversion

            Object o1 = new Object();
            o1 = "Hassaan";
            string o1String = o1.ToString();

            object o2 = new object();
            o2 = 100;
            int o2Int = Convert.ToInt32(o2);


            Console.WriteLine("{0} {1}", o1String, o2Int);

        }
    }


    public class Dough
    {
        public string DoughName { get; set; }
    }

    public class Cheese
    {
        public string CheeseName { get; set; }
    }

    public class Ornament
    {
        public string OrnamentName { get; set; }
    }

    public class Pizza
    {
        Dough _classA;
        Cheese _classB;
        Ornament _classC;

        public Pizza()
        {
            _classA = new Dough();
            _classB = new Cheese();
            _classC = new Ornament();
        }

        public string MakePizza()
        {
            _classA.DoughName = "Dough1";
            _classB.CheeseName = "Cheese1";
            _classC.OrnamentName = "Ornament1";


            return _classA.DoughName + " " + _classB.CheeseName + " " + _classC.OrnamentName;
        }

    }

    public class GenericImplementor
    {
        Pizza Pizza = new Pizza();

        public void GetPizza()
        {
            Console.WriteLine(Pizza.MakePizza());
        }
    }

}
