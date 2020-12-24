using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car1 = new Auto("Ford", 400, 300000);
            Auto car2 = new Auto("Mazda");
            Auto car3 = new Auto();
            car1.display();
            car2.display();
            car3.display();
        }
    }
}
