using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public class DisplayLabel
    {
        public Label maxOut, minOut, weatherOut;
        public Label maxLabel, minLabel;
        public PictureBox backPanel;
        public Day dayData;

        public int x, y;
        public int width, height;
    }
}
