using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Services
{
    static class MenuService
    {
        public static CourseService courseService = new CourseService();
         public static void CreateGroupMenu()
		{
            Console.WriteLine("Please choose the category");
            foreach (var c in Enum.GetValues(typeof(ClassCategory)))
            {
                Console.WriteLine($"{(int)c}.{c}");
            }
            int category;
            string categoryStr = Console.ReadLine();
            bool categoryResult = int.TryParse(categoryStr, out category);
            if (categoryResult)
            {
                switch (category)
                {
                    case 1:
                        string No = courseService.CreateGroup(ClassCategory.Programming);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    case 2:
                         No = courseService.CreateGroup(ClassCategory.Design);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    case 3:
                         No = courseService.CreateGroup(ClassCategory.SystemAdminstration);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    default:
                        break;
                }
            }
          
        }
        public static void EditGroupsMenu()
        {
            Console.WriteLine("Please enter group number that you want to change:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Please enter new group number:");
            string newgroupNo = Console.ReadLine();
            courseService.EditGroups(groupNo, newgroupNo);

        }
        public static void GetGroupsMenu()
        {
            courseService.GetGroups();
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Please enter students informations");
            string studfullname = Console.ReadLine();
            foreach (var e in Enum.GetValues(typeof(EducationType)))
            {
                Console.WriteLine($"{(int)e}.{e}");
            }
            int edutype;
            string edutyoeStr = Console.ReadLine();
            bool eduResult = int.TryParse(edutyoeStr, out edutype);

            switch (edutype)
            {
                case 1:
                    Console.WriteLine( EducationType.Guarranted);
                    break;
                case 2:
                    Console.WriteLine(EducationType.non_Guarranted);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Choose Group");
            foreach (var e in Enum.GetValues(typeof(ClassCategory)))
            {
                Console.WriteLine($"{(int)e}.{e}");
            }

            int category;
            string catStr = Console.ReadLine();
            bool catResult = int.TryParse(catStr, out category);
            int count = 1;
            
            switch (category)
            {
                case 1:
                    string  No = "P" + count;
                    Console.WriteLine(No);
                    break;
                case 2:
                    No = "D" + count;
                    Console.WriteLine(No);
                    break;
                case 3:
                    No = "SA" + count;
                    Console.WriteLine(No);
                    break;
                default:
                    break;
            }
            courseService.CreateStudent(studfullname, edutype, category);
            count++;
        }
        public static void GetGroupsStudentsMenu()
        {
            Console.WriteLine("Please enter group number");
            string groupno = Console.ReadLine();
            courseService.GetGroupStudent(groupno);
        }
        public static void  GetAllStudentsMenu()
        {
            courseService.GetAllStdents();
        }
        }
}