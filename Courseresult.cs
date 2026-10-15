using System;
using System.ComponentModel.Design;


namespace ConsoleApp18
{
    internal class Courseresult
    {
        public string Studentname { get; set; }

        public int mark;

        public string Grade
        {
            get
            {
                if (mark > 100)
                    return "The Value Incorrect";

                if (mark >= 90)
                    return "A";
                else if (mark >= 80)
                    return "B";
                else if (mark >= 70)
                    return "C";
                else if (mark >= 60)
                    return "D";
                else
                    return "F";
            }

        }
    }
}