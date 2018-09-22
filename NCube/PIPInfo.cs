using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NCube
{
    public class PIPInfo
    {
        public string Filename { get; set; }

        public Rectangle Rect { get; set; }

        public int ZOrder { get; set; }

        public float Alpha { get; set; }
    }
}
