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
    
    public partial class activities
    {
        public int id_act { get; set; }
        public string activity_name { get; set; }
        public string designer { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> ecd { get; set; }
        public Nullable<System.DateTime> completed { get; set; }
        public string description { get; set; }
        public Nullable<int> id_project { get; set; }
        public Nullable<double> hours { get; set; }
        public string phase { get; set; }
        public string team { get; set; }
        public Nullable<int> designer2 { get; set; }
    
        public virtual master_followup master_followup { get; set; }
    }
}