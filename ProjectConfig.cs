using EmguClass.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public enum CaptureType
    {
        Webcam,
        IndustrialCam,
        File,
    }
    public class ProjectConfig
    {
        public string Path { get; set; } = string.Empty;
        public string ProjectPath { get; set; } = string.Empty;
        public string TemplatePath {  get; set; } = string.Empty;
        public string TraiPath { get; set; } = string.Empty;
        public string ModelPath { get; set; } = string.Empty;
        public string ProjectSnaps {  get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public string ProjectVersion { get; set; } = string.Empty;
        public Rectangle PrincipalRoi { get; set; } = new Rectangle();
        public string[] Images {  get; set; }
        public CaptureType captureType { get; set; } = CaptureType.File;
        public int CamNum { get; set; } = 0;
        public string FileCapturePath { get; set; } = string.Empty;
        public string CamaraName {  get; set; } = string.Empty;
        public List<RoiClass> RoiClasses { get; set; } = new List<RoiClass>();
        public List<string> Categories { get; set; } = new List<string>();
        public List<ProcessClass> ProcessImages { get; set; } = new List<ProcessClass> { };
        public string LastDirFile {  get; set; } = string.Empty;
        public List<TestStep> TestSteps { get; set; } =  new List<TestStep> { };
    }
}
