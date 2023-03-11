using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaring fullName to store the name in the text box
            string fullName = textBox1.Text;
            // Trimming the name from full name
            fullName = fullName.Trim();
            // Splitting the name when it find a space and storing it into
            // an array
            string[] names = fullName.Split(' ');
            // Working with first name
            string firstName = names[0];
            string firstLetter = firstName.Substring(0,1).ToUpper();
            string otherLetters = firstName.Substring(1).ToLower();
            firstName = firstLetter + otherLetters;
            // Working with middle name
            string middleName = names[1];
            firstLetter = middleName.Substring(0, 1).ToUpper();
            otherLetters = middleName.Substring(1).ToLower();
            middleName = firstLetter + otherLetters;
            // Working with last name
            string lastName = names[2];
            firstLetter = lastName.Substring(0, 1).ToUpper();
            otherLetters = lastName.Substring(1).ToLower();
            lastName = firstLetter + otherLetters;
            // Showing the Message Box
            MessageBox.Show("First Name:\t" + firstName +
                "\n\nMiddle Name:\t" + middleName +
                "\n\nLast Name:\t" + lastName, "Parse Name");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Declaring full name as a string
            string phoneNumber = textBox2.Text;
            string phoneDisplay = phoneNumber;
            phoneNumber = phoneNumber.Trim();
            // Declaring a string to store only digits of phone number
            string onlyDigits = "";
            // Creating an array of strings with the numbers;
            char[] numbers = new char[] { '1', '2' , '3', '4', '5', '6', '7', '8', '9', '0'};

            foreach (char c in phoneNumber)
            {
                if (numbers.Contains(c) == false)
                {
                    phoneNumber = phoneNumber.Replace(c,' ');
                }
            }

            phoneNumber = phoneNumber.Trim();
            string[] num = phoneNumber.Split(' ');

            for (int i = 0; i < num.Length ; i++)
            {
                onlyDigits = onlyDigits+num[i];
            }

            string hyphensDisplay = onlyDigits;

            hyphensDisplay = hyphensDisplay.Insert(3, "-");
            hyphensDisplay = hyphensDisplay.Insert(7, "-");

            MessageBox.Show("\nEntered:\t\t" + phoneDisplay +
                "\n\nDigits only:\t" + onlyDigits +
                "\n\nStandard format:\t" + hyphensDisplay, "Edit Phone Number");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the App.? ",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
