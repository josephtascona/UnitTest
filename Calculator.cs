﻿using System;

namespace UnitTest
{
    public class Calculator : IDisposable
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Subtraction(int first, int second)
        {
            //this method will never return -ve no. to demonstrate argument validations
            if (first < second)
            {
                throw new ArgumentException($"First number {first} is less than second number {second}");
            }

            return first - second;
        }
    }
}
