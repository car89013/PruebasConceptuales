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
    
    public partial class follow_files
    {
        public follow_files()
        {
            this.mark_bricks = new HashSet<mark_bricks>();
            this.mark_bricks1 = new HashSet<mark_bricks>();
            this.master_activities = new HashSet<master_activities>();
            this.master_followup = new HashSet<master_followup>();
            this.master_followup1 = new HashSet<master_followup>();
            this.master_followup2 = new HashSet<master_followup>();
            this.master_followup3 = new HashSet<master_followup>();
            this.master_followup4 = new HashSet<master_followup>();
            this.master_followup5 = new HashSet<master_followup>();
            this.master_followup6 = new HashSet<master_followup>();
            this.master_followup7 = new HashSet<master_followup>();
            this.master_followup8 = new HashSet<master_followup>();
            this.master_followup9 = new HashSet<master_followup>();
            this.master_followup10 = new HashSet<master_followup>();
            this.master_followup11 = new HashSet<master_followup>();
            this.master_followup12 = new HashSet<master_followup>();
            this.master_followup13 = new HashSet<master_followup>();
            this.master_followup14 = new HashSet<master_followup>();
            this.master_followup15 = new HashSet<master_followup>();
            this.master_followup16 = new HashSet<master_followup>();
            this.master_fund = new HashSet<master_fund>();
            this.master_fund1 = new HashSet<master_fund>();
            this.master_fund2 = new HashSet<master_fund>();
            this.master_fund3 = new HashSet<master_fund>();
            this.master_fund4 = new HashSet<master_fund>();
            this.master_fund5 = new HashSet<master_fund>();
            this.master_fund6 = new HashSet<master_fund>();
            this.master_fund7 = new HashSet<master_fund>();
            this.master_fund8 = new HashSet<master_fund>();
            this.master_fund9 = new HashSet<master_fund>();
            this.master_fund10 = new HashSet<master_fund>();
            this.master_fund11 = new HashSet<master_fund>();
            this.master_fund12 = new HashSet<master_fund>();
            this.master_fund13 = new HashSet<master_fund>();
            this.master_fund14 = new HashSet<master_fund>();
            this.master_fund15 = new HashSet<master_fund>();
            this.master_fund16 = new HashSet<master_fund>();
            this.master_uni = new HashSet<master_uni>();
            this.master_uni1 = new HashSet<master_uni>();
            this.master_uni2 = new HashSet<master_uni>();
            this.master_uni3 = new HashSet<master_uni>();
            this.master_uni4 = new HashSet<master_uni>();
            this.master_uni5 = new HashSet<master_uni>();
            this.master_uni6 = new HashSet<master_uni>();
            this.master_uni7 = new HashSet<master_uni>();
            this.master_uni8 = new HashSet<master_uni>();
            this.master_uni9 = new HashSet<master_uni>();
            this.master_uni10 = new HashSet<master_uni>();
            this.master_uni11 = new HashSet<master_uni>();
            this.master_uni12 = new HashSet<master_uni>();
            this.master_uni13 = new HashSet<master_uni>();
            this.master_uni14 = new HashSet<master_uni>();
            this.master_uni15 = new HashSet<master_uni>();
            this.master_uni16 = new HashSet<master_uni>();
            this.tecno_bricks = new HashSet<tecno_bricks>();
            this.tecno_bricks1 = new HashSet<tecno_bricks>();
            this.tecno_bricks2 = new HashSet<tecno_bricks>();
            this.tecno_bricks3 = new HashSet<tecno_bricks>();
            this.tecno_bricks4 = new HashSet<tecno_bricks>();
            this.tecno_bricks5 = new HashSet<tecno_bricks>();
            this.tecno_bricks6 = new HashSet<tecno_bricks>();
            this.tecno_bricks7 = new HashSet<tecno_bricks>();
            this.tecno_bricks8 = new HashSet<tecno_bricks>();
            this.tecno_comments = new HashSet<tecno_comments>();
        }
    
        public int id_file { get; set; }
        public string file_name { get; set; }
        public byte[] file_data { get; set; }
        public string file_ext { get; set; }
        public string file_directory { get; set; }
        public string banner_directory { get; set; }
    
        public virtual ICollection<mark_bricks> mark_bricks { get; set; }
        public virtual ICollection<mark_bricks> mark_bricks1 { get; set; }
        public virtual ICollection<master_activities> master_activities { get; set; }
        public virtual ICollection<master_followup> master_followup { get; set; }
        public virtual ICollection<master_followup> master_followup1 { get; set; }
        public virtual ICollection<master_followup> master_followup2 { get; set; }
        public virtual ICollection<master_followup> master_followup3 { get; set; }
        public virtual ICollection<master_followup> master_followup4 { get; set; }
        public virtual ICollection<master_followup> master_followup5 { get; set; }
        public virtual ICollection<master_followup> master_followup6 { get; set; }
        public virtual ICollection<master_followup> master_followup7 { get; set; }
        public virtual ICollection<master_followup> master_followup8 { get; set; }
        public virtual ICollection<master_followup> master_followup9 { get; set; }
        public virtual ICollection<master_followup> master_followup10 { get; set; }
        public virtual ICollection<master_followup> master_followup11 { get; set; }
        public virtual ICollection<master_followup> master_followup12 { get; set; }
        public virtual ICollection<master_followup> master_followup13 { get; set; }
        public virtual ICollection<master_followup> master_followup14 { get; set; }
        public virtual ICollection<master_followup> master_followup15 { get; set; }
        public virtual ICollection<master_followup> master_followup16 { get; set; }
        public virtual ICollection<master_fund> master_fund { get; set; }
        public virtual ICollection<master_fund> master_fund1 { get; set; }
        public virtual ICollection<master_fund> master_fund2 { get; set; }
        public virtual ICollection<master_fund> master_fund3 { get; set; }
        public virtual ICollection<master_fund> master_fund4 { get; set; }
        public virtual ICollection<master_fund> master_fund5 { get; set; }
        public virtual ICollection<master_fund> master_fund6 { get; set; }
        public virtual ICollection<master_fund> master_fund7 { get; set; }
        public virtual ICollection<master_fund> master_fund8 { get; set; }
        public virtual ICollection<master_fund> master_fund9 { get; set; }
        public virtual ICollection<master_fund> master_fund10 { get; set; }
        public virtual ICollection<master_fund> master_fund11 { get; set; }
        public virtual ICollection<master_fund> master_fund12 { get; set; }
        public virtual ICollection<master_fund> master_fund13 { get; set; }
        public virtual ICollection<master_fund> master_fund14 { get; set; }
        public virtual ICollection<master_fund> master_fund15 { get; set; }
        public virtual ICollection<master_fund> master_fund16 { get; set; }
        public virtual ICollection<master_uni> master_uni { get; set; }
        public virtual ICollection<master_uni> master_uni1 { get; set; }
        public virtual ICollection<master_uni> master_uni2 { get; set; }
        public virtual ICollection<master_uni> master_uni3 { get; set; }
        public virtual ICollection<master_uni> master_uni4 { get; set; }
        public virtual ICollection<master_uni> master_uni5 { get; set; }
        public virtual ICollection<master_uni> master_uni6 { get; set; }
        public virtual ICollection<master_uni> master_uni7 { get; set; }
        public virtual ICollection<master_uni> master_uni8 { get; set; }
        public virtual ICollection<master_uni> master_uni9 { get; set; }
        public virtual ICollection<master_uni> master_uni10 { get; set; }
        public virtual ICollection<master_uni> master_uni11 { get; set; }
        public virtual ICollection<master_uni> master_uni12 { get; set; }
        public virtual ICollection<master_uni> master_uni13 { get; set; }
        public virtual ICollection<master_uni> master_uni14 { get; set; }
        public virtual ICollection<master_uni> master_uni15 { get; set; }
        public virtual ICollection<master_uni> master_uni16 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks1 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks2 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks3 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks4 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks5 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks6 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks7 { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks8 { get; set; }
        public virtual ICollection<tecno_comments> tecno_comments { get; set; }
    }
}