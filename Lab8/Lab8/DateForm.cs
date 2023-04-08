//Grading ID: S0941
//CIS 199-02
//Lab 8
//Due: (4/13/21)
//This assignment uses a Date Class and properties to Create a Date form with changeable months, days, and years.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Lab8
{
    public partial class DateForm : Form
    {
        private Date defaultDate = new Date(1, 1, 2000); //creates a defaultDate object that sets the default value of the date in the date form to (01/01/2000)
        public DateForm()
        {
            InitializeComponent();
        }

private void DateForm_Load(object sender, EventArgs e) //event handler for the forms load event
        {
            dateOutputLbl.Text = defaultDate.ToString(); //sets the defaultDate object as the value of the dateOutput label
        }

        
        private void monthBtn_Click(object sender, EventArgs e) //Event handler for month update button
        {
            int newMonth; // integer to store new month value
            bool isMonthParsed = int.TryParse(inputMonth.Text, out newMonth); //checks if month input is a valid integer
            defaultDate.Month = newMonth; // changes default month to input month
            if (isMonthParsed) //if statement that runs if month parsed correctly
            {
                dateOutputLbl.Text = defaultDate.ToString(); //if it parsed, updates output label to input month
            }
            else
            {
                MessageBox.Show("Error: Month entered is invalid!"); //if not parsed, displays error message
            }

        }

        private void dayBtn_Click(object sender, EventArgs e) //Event handler for day update button
        {
            int newDay; // integer to store new day value
            bool isDayParsed = int.TryParse(inputDay.Text, out newDay); //checks if day input is a valid integer
            defaultDate.Day = newDay; // changes default day to input day
            if (isDayParsed) //if statement that runs if day parsed correctly
            {
                dateOutputLbl.Text = defaultDate.ToString(); //if it parsed, updates output label to input day
            }
            else
            {
                MessageBox.Show("Error: Day entered is invalid!"); //if not parsed, displays error message
            }
        }

        private void yearBtn_Click(object sender, EventArgs e) //Event handler for year update button
        {
            int newYear; // integer to store new year value
            bool isYearParsed = int.TryParse(inputYear.Text, out newYear); //checks if year input is a valid integer
            defaultDate.Year = newYear; // changes default year to input year
            if (isYearParsed) //if statement that runs if year parsed correctly
            {
                dateOutputLbl.Text = defaultDate.ToString(); //if it parsed, updates output label to input year
            }
            else
            {
                MessageBox.Show("Error: Year entered is invalid!"); //if not parsed, displays error message
            }
        }
    }
}
