﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._72
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        void CannotChangeForEachIteationVariable()
        {
            //var people = new List<Person>
            //{
            //    new Person() {Firstname = "John", Lastname = "Doe"}
            //    new Person() {Firstname = "jane", Lastname = "Doe"}
            //};

            //foreach(Person p in people)
            //{
            //    p.Lastname = "Changed"; //This is allowed
            //    // p = new Person(); //this gives a complier error
            //}

            //List<Person>.Enumerator e = people.GetEnumerator();

            //try
            //{
            //    Person v;
            //    while (e.MoveNext())
            //    {
            //        v = e.Current;
            //    }
            //}
            //finally
            //{
            //    System.IDisposable d = e as System.IDisposable;
            //    if (d != null) d.Dispose();
            //}
        }


        static void Main()
        {

        }
    }
}
