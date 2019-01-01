using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);

            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, checkBox3.Checked, textBox2.Text);

            DisplayBirthdayPartyCost();
        }


        private void DisplayDinnerPartyCost()
        {
            decimal Cost =dinnerParty.cost ;
            textBox1.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }
        

        //Cost of Birthday
        private void DisplayBirthdayPartyCost()
        {
            label5.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.cost;
            textBox3.Text = cost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox3.Checked;
            DisplayBirthdayPartyCost();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWrite = textBox2.Text;
            DisplayBirthdayPartyCost();
        }

        
    }
}
