using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        List<ForecastDisplay> displayLabels = new List<ForecastDisplay>();

        public ForecastScreen()
        {
            InitializeComponent();
            BuildLabelList();

            displayForecast();
        }

        public void displayForecast()
        {
            //date1.Text = Form1.days[1].date;

            //List<string> dayOneTemps = Form1.RoundDayTempValues(Form1.days[1]);
            //min1.Text = $"{dayOneTemps[0]}°C";
            //max1.Text = $"{dayOneTemps[1]}°C";

            //weather1.Text = $"{Form1.days[1].condition}";

            //date2.Text = Form1.days[2].date;
            //List<string> dayTwoTemps = Form1.RoundDayTempValues(Form1.days[2]);
            //min2.Text = $"{dayTwoTemps[0]}°C";
            //max2.Text = $"{dayTwoTemps[1]}°C";

            //weather2.Text = $"{Form1.days[2].condition}";

            //date3.Text = Form1.days[3].date;
            //List<string> dayThreeTemps = Form1.RoundDayTempValues(Form1.days[3]);
            //min3.Text = $"{dayThreeTemps[0]}°C";
            //max3.Text = $"{dayThreeTemps[1]}°C";

            //weather3.Text = $"{Form1.days[3].condition}";

            //date4.Text = Form1.days[4].date;
            //List<string> dayFourTemps = Form1.RoundDayTempValues(Form1.days[4]);
            //min4.Text = $"{dayFourTemps[0]}°C";
            //max4.Text = $"{dayFourTemps[1]}°C";

            //weather4.Text = $"{Form1.days[4].condition}";

            //date5.Text = Form1.days[5].date;
            //List<string> dayFiveTemps = Form1.RoundDayTempValues(Form1.days[5]);
            //minL5.Text = $"{dayFiveTemps[0]}°C";
            //maxL5.Text = $"{dayFiveTemps[1]}°C";

            //weather5.Text = $"{Form1.days[5].condition}";

            displayLabels[0].MoveLabel(this.Width / 2 - displayLabels[0].width / 2, 60);
            displayLabels[0].BuildLabel();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        public void BuildLabelList()
        {
            displayLabels.Add(new ForecastDisplay(0, 0, date1, max1, min1, maxL1, minL1, weather1, back1, Form1.days[1]));
            displayLabels.Add(new ForecastDisplay(0, 0, date2, max2, min2, maxL2, minL2, weather2, back2, Form1.days[2]));
            displayLabels.Add(new ForecastDisplay(0, 0, date3, max3, min3, maxL3, minL3, weather3, back3, Form1.days[3]));
            displayLabels.Add(new ForecastDisplay(0, 0, date4, max4, min4, maxL4, minL4, weather4, back4, Form1.days[4]));
            displayLabels.Add(new ForecastDisplay(0, 0, date5, max5, min5, maxL5, minL5, weather5, back5, Form1.days[5]));
        }
    }
}
