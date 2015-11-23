﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{

    class Original
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Original
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Original original = new Original();
            Console.WriteLine(original.MyMethod());

            Derived derived = new Derived();
            Console.WriteLine(derived.MyMethod());

            //Declare Original as Derived
            Original polyOriginal = new Derived();
            Console.WriteLine(polyOriginal.MyMethod());

            Console.Read();
        }
    }
}
