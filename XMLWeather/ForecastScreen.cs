﻿using System;
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

        int displayPosition = 0;

        public ForecastScreen()
        {
            InitializeComponent();

            //Display city that is currently being checked
            Form1.city = "Stratford,CA";

            //Create each display object and add it to a list
            BuildDisplayList();

            //Move each display to its starting position
            SetInitPositions();

            displayForecast();
        }

        public void displayForecast()
        {
            for (int i = 0; i < displayLabels.Count; i++)
            {
                displayLabels[i].dayData = Form1.days[i + 1];

                displayLabels[i].DisplayLabelData();

                displayLabels[i].SetBackgroundImage();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        public void BuildDisplayList()
        {
            displayLabels.Add(new ForecastDisplay(0, 0, date1, max1, min1, maxL1, minL1, weather1, back1, Form1.days[1]));
            displayLabels.Add(new ForecastDisplay(0, 0, date2, max2, min2, maxL2, minL2, weather2, back2, Form1.days[2]));
            displayLabels.Add(new ForecastDisplay(0, 0, date3, max3, min3, maxL3, minL3, weather3, back3, Form1.days[3]));
            displayLabels.Add(new ForecastDisplay(0, 0, date4, max4, min4, maxL4, minL4, weather4, back4, Form1.days[4]));
            displayLabels.Add(new ForecastDisplay(0, 0, date5, max5, min5, maxL5, minL5, weather5, back5, Form1.days[5]));
            displayLabels.Add(new ForecastDisplay(0, 0, date6, max6, min6, maxL6, minL6, weather6, back6, Form1.days[6]));
        }

        public void SetInitPositions()
        {
            displayLabels[0].MoveLabel(this.Width * 2 / 10 - displayLabels[0].width / 2, 60);
            displayLabels[1].MoveLabel(this.Width * 5 / 10 - displayLabels[1].width / 2, 60);
            displayLabels[2].MoveLabel(this.Width * 8 / 10 - displayLabels[2].width / 2, 60);
            displayLabels[3].HideLabel();
            displayLabels[4].HideLabel();
            displayLabels[5].HideLabel();

            leftArrowButton.Location = new Point(5, this.Height / 2 - leftArrowButton.Width / 2);
            rightArrowButton.Location = new Point(this.Width - rightArrowButton.Width - 5, this.Height / 2 - rightArrowButton.Width / 2);
        }

        public void ShiftDisplays(bool left)
        {
            //fixes bug caused by resetting displayPosition to 0 if greater than displayLabels.Count - 1
            if (displayPosition == displayLabels.Count)
            {
                displayPosition = 0;
            }

            if (left)
            {
                displayPosition--;
            }

            else
            {
                displayPosition++;
            }



            int[] positions = new int[displayLabels.Count];

            for (int i = 0; i < displayLabels.Count; i++)
            {
                //if position in line is negative, push it to the end of the line
                if (displayPosition < 0)
                {
                    displayPosition = displayLabels.Count - 1;
                }

                //if position in line is greater than the size of the line, push it to the front of the line
                else if (displayPosition > displayLabels.Count - 1)
                {
                    displayPosition = 0;
                }

                positions[i] = displayPosition;

                displayPosition++;
            }

            ShowAllLabels();

            displayLabels[positions[0]].MoveLabel(this.Width * 2 / 10 - displayLabels[0].width / 2, 60);
            displayLabels[positions[1]].MoveLabel(this.Width * 5 / 10 - displayLabels[1].width / 2, 60);
            displayLabels[positions[2]].MoveLabel(this.Width * 8 / 10 - displayLabels[2].width / 2, 60);
            displayLabels[positions[3]].HideLabel();
            displayLabels[positions[4]].HideLabel();
            displayLabels[positions[5]].HideLabel();
        }

        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            ShiftDisplays(true);
        }

        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            ShiftDisplays(false);
        }

        private void ShowAllLabels()
        {
            foreach (var d in displayLabels)
            {
                d.ShowLabel();
            }
        }

        private void enterCityInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.city = cityInput.Text;

                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                displayForecast();
            }
            catch
            {
                Form1.city = "Stratford,CA";


                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                displayForecast();

                cityInput.Text = "Error; Not Found";
            }
        }
    }
}
