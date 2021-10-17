using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Model
{
    class Group
    {
        public static int count = 100;
        public string No { get; set; }
        public ClassCategory Category { get; set; }
        public IsLine Line { get; set; }

        public List<Student> students = new List<Student>();
        public Group(ClassCategory category)
        {
            switch (category)
            {
                case ClassCategory.Programming:
                    No = "P" + count;
                    break;
                case ClassCategory.Design:
                    No = "D" + count;
                    break;
                case ClassCategory.SystemAdminstration:
                    No = "SA" + count;
                    break;
                default:
                    break;
            }
            Category = category;
            
            count++;
        }
        public override string ToString()
        {
            return $"No:{No},Category:{Category}";
        }
    }
}
