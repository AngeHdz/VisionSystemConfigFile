using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public class ProcessClass 
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ProcessClass(string name, string type)
        {
            Name = name;
            this.Type = type;
        }   
    }
}
