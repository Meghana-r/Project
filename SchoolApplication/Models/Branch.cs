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
    
    public partial class Branch
    {
        public Branch()
        {
            this.ApplicationForms = new HashSet<ApplicationForm>();
        }
    
        public int branch_id { get; set; }
        public string contact_person { get; set; }
        public string location { get; set; }
    
        public virtual ICollection<ApplicationForm> ApplicationForms { get; set; }
    }
}
