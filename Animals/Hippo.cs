using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Chrząkanie");
        }

        public void Swim()
        {
            Console.WriteLine("Plusk! Idę popływać");
        }
    }
}
