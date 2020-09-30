using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exam
{
    class Group
    {
        public string GroupName { get; set; }
        public List<Student> Students;
        public Group(string GroupName)
        {
            this.GroupName = GroupName;
            Students = new List<Student>();

        }
        public static void AddGruop()
        {
        startgroupname:
            Console.ResetColor();
            Console.Write("Please write group name: ");
            string grpname = Console.ReadLine();
            if(grpname != "")
            {
                Group gr = new Group(grpname);
                MyList.Groups.Add(gr);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nGroup {gr.GroupName} create successfully\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease enter group name\n");
                goto startgroupname;
            }
        }

        public static void ShowGroupandAdd()
        {
            Console.ResetColor();
            if(MyList.Groups.Count > 0)
            {
                Group SelectedGroup = null;
                foreach (var group in MyList.Groups)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nGroup Name: {group.GroupName}\n");
                }
                Console.WriteLine("Please select Group name for List: ");
                string grpname = Console.ReadLine();
                bool isCorrectGroupName = false;
                foreach (var group in MyList.Groups)
                {
                    if(group.GroupName == grpname)
                    {
                        SelectedGroup = group;
                        break;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThere is not a group\n");
            }
        }
    }
}
