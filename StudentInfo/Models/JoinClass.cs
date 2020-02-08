using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfo.Models
{
    public class JoinClass
    {

        public int id { get; set; }
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CourseID { get; set; }
        public string CourseName { get; set; }

        public virtual tblCours tblCours { get; set; }


    }
}