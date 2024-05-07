using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Day02TaskWeb.Schema
{
    internal class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public string location { get; set; }

        public int studentsCount { get; set; }
    }
}
