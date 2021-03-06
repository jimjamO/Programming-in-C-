﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1._6
{
    public static class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void Main()
        {
            new Thread(() =>
                {
                    for (int x = 0; x < _field.Value; x++)
                    {
                        Console.WriteLine("Thread A: {0}", x);
                    }
                }).Start();

            new Thread(() =>
                {
                    for (int x = 0; x < _field.Value; x++)
                    {
                        Console.WriteLine("Thread B: {0}", x);
                    }
                }).Start();

            Console.ReadKey();
        }
    }
}