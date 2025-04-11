using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastDisplay : DisplayLabel
    {
        public ForecastDisplay(int _x, int _y, Label _dateOut, Label _maxOut, Label _minOut, Label _maxLabel, Label _minLabel, Label _weatherOut, PictureBox _backPanel, Day _dayData)
        {
            dateOut = _dateOut;
            maxOut = _maxOut;
            minOut = _minOut;
            minLabel = _minLabel;
            maxLabel = _maxLabel;
            weatherOut = _weatherOut;
            backPanel = _backPanel;
            dayData = _dayData;

            x = _x;
            y = _y;

            width = backPanel.Width;
            height = backPanel.Height;

            //construct the display
            BuildLabel();

            //set all labels parent to the picture box after moving
            //this prevents a bug where the labels move to odd positions when their parent is the picture box before moving
            SetAllParents();
        }

        //moves all pieces of the label to their desired positions related to the picture box
        public void BuildLabel()
        {
            //move display to its x and y
            backPanel.Location = new Point(x, y);

            //move each label to the edges of the label and beneath each other with some offset
            dateOut.Location = new Point(x + 10, y + 10);
            maxLabel.Location = new Point(x + 10, y + 50);
            maxOut.Location = new Point(x + width - maxOut.Width - 10, y + 50);
            minLabel.Location = new Point(x + 10, y + 85);
            minOut.Location = new Point(x + width - minOut.Width - 10, y + 90);

            //center the weather output
            weatherOut.Location = new Point(x + width / 2 - weatherOut.Width / 2, y + 140);
        }

        //sets the visiblity of each part of the display to false
        public void HideLabel()
        {
            backPanel.Visible = false;
            dateOut.Visible = false;
            maxLabel.Visible = false;
            maxOut.Visible = false;
            minLabel.Visible = false;
            minOut.Visible = false;
            weatherOut.Visible = false;
        }

        //sets the visiblity of each part of the display to true
        public void ShowLabel()
        {
            backPanel.Visible = true;
            dateOut.Visible = true;
            maxLabel.Visible = true;
            maxOut.Visible = true;
            minLabel.Visible = true;
            minOut.Visible = true;
            weatherOut.Visible = true;
        }

        //outputs weather info stored in the day object to the display
        public void DisplayLabelData()
        {
            //get the date of the day object, format it, then output it
            dateOut.Text = Convert.ToDateTime(dayData.date).ToString("dddd MMM dd");

            //round the max and min temperatures
            List<string> tempRange = Form1.RoundDayTempValues(dayData);

            //output the rounded max and min temperatures
            minOut.Text = $"{tempRange[0]}°C";
            maxOut.Text = $"{tempRange[1]}°C";

            //output the condition (cloudy, raining, etc) as text
            weatherOut.Text = dayData.condition;
        }
    }
}
