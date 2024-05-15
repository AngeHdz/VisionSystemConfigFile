using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public class Models
    {
        public required string ModelName {  get; set; }

        public List<TestStep> TestSteps { get; set; } = new List<TestStep> { };


    }
}
