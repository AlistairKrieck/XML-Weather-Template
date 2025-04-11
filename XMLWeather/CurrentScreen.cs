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
        //create an object to hold the display
        CurrentDisplayLabel display;

        public CurrentScreen()
        {
            InitializeComponent();

            //make text display the currently searched city
            cityInput.Text = Form1.city;

            //add all info into the display object, then move it to the desired starting position
            CreateDisplay();
        }

        //swap screen to forecast screen on click
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        //builds display object, inserts day information, then displays all it
        public void CreateDisplay()
        {
            //build display object
            display = new CurrentDisplayLabel(0, 0, maxOutput, minOutput, minLabel, maxLabel, currentOutput, current, weatherOutput, date, picBox, Form1.days[0]);

            //get desired starting position, then move the display there
            int x = this.Width / 2 - display.width / 2;
            int y = panel1.Height;
            display.MoveLabel(x, y);

            //display information
            display.SetBackgroundImage();
            display.DisplayLabelData();
        }

        //gets data for searched city
        private void enterCityInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                //tell Form1 which city it is searching for
                Form1.city = cityInput.Text;

                //remake day list with new city's information
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                //insert new data for today from searched city
                display.dayData = Form1.days[0];

                //output the information to the display
                display.DisplayLabelData();
                display.SetBackgroundImage();
            }
            catch
            {
                //if it fails, default to Stratford
                Form1.city = "Stratford,CA";

                /*remakes the list of day objects to hold Stratfords weather to prevent error
                 *caused when the searched city can't be found
                 */
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                //output Stratfords info to the display
                display.DisplayLabelData();
                display.SetBackgroundImage();

                //inform user the searched city could not be found
                cityInput.Text = "Error; Not Found";
            }
        }
    }
}
