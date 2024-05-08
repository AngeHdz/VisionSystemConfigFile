using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionSystemConfigFile
{
    public class RoiClass
    {
        public string Name { get; set; }
        public Rectangle Rectangle { get; set; }

        public RoiClass(string name, Rectangle rectangle) 
        {
            Name = name;
            Rectangle = rectangle;
        }
    }
}
