using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentDisplayLabel : DisplayLabel
    {
        public Label currentOut;
        public Label currentLabel;

        public CurrentDisplayLabel(int _x, int _y, Label _maxOut, Label _minOut, Label _minLabel, Label _maxLabel, Label _currentOut, Label _currentLabel, Label _weatherOut, Label _dateOut, PictureBox _backPanel, Day _dayData)
        {
            maxOut = _maxOut;
            minOut = _minOut;
            currentOut = _currentOut;
            minLabel = _minLabel;
            maxLabel = _maxLabel;
            currentLabel = _currentLabel;
            weatherOut = _weatherOut;
            backPanel = _backPanel;
            dayData = _dayData;
            dateOut = _dateOut;

            x = _x;
            y = _y;

            width = backPanel.Width;
            height = backPanel.Height;

            BuildLabel();

            SetAllParents();
            currentLabel.Parent = backPanel;
            currentOut.Parent = backPanel;
        }

        public void BuildLabel()
        {
            //Distance first label starts from the top of the display
            int yTopDis = 80;

            //y distance between each pair of labels
            int yLabelDis = 70;

            //x distance from edges for each pair of lables
            int xDis = 200;

            //set backPanels location to given x and y positions
            backPanel.Location = new Point(x, y);

            //center date label and place it at the top of the display
            dateOut.Location = new Point(x + width / 2 - dateOut.Width / 2, y + 10);

            //sets positions of each label pair relative to the distances set
            maxLabel.Location = new Point(x + xDis, y + yTopDis);
            maxOut.Location = new Point(x + width - maxOut.Width - xDis, y + yTopDis);
            minLabel.Location = new Point(x + xDis, y + yTopDis + yLabelDis);
            minOut.Location = new Point(x + width - minOut.Width - xDis, y + yTopDis + yLabelDis);
            currentLabel.Location = new Point(x + xDis, y + yTopDis + 2 * yLabelDis);
            currentOut.Location = new Point(x + width - minOut.Width - xDis, y + yTopDis + 2 * yLabelDis);

            //centre the weather label and seperate it from the other labels
            weatherOut.Location = new Point(x + width / 2 - weatherOut.Width / 2, y + 300);
        }

        public void DisplayLabelData()
        {
            dateOut.Text = "Today; ";
            dateOut.Text += Convert.ToDateTime(dayData.date).ToString("dddd MMM dd");

            List<string> tempRange = Form1.RoundDayTempValues(dayData);
            minOut.Text = $"{tempRange[0]}°C";
            maxOut.Text = $"{tempRange[1]}°C";
            currentOut.Text = Form1.RoundTemp(dayData.currentTemp);
            weatherOut.Text = dayData.condition;
        }
    }
}
