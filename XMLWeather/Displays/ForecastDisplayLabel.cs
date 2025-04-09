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
        public Label dateOut;
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

            BuildLabel();

            SetAllParents();
            dateOut.Parent = backPanel;
        }

        public void BuildLabel()
        {
            backPanel.Location = new Point(x, y);
            dateOut.Location = new Point(x + 10, y + 10);
            maxLabel.Location = new Point(x + 10, y + 50);
            maxOut.Location = new Point(x + width - maxOut.Width - 10, y + 50);
            minLabel.Location = new Point(x + 10, y + 85);
            minOut.Location = new Point(x + width - minOut.Width - 10, y + 90);
            weatherOut.Location = new Point(x + width / 2 - weatherOut.Width / 2, y + 140);
        }

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

        public void DisplayLabelData()
        {
            dateOut.Text = dayData.date;

            List<string> tempRange = Form1.RoundDayTempValues(dayData);
            minOut.Text = $"{tempRange[0]}°C";
            maxOut.Text = $"{tempRange[1]}°C";
            weatherOut.Text = dayData.condition;
        }
    }
}
