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
    
    public partial class seat_class
    {
        public seat_class()
        {
            this.master_activities = new HashSet<master_activities>();
            this.master_followup = new HashSet<master_followup>();
            this.master_fund = new HashSet<master_fund>();
            this.master_uni = new HashSet<master_uni>();
            this.tecno_bricks = new HashSet<tecno_bricks>();
        }
    
        public int id_seat_class { get; set; }
        public string seat_class_name { get; set; }
    
        public virtual ICollection<master_activities> master_activities { get; set; }
        public virtual ICollection<master_followup> master_followup { get; set; }
        public virtual ICollection<master_fund> master_fund { get; set; }
        public virtual ICollection<master_uni> master_uni { get; set; }
        public virtual ICollection<tecno_bricks> tecno_bricks { get; set; }
    }
}
