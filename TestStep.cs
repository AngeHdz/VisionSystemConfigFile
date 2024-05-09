using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public enum TestStepType 
    {
        PatternMatch,
        IA,

    }

    public class TestStep
    {
        public string TestStepName { get; set; } = string.Empty;
        public TestStepType StepType { get; set; }

        public string ROIName { get; set; }

        public string Category {  get; set; }

    }
}
