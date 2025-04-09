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
        public Label cityLabel;
        public Label currentOut;
        public Label currentLabel;

        public CurrentDisplayLabel(int _x, int _y, Label _maxOut, Label _minOut, Label _minLabel, Label _maxLabel, Label _currentOut, Label _currentLabel, Label _weatherOut, Label _cityLabel, PictureBox _backPanel, Day _dayData)
        {
            cityLabel = _cityLabel;
            maxOut = _maxOut;
            minOut = _minOut;
            currentOut = _currentOut;
            minLabel = _minLabel;
            maxLabel = _maxLabel;
            currentLabel = _currentLabel;
            weatherOut = _weatherOut;
            backPanel = _backPanel;
            dayData = _dayData;

            x = _x;
            y = _y;

            width = backPanel.Width;
            height = backPanel.Height;

            BuildLabel();

            SetAllParents();
            cityLabel.Parent = backPanel;
            currentLabel.Parent = backPanel;
            currentOut.Parent = backPanel;
        }

        public void BuildLabel()
        {
            backPanel.Location = new Point(x, y);
            cityLabel.Location = new Point(x + width / 2 - cityLabel.Width / 2, y);
            maxLabel.Location = new Point(x + 70, y + 70);
            maxOut.Location = new Point(x + width - maxOut.Width - 70, y + 70);
            minLabel.Location = new Point(x + 70, y + 115);
            minOut.Location = new Point(x + width - minOut.Width - 70, y + 120);
            currentLabel.Location = new Point(x + 70, y + 165);
            currentOut.Location = new Point(x + width - minOut.Width - 70, y + 170);
            weatherOut.Location = new Point(x + width / 2 - weatherOut.Width / 2, y + 260);
        }
    }
}
