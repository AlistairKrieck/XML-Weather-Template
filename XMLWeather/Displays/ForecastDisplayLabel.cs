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
        public ForecastDisplay(int _x, int _y, Label _dateOut, Label _maxOut, Label _minOut, Label _maxLabel, Label _minLabel, Label _weatherOut, Panel _backPanel, Day _d)
        {
            dateOut = _dateOut;
            maxOut = _maxOut;
            minOut = _minOut;
            minLabel = _minLabel;
            maxLabel = _maxLabel;
            weatherOut = _weatherOut;
            backPanel = _backPanel;
            d = _d;

            x = _x;
            y = _y;

            width = backPanel.Width;
            height = backPanel.Height;
        }

        public void BuildLabel()
        {
            backPanel.Location = new Point(x, y);
            dateOut.Location = new Point(x + 10, y + 10);
            //maxLabel.Location = new Point(x + 10, y + 50);
            //maxOut.Location = new Point(x + width - 10, y + 50);
        }

        public void MoveLabel(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
