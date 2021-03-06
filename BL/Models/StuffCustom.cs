﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class StuffCustom
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string Afname { get; set; }
        public string Alname { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime?JoinDate { get; set; }
        public DateTime? FiredDate { get; set; }
        public string Img { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> RoleId { get; set; }
    }
}
