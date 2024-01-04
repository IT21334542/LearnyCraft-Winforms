using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Models
{
    internal class MarksHolder
    {
        public MarksHolder() { }
        public String StudentId { get; set; }
        public String StudentName { get; set;}
        public String ModuleName { get; set;}
        public String ModuleCode { get; set;}
        public int Marks { get; set;}
    }
}
