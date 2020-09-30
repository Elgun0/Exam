using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exam
{
    class Exam
    {
        public string ExamName  { get; set; }
        public DateTime ExamDate  { get; set; }
        public Exam(string ExamName,DateTime ExamDate)
        {
            this.ExamName = ExamName;
            this.ExamDate = ExamDate;
        }
    }
}
