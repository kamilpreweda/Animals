﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Wolf : Canine, IPackHunter
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack) Console.WriteLine("Należę do stada.");
            Console.WriteLine("Auuuuuuuu!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack) Console.WriteLine("Wybieram się na polowanie z moim stadem!");
            else Console.WriteLine("Nie należę do stada.");
        }
    }
}
