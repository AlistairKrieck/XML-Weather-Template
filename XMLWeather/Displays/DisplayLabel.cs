using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void MoveLabel(int _x, int _y)
        {
            x = _x;
            y = _y;

            backPanel.Location = new Point(x, y);
        }

        public void SetAllParents()
        {
            maxOut.Parent = backPanel;
            minOut.Parent = backPanel;
            weatherOut.Parent = backPanel;

            maxLabel.Parent = backPanel;
            minLabel.Parent = backPanel;
        }

        public void SetBackgroundImage()
        {
            int val = dayData.conditionValue;

            if (val >= 200 && val < 300)
            {
                backPanel.Image = Properties.Resources.Thunderstorm;
            }
            else if (val >= 300 && val < 400)
            {
                backPanel.Image = Properties.Resources.Drizzle;
            }
            //else if (val >= 400 && val < 500) 
            //{
            //Nothing between 400 and 500
            //}
            else if (val >= 500 && val < 600)
            {
                backPanel.Image = Properties.Resources.Rain;
            }
            else if (val >= 600 && val < 700)
            {
                backPanel.Image = Properties.Resources.Snow;
            }
            else if (val == 800)
            {
                backPanel.Image = Properties.Resources.Clear;
            }
            else if (val > 800 && val < 900)
            {
                backPanel.Image = Properties.Resources.Clouds1;
            }
        }
    }
}
