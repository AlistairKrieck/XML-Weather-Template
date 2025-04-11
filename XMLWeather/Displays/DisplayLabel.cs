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
        //create common objects between current and forecast displays
        public Label maxOut, minOut, weatherOut;
        public Label maxLabel, minLabel;
        public Label dateOut;
        public PictureBox backPanel;

        //create day object to hold weather info inside the display
        public Day dayData;

        //create ints to hold position
        public int x, y;

        //create ints to hold size
        public int width, height;

        //moves display to requested postion
        public void MoveLabel(int _x, int _y)
        {
            x = _x;
            y = _y;

            backPanel.Location = new Point(x, y);
        }

        //sets all label objects parent to the picure box
        public void SetAllParents()
        {
            dateOut.Parent = backPanel;
            maxOut.Parent = backPanel;
            minOut.Parent = backPanel;
            weatherOut.Parent = backPanel;

            maxLabel.Parent = backPanel;
            minLabel.Parent = backPanel;
        }

        //find conditionValue from day stored in display
        public void SetBackgroundImage()
        {
            //create int to hold the conditionValue
            int val = dayData.conditionValue;

            //set background of the display to relevant image
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
