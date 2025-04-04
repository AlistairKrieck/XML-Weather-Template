﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        //create variables to hold screen size
        public static int width, height;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            //set screen size variables



            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();

            cs.Width = ClientSize.Width;
            cs.Height = ClientSize.Height;

            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //find time element and get day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                //Find weather
                reader.ReadToFollowing("symbol");
                d.conditionValue = Convert.ToInt32(reader.GetAttribute("number"));
                d.condition = reader.GetAttribute("name");


                //find temperature element and get min and max values
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //add day to list of days
                days.Add(d);
            }
        }

        private void ExtractCurrent()
        {
            //current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
        }

        //take temperature string, round, return new string
        public static string RoundTemp(string roundingTemp)
        {
            string temperature;

            double temp = Convert.ToDouble(roundingTemp);

            temp = Math.Round(temp, 0);

            temperature = temp.ToString();

            return temperature;
        }

        public static List<string> RoundDayTempValues(Day d)
        {
            List<string> roundedTemps = new List<string>();

            string roundedLow = RoundTemp(d.tempLow);
            string roundedHigh = RoundTemp(d.tempHigh);

            roundedTemps.Add(roundedLow);
            roundedTemps.Add(roundedHigh);

            return roundedTemps;
        }

        public static void SetBackgroundImage(DisplayLabel d)
        {
            int val = d.dayData.conditionValue;

            //TODO get background images and insert them into picture boxes

            if (val >= 200 && val < 300)
            {
                //d.backPanel.Image = "";
            }
            else if (val >= 300 && val < 400)
            {

            }
            else if (val >= 400 && val < 500)
            {

            }
            else if (val >= 500 && val < 600)
            {

            }
            else if (val >= 600 && val < 700)
            {

            }
            else if (val >= 700 && val < 800)
            {

            }
            else if (val >= 800 && val < 900)
            {

            }
        }
    }
}
