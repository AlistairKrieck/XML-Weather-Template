using System;
using System.Collections.Generic;
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

        public CurrentDisplayLabel(Label _maxOut, Label _minOut, Label _minLabel, Label _maxLabel, Label _currentOut, Label _currentLabel, Label _weatherOut, Panel _backPanel, Day _d)
        {
            maxOut = _maxOut;
            minOut = _minOut;
            currentOut = _currentOut;
            minLabel = _minLabel;
            maxLabel = _maxLabel;
            currentLabel = _currentLabel;
            weatherOut = _weatherOut;
            backPanel = _backPanel;
            d = _d;
        }
    }
}
