﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    public delegate void Int32Action(int value);

    public interface IInt32Action
    {
        void DoIt(int value);
    }

    public class Delegates : IInt32Action
    {
        string name;

        public Delegates(string name)
        {
            this.name = name;
        }

        public Delegates() : this("unknown")
        {
            
        }

        public void DoIt(int value)
        {
            Console.WriteLine("Interface Implementation: {0}", value);
        }

       public void  RandomRob(int value)
        {      
            Console.WriteLine("{0}: Delegate Implementation: {1}", name, value);     
        }

       public static void StaticRob(int value)
       {
           Console.WriteLine("Static Method 1: {0}", value);
       }

       public static void StaticRob2(int value)
       {
           Console.WriteLine("Static Method 2: {0}", value);
       }
    }  
}
