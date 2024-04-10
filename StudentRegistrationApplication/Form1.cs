using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += dayCombo_Load; //calls the method when starting the program
            this.Load += monthCombo_Load;
            this.Load += yearCombo_Load;
            programComboBox_calderon_SelectedIndexChanged(null, null);

        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dayCombo_Load(object sender, EventArgs e) //method to initiate the loop when starting the program
        {
            for (int i = 1; i <= 31; i++) //loops the days (31)
            {
                dayComboBox_calderon.Items.Add(i);
            }
        }

        private void monthCombo_Load(object sender, EventArgs e) //method to initiate the loop when starting the program
        {
            string[] months_calderon = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            foreach (var month_calderon in months_calderon)
            {
                monthComboBox_calderon.Items.Add(month_calderon);
            }
        }

        private void yearCombo_Load(object sender, EventArgs e) //method to initiate the loop when starting the program
        {
            for (int i = 1850; i <= 2024; i++) //loops the current year
            {
                yearComboBox_calderon.Items.Add(i);
            }
        }

        private void registerButton_calderon_Click(object sender, EventArgs e)
        {

            String fName_calderon, mName_calderon, lName_calderon, gender_calderon;

            fName_calderon = firstNameInput_calderon.Text;
            mName_calderon = middleNameInput_calderon.Text;
            lName_calderon = lastNameInput_calderon.Text;

            if (maleSelect_calderon.Checked)
            {
                gender_calderon = " Male";
            } 
            else if (femaleSelect_calderon.Checked)
            {
                gender_calderon = "Female";
            }
            else
            {
                gender_calderon = "";
            }

            if (string.IsNullOrEmpty(fName_calderon) && string.IsNullOrEmpty(mName_calderon) && string.IsNullOrEmpty(lName_calderon))
            {
                MessageBox.Show("Please fill all the blanks.");
            }
            else if (string.IsNullOrEmpty(lName_calderon)) //if user did not input a last name
            {
                MessageBox.Show("You cannot leave the last name blank.");
            }
            else if (string.IsNullOrEmpty(fName_calderon)) //if user did not input a first name
            {
                MessageBox.Show("You cannot leave the first name blank.");
            }
            else if (string.IsNullOrEmpty(mName_calderon)) //if user did not input a middle name
            {
                MessageBox.Show("You cannot leave the middle name blank.");
            }
            else if (dayComboBox_calderon.SelectedIndex == 0) //if user did not select a day
            {
                MessageBox.Show("Please select a day.");
            }
            else if (monthComboBox_calderon.SelectedIndex == 0) //if user did not select a month
            {
                MessageBox.Show("Please select a month.");
            }
            else if (yearComboBox_calderon.SelectedIndex == 0) //if user did not select a year
            {
                MessageBox.Show("Please select a year.");
            }
            else if (!maleSelect_calderon.Checked && !femaleSelect_calderon.Checked) //if user did not select a gender
            {
                MessageBox.Show("Please select a gender");
            }
            else if (programComboBox_calderon.SelectedIndex == 0) // if user did not select a program

            {
                MessageBox.Show("Please select a program.");
            }
            else
            {
                MessageBox.Show("Student name: " + fName_calderon + " " + mName_calderon + " " + lName_calderon
               + "\nGender: " + gender_calderon
               + "\nDate of birth: " + dayComboBox_calderon.Text + "/" + monthComboBox_calderon.Text + "/" + yearComboBox_calderon.Text
               + "\nProgram: " + programComboBox_calderon.Text);
            }

        }

        private void clearButton_calderon_Click(object sender, EventArgs e)
        {
            firstNameInput_calderon.Text = "";
            middleNameInput_calderon.Text = "";
            lastNameInput_calderon.Text = "";
            dayComboBox_calderon.Text = "-Day-";
            monthComboBox_calderon.Text = "-Month-";
            yearComboBox_calderon.Text = "-Year-";
        }

        private void exitButton_calderon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void programComboBox_calderon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList courseList_calderon = new ArrayList();
            courseList_calderon.Add("-Select a program-");
            courseList_calderon.Add("Bachelor of Science in Computer Science");
            courseList_calderon.Add("Bachelor of Science in Information Technology");
            courseList_calderon.Add("Bachelor of Science in Information System");
            courseList_calderon.Add("Bachelor of Science in Computer Engineering");
            foreach (var course_calderon in courseList_calderon)
            {
                programComboBox_calderon.Items.Add(course_calderon);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
