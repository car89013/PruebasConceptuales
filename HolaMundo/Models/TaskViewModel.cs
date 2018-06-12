﻿using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Models
{
    public class TaskViewModel : IGanttTask
    {
        public int TaskID { get; set; }
        public int? ParentID { get; set; }

        public string Title { get; set; }

        private DateTime start;
        public DateTime Start
        {
            get { return start; }
            set { start = value.ToUniversalTime(); }
        }

        private DateTime end;
        public DateTime End
        {
            get { return end; }
            set { end = value.ToUniversalTime(); }
        }

        public bool Summary { get; set; }
        public bool Expanded { get; set; }
        public decimal PercentComplete { get; set; }
        public int OrderId { get; set; }
    }
}