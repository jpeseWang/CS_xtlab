using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xtlab
{
    internal class CS22
    {

        public delegate void InputEvent(int x);


        class UserInput
        {
            public InputEvent inputEvent { get; set; }

            public void Input()
            {
                do
                {
                    Console.WriteLine("Input number: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    inputEvent?.Invoke(i);
                } while (true);
            }
        }

        class getSqrt
        {
            public void Sub(UserInput input)
            {
                input.inputEvent = Calculate;
            }
            public void Calculate(int i)
            {
                Console.WriteLine($"sqrt of {i} is {Math.Sqrt(i)}");
            }
        }
        //class Program
        //{


        //    static void Main(string[] args)
        //    {   //Publisher
        //        UserInput input = new UserInput();

        //        //Subscriber
        //        getSqrt getSqrt = new getSqrt();
        //        getSqrt.Sub(input);
        //        input.Input();
        //    }
        //}
    }
}
