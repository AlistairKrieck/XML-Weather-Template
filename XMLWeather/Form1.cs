using System;
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

        //create public static string to hold which city is being looked at
        public static string city = "Stratford,CA";

        public Form1()
        {
            InitializeComponent();

            //fill list of days with weather information
            ExtractForecast();
            ExtractCurrent();


            //open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();

            cs.Width = ClientSize.Width;
            cs.Height = ClientSize.Height;

            this.Controls.Add(cs);
        }

        //gets weather info for the next 7 days and store it in day objects
        public static void ExtractForecast()
        {
            //clear the day list so new info replaces old instead of stacking on top of it
            days.Clear();

            //create new reader object that reads the XML data from the requested city
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={city}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

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

        //add additional information to the day object representing current date
        public static void ExtractCurrent()
        {
            //current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //gets current temp at current date
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

        //round max and min temperature values from any given day, then return them in a new list of strings
        //where position 0 the rounded min and position 1 is the rounded max
        public static List<string> RoundDayTempValues(Day d)
        {
            //create list of strings to hold rounded temperatures
            List<string> roundedTemps = new List<string>();

            //create strings to hold rounded min and max temperatures
            string roundedLow = RoundTemp(d.tempLow);
            string roundedHigh = RoundTemp(d.tempHigh);

            //add them to the list
            roundedTemps.Add(roundedLow);
            roundedTemps.Add(roundedHigh);

            //return the rounded values
            return roundedTemps;
        }
    }
}
