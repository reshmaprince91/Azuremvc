using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class quoteModel
    {
        public int quoteid { get; set; }
        public string quotetype { get; set; }
        public string contact { get; set; }
        public string description { get; set; }
        public string duedate { get; set; }
        public string tasktype { get; set; }
    }
}