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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();

            CreateDisplay();

            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            minOutput.Text = $"{Form1.RoundTemp(Form1.days[0].tempLow)}°C";
            maxOutput.Text = $"{Form1.RoundTemp(Form1.days[0].tempHigh)}°C";
            currentOutput.Text = $"{Form1.RoundTemp(Form1.days[0].currentTemp)}°C";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        public void CreateDisplay()
        {
            CurrentDisplayLabel display = new CurrentDisplayLabel(0, 0, maxOutput, minOutput, minLabel, maxLabel, currentOutput, current, weatherOutput, cityOutput, picBox, Form1.days[0]);
            int x = this.Width / 2 - display.width / 2;
            int y = this.Height / 2 - display.height / 2;

            display.MoveLabel(x, y);
        }
    }
}
