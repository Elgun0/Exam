using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exam
{
    class Teacher
    {
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public static int TeachId = 1;
        public Teacher(string Fullname, string Email, string Phone)
        {
            this.Id = TeachId;
            this.Fullname = Fullname;
            this.Email = Email;
            this.Phone = Phone;
            TeachId++;

        }
    }
}
