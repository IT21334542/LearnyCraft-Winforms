using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Models
{
    internal class MarksModel
    {
        public MarksModel() { }
        
        public String Studentid { get; set; }
        public String ModuleId {  get; set; }
        public int Marks { get; set; }
    }
}
