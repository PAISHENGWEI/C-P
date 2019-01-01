using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honeycomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            Workers[] workers = new Workers[4];
            workers[0] = new Workers(new string[] { "Nectar collector", "Honey manufacturing" },175);
            workers[1] = new Workers(new string[] { "Egg care", "Baby bee tutoring" },114);
            workers[2] = new Workers(new string[] { "Hive mainte", "Sting patrol" },149);
            workers[3] = new Workers(new string[] { "Egg care", "Baby bee tutoring", "Nectar collector", "Honey manufacturing",
                                                   "Hive mainte", "Sting patrol"},155);
            
            queen = new Queen(workers,275);

        }
        private Queen queen;

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)numericUpDown1.Value) == false)
                MessageBox.Show("No workers are available to do the job'" + comboBox1.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job'" + comboBox1.Text + "' will be done in " + numericUpDown1.Value + " shifts", "The queen bee says...");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = queen.WorkTheNextShift();
        }
    }
}
