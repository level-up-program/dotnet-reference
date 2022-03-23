using System;

namespace dotnetexample
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        static void Main(string[] args) {
            
        }
    }
}