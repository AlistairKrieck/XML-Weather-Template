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
        CurrentDisplayLabel display;

        COMMENT STUFF

        public CurrentScreen()
        {
            InitializeComponent();

            cityInput.Text = Form1.city;

            CreateDisplay();

            display.SetBackgroundImage();
            display.DisplayLabelData();
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
            display = new CurrentDisplayLabel(0, 0, maxOutput, minOutput, minLabel, maxLabel, currentOutput, current, weatherOutput, date, picBox, Form1.days[0]);
            int x = this.Width / 2 - display.width / 2;
            int y = panel1.Height;

            display.MoveLabel(x, y);
        }

        private void enterCityInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.city = cityInput.Text;

                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                display.dayData = Form1.days[0];

                display.DisplayLabelData();
                display.SetBackgroundImage();
            }
            catch
            {
                Form1.city = "Stratford,CA";

                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                display.DisplayLabelData();
                display.SetBackgroundImage();

                cityInput.Text = "Error; Not Found";
            }
        }
    }
}
