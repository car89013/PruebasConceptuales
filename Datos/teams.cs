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
    
    public partial class teams
    {
        public teams()
        {
            this.act_activities = new HashSet<act_activities>();
            this.act_budget = new HashSet<act_budget>();
            this.budget = new HashSet<budget>();
            this.fund_activities = new HashSet<fund_activities>();
            this.fund_budget = new HashSet<fund_budget>();
            this.tecno_budget = new HashSet<tecno_budget>();
            this.uni_activities = new HashSet<uni_activities>();
            this.uni_budget = new HashSet<uni_budget>();
        }
    
        public int id_team { get; set; }
        public string team_name { get; set; }
    
        public virtual ICollection<act_activities> act_activities { get; set; }
        public virtual ICollection<act_budget> act_budget { get; set; }
        public virtual ICollection<budget> budget { get; set; }
        public virtual ICollection<fund_activities> fund_activities { get; set; }
        public virtual ICollection<fund_budget> fund_budget { get; set; }
        public virtual ICollection<tecno_budget> tecno_budget { get; set; }
        public virtual ICollection<uni_activities> uni_activities { get; set; }
        public virtual ICollection<uni_budget> uni_budget { get; set; }
    }
}
