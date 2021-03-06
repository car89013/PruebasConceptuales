//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class master_activities
    {
        public master_activities()
        {
            this.act_activities = new HashSet<act_activities>();
            this.act_budget = new HashSet<act_budget>();
            this.acti_months = new HashSet<acti_months>();
            this.toolvscluster = new HashSet<toolvscluster>();
        }
    
        public int id_acti { get; set; }
        public Nullable<int> site { get; set; }
        public Nullable<int> seat_class { get; set; }
        public string project_name { get; set; }
        public string customer { get; set; }
        public Nullable<int> status { get; set; }
        public string progress { get; set; }
        public Nullable<int> type_supp { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public string target_event { get; set; }
        public string program_man { get; set; }
        public Nullable<int> r_d_leader { get; set; }
        public string planned_budget { get; set; }
        public string actual_budget { get; set; }
        public Nullable<int> project_num { get; set; }
        public string scope { get; set; }
        public string project_deliverable { get; set; }
        public Nullable<int> image_id { get; set; }
        public Nullable<int> sub_category { get; set; }
        public Nullable<int> cancel { get; set; }
        public Nullable<double> baseline { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<int> duration_month { get; set; }
        public string number_months { get; set; }
        public string zen_link { get; set; }
    
        public virtual ICollection<act_activities> act_activities { get; set; }
        public virtual ICollection<act_budget> act_budget { get; set; }
        public virtual ICollection<acti_months> acti_months { get; set; }
        public virtual follow_files follow_files { get; set; }
        public virtual leader leader { get; set; }
        public virtual seat_class seat_class1 { get; set; }
        public virtual site site1 { get; set; }
        public virtual status status1 { get; set; }
        public virtual sub_category sub_category1 { get; set; }
        public virtual support_type support_type { get; set; }
        public virtual ICollection<toolvscluster> toolvscluster { get; set; }
    }
}
