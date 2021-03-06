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
    
    public partial class master_followup
    {
        public master_followup()
        {
            this.activities = new HashSet<activities>();
            this.budget = new HashSet<budget>();
            this.programs_months = new HashSet<programs_months>();
            this.projectvsclusters = new HashSet<projectvsclusters>();
            this.table_project_mark_bricks = new HashSet<table_project_mark_bricks>();
            this.table_project_rd = new HashSet<table_project_rd>();
            this.table_project_rd1 = new HashSet<table_project_rd>();
            this.table_project_tecno_bricks = new HashSet<table_project_tecno_bricks>();
        }
    
        public int id_project { get; set; }
        public Nullable<int> site { get; set; }
        public Nullable<int> seat_class { get; set; }
        public string project_name { get; set; }
        public string customer { get; set; }
        public Nullable<int> Status { get; set; }
        public string progress { get; set; }
        public Nullable<int> type_supp { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public string target_event { get; set; }
        public string program_man { get; set; }
        public Nullable<int> r_d_leader { get; set; }
        public string tec_bricks { get; set; }
        public string mark_bricks { get; set; }
        public Nullable<System.DateTime> phase1 { get; set; }
        public Nullable<System.DateTime> phase2 { get; set; }
        public Nullable<System.DateTime> phase3 { get; set; }
        public Nullable<System.DateTime> phase4 { get; set; }
        public Nullable<System.DateTime> phase5 { get; set; }
        public Nullable<System.DateTime> phase6 { get; set; }
        public Nullable<System.DateTime> phase7 { get; set; }
        public Nullable<System.DateTime> phase8 { get; set; }
        public Nullable<System.DateTime> phase9 { get; set; }
        public string charge_bu { get; set; }
        public string planned_budget { get; set; }
        public string actual_budget { get; set; }
        public Nullable<int> p1_file { get; set; }
        public Nullable<int> p2_file { get; set; }
        public Nullable<int> p3_file { get; set; }
        public Nullable<int> p4_file { get; set; }
        public Nullable<int> p5_file { get; set; }
        public Nullable<int> p6_file { get; set; }
        public Nullable<int> p7_file { get; set; }
        public Nullable<int> p8_file { get; set; }
        public Nullable<int> p9_file { get; set; }
        public Nullable<int> project_num { get; set; }
        public string scope { get; set; }
        public string project_deliverables { get; set; }
        public Nullable<int> image_id { get; set; }
        public Nullable<int> sub_category { get; set; }
        public Nullable<int> cancel { get; set; }
        public Nullable<int> type_project { get; set; }
        public Nullable<int> p1_file_n { get; set; }
        public Nullable<int> p2_file_n { get; set; }
        public Nullable<int> p3_file_n { get; set; }
        public Nullable<int> p4_file_n { get; set; }
        public Nullable<int> p5_file_n { get; set; }
        public Nullable<int> p6_file_n { get; set; }
        public Nullable<int> p7_file_n { get; set; }
        public Nullable<int> p8_int_n { get; set; }
        public Nullable<int> p9_int_n { get; set; }
        public Nullable<System.DateTime> phase10 { get; set; }
        public Nullable<System.DateTime> phase11 { get; set; }
        public Nullable<System.DateTime> phase12 { get; set; }
        public Nullable<System.DateTime> phase13 { get; set; }
        public Nullable<System.DateTime> phase14 { get; set; }
        public Nullable<System.DateTime> phase15 { get; set; }
        public Nullable<System.DateTime> phase16 { get; set; }
        public Nullable<int> p10_file { get; set; }
        public Nullable<int> p11_file { get; set; }
        public Nullable<int> p12_file { get; set; }
        public Nullable<int> p13_file { get; set; }
        public Nullable<int> p14_file { get; set; }
        public Nullable<int> p15_file { get; set; }
        public Nullable<int> p16_file { get; set; }
        public Nullable<double> baseline { get; set; }
        public string zen_link { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<int> duration_month { get; set; }
        public string number_months { get; set; }
    
        public virtual ICollection<activities> activities { get; set; }
        public virtual ICollection<budget> budget { get; set; }
        public virtual follow_files follow_files { get; set; }
        public virtual follow_files follow_files1 { get; set; }
        public virtual follow_files follow_files2 { get; set; }
        public virtual follow_files follow_files3 { get; set; }
        public virtual follow_files follow_files4 { get; set; }
        public virtual follow_files follow_files5 { get; set; }
        public virtual follow_files follow_files6 { get; set; }
        public virtual follow_files follow_files7 { get; set; }
        public virtual follow_files follow_files8 { get; set; }
        public virtual follow_files follow_files9 { get; set; }
        public virtual follow_files follow_files10 { get; set; }
        public virtual follow_files follow_files11 { get; set; }
        public virtual follow_files follow_files12 { get; set; }
        public virtual follow_files follow_files13 { get; set; }
        public virtual follow_files follow_files14 { get; set; }
        public virtual follow_files follow_files15 { get; set; }
        public virtual follow_files follow_files16 { get; set; }
        public virtual leader leader { get; set; }
        public virtual seat_class seat_class1 { get; set; }
        public virtual site site1 { get; set; }
        public virtual status status1 { get; set; }
        public virtual sub_category sub_category1 { get; set; }
        public virtual support_type support_type { get; set; }
        public virtual ICollection<programs_months> programs_months { get; set; }
        public virtual ICollection<projectvsclusters> projectvsclusters { get; set; }
        public virtual ICollection<table_project_mark_bricks> table_project_mark_bricks { get; set; }
        public virtual ICollection<table_project_rd> table_project_rd { get; set; }
        public virtual ICollection<table_project_rd> table_project_rd1 { get; set; }
        public virtual ICollection<table_project_tecno_bricks> table_project_tecno_bricks { get; set; }
    }
}
