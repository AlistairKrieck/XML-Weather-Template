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
        //create list of display objects
        List<ForecastDisplay> displays = new List<ForecastDisplay>();

        //create int to hold position in the cycle of displays
        int displayPosition = 0;

        public ForecastScreen()
        {
            InitializeComponent();

            //Display city that is currently being checked
            cityInput.Text = Form1.city;

            //create each display object and add it to a list
            BuildDisplayList();

            //output weather data to each of the displays
            displayForecast();
        }

        //inserts then displays the next 6 days of weather information
        public void displayForecast()
        {
            //insert each days information into a display, starting at tommorow
            for (int i = 0; i < displays.Count; i++)
            {
                //start filling displays with tommorows data so it shows the future 6 days
                displays[i].dayData = Form1.days[i + 1];

                //output weather information through displays
                displays[i].DisplayLabelData();
                displays[i].SetBackgroundImage();
            }
        }

        //swap screen to current screen on click
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        //creates each display object and inserts its weather data, then moves them to their default position
        public void BuildDisplayList()
        {
            //create 6 displayLabel objects to output the next 6 days of weather
            displays.Add(new ForecastDisplay(0, 0, date1, max1, min1, maxL1, minL1, weather1, back1, Form1.days[1]));
            displays.Add(new ForecastDisplay(0, 0, date2, max2, min2, maxL2, minL2, weather2, back2, Form1.days[2]));
            displays.Add(new ForecastDisplay(0, 0, date3, max3, min3, maxL3, minL3, weather3, back3, Form1.days[3]));
            displays.Add(new ForecastDisplay(0, 0, date4, max4, min4, maxL4, minL4, weather4, back4, Form1.days[4]));
            displays.Add(new ForecastDisplay(0, 0, date5, max5, min5, maxL5, minL5, weather5, back5, Form1.days[5]));
            displays.Add(new ForecastDisplay(0, 0, date6, max6, min6, maxL6, minL6, weather6, back6, Form1.days[6]));

            //move each display to its starting position
            SetInitPositions();
        }

        //moves all on-screen objects to their desired starting points
        public void SetInitPositions()
        {
            //move the displays for the next three days to their starting positions
            displays[0].MoveLabel(this.Width * 2 / 10 - displays[0].width / 2, 60);
            displays[1].MoveLabel(this.Width * 5 / 10 - displays[1].width / 2, 60);
            displays[2].MoveLabel(this.Width * 8 / 10 - displays[2].width / 2, 60);

            //hide the displays past the first three days
            displays[3].HideLabel();
            displays[4].HideLabel();
            displays[5].HideLabel();

            //move arrow buttons to wanted start points
            leftArrowButton.Location = new Point(5, this.Height / 2 - leftArrowButton.Width / 2);
            rightArrowButton.Location = new Point(this.Width - rightArrowButton.Width - 5, this.Height / 2 - rightArrowButton.Width / 2);
        }

        //cycles the shown displays left or right
        public void ShiftDisplays(bool left)
        {
            //fixes bug caused by resetting displayPosition to 0 if greater than displays.Count - 1
            if (displayPosition == displays.Count)
            {
                displayPosition = 0;
            }

            //if cycling left, lower display position by one
            if (left)
            {
                displayPosition--;
            }

            //if moving right, increase display position by one
            else
            {
                displayPosition++;
            }


            //create an array of ints to hold the positions of each display in the cycle
            int[] positions = new int[displays.Count];


            //add positions into the array
            for (int i = 0; i < displays.Count; i++)
            {
                //if position in line is negative, push it to the end of the line
                if (displayPosition < 0)
                {
                    displayPosition = displays.Count - 1;
                }

                //if position in line is greater than the size of the line, push it to the front of the line
                else if (displayPosition > displays.Count - 1)
                {
                    displayPosition = 0;
                }

                //insert current position
                positions[i] = displayPosition;

                //increase position by one so next position is one higher than the last
                displayPosition++;
            }

            //show all displays (previously called labels but now it's too late to properly change them all)
            //this is cleaner than searching for the specific three that are going to be displayed
            ShowAllLabels();

            //move the active displays to their positions
            displays[positions[0]].MoveLabel(this.Width * 2 / 10 - displays[0].width / 2, 60);
            displays[positions[1]].MoveLabel(this.Width * 5 / 10 - displays[1].width / 2, 60);
            displays[positions[2]].MoveLabel(this.Width * 8 / 10 - displays[2].width / 2, 60);

            //hides displays that are not currently showing data
            displays[positions[3]].HideLabel();
            displays[positions[4]].HideLabel();
            displays[positions[5]].HideLabel();
        }

        //shifts displays to the left on click
        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            ShiftDisplays(true);
        }

        //shifts displays to the right on click
        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            ShiftDisplays(false);
        }

        //shows all displays
        private void ShowAllLabels()
        {
            foreach (var d in displays)
            {
                d.ShowLabel();
            }
        }

        //gets data for searched city
        private void enterCityInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                //tell Form1 which city it's searching for
                Form1.city = cityInput.Text;

                //remake day list with new city's information
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                //output new city's weather data through the displays
                displayForecast();
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

                //output Stratfords info to the displays
                displayForecast();

                //inform user the searched city could not be found
                cityInput.Text = "Error; Not Found";
            }
        }
    }
}
