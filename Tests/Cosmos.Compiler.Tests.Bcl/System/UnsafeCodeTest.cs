﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Compiler.Tests.Bcl.System
{
    using Cosmos.TestRunner;

    unsafe class UnsafeCodeTest
    {
        static long DoubleToInt64Bits(double value)
        {
            return *(long*)(&value);
        }

        static ulong Test(ref ulong a)
        {
            a = 12345678;
            return a;
        }

        public static void Execute()
        {

            long val = Int64.MaxValue;
            long* p = &val;
            long newVal = *p;
            Assert.IsTrue(val == newVal, $"Pointer deferencing failed expected {val} got {newVal}");

            /* This the same thing BitConverter does to convert a Double to a Long it should fail in this case too */
            double d = 1.0;
            long asLong = *(long*)(&d);

            byte[] hexDump;
            hexDump = BitConverter.GetBytes(asLong);

            Assert.IsTrue(asLong == 0x3FF0000000000000, "double asLong is wrong!");

            ulong aLong = 0;
            ulong retVal;
            retVal = Test(ref aLong);

            Assert.IsTrue(retVal == 12345678, "Ulong ref passing not works");

            //asLong = DoubleToInt64Bits(d);
            //hexDump = BitConverter.GetBytes(asLong);

            //Console.WriteLine("asLong is : " + BitConverter.ToString(hexDump, 0));
            //Assert.IsTrue(asLong == 0x3FF0000000000000, "DoubleToInt64Bits is wrong!");


        }

    }
}
