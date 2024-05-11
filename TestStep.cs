using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public enum TestStepType 
    {
        PatternMatch_ML,
        PatternMatch,
        IA
    }

    public class TestStep
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TestStepName { get; set; } = string.Empty;
        public TestStepType StepType { get; set; }

        public string ROI { get; set; }

        public string Category {  get; set; }

        public double LowLimit {  get; set; }
    }
}
