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
    
    public partial class fup_phases
    {
        public fup_phases()
        {
            this.act_activities = new HashSet<act_activities>();
            this.fund_activities = new HashSet<fund_activities>();
            this.uni_activities = new HashSet<uni_activities>();
        }
    
        public int id_phase { get; set; }
        public string phase_name { get; set; }
    
        public virtual ICollection<act_activities> act_activities { get; set; }
        public virtual ICollection<fund_activities> fund_activities { get; set; }
        public virtual ICollection<uni_activities> uni_activities { get; set; }
    }
}