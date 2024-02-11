using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ItalianChef: Chef
    {
        // extends the original class by adding a new method
        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");
        }

        // changes an existing method
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The italian chef makes chicken parm");
        }
    }
}
