using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODO_List.Models
{
    public class Tasks
    {
        public int id { get; set; }
        public string theme { get; set; }
        public string description { get; set; }
        public bool resolved { get; set; }
        public string date { get; set; }
    }
}