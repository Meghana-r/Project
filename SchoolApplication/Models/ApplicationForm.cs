//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationForm
    {
        public ApplicationForm()
        {
            this.ProcessedForms = new HashSet<ProcessedForm>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public System.DateTime dob { get; set; }
        public int age { get; set; }
        public Nullable<int> branch_id { get; set; }
        public int classid { get; set; }
        public string category { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual ICollection<ProcessedForm> ProcessedForms { get; set; }
    }
}
