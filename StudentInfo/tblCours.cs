//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCours
    {
        public tblCours()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}