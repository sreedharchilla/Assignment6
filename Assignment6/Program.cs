﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        interface IStudent
        {
            void ShowDetails(int id, string name);
        }
        class DaySholar : IStudent
        {
            public void ShowDetails(int id, string name)
            {
                Console.WriteLine(" The Student Id is:{0}\nName of the student is:{1}", id, name);
            }
        }
        class Resident : IStudent
        {
            public void ShowDetails(int id, string name)
            {
                Console.WriteLine(" The Student id is:{0}\n Name of the Student is{1}", id, name);
            }
        }
        class InterfaceEg
        {
            static void Main()
            {
                Console.WriteLine("-----Dayscholar Details-----");
                IStudent d = new DaySholar();
                d.ShowDetails(1, "Pavan");

                Console.WriteLine("------Resident Scholar Details-----");
                IStudent r = new Resident();
                r.ShowDetails(2, "Kalyan");

            }
        }
    }
}
    