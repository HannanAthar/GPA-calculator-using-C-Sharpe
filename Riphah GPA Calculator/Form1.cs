using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Riphah_GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox1.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox2.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox3.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox4.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox5.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Marks field can not be empty");
            }
            else
            {
                int marks = Int32.Parse(textBox6.Text);
                if (marks < 0 || marks > 100)
                {
                    MessageBox.Show("Marks should be between 0 and 100");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")

            {
                MessageBox.Show("Marks are empty");
            }
            else
            {
                int m1, m2, m3, m4, m5, m6;
                int c1, c2, c3, c4, c5, c6;
                m1 = Int32.Parse(textBox1.Text);
                m2 = Int32.Parse(textBox2.Text);
                m3 = Int32.Parse(textBox3.Text);
                m4 = Int32.Parse(textBox4.Text);
                m5 = Int32.Parse(textBox5.Text);
                m6 = Int32.Parse(textBox6.Text);
                c1 = (int)numericUpDown1.Value;
                c2 = (int)numericUpDown2.Value;
                c3 = (int)numericUpDown3.Value;
                c4 = (int)numericUpDown4.Value;
                c5 = (int)numericUpDown5.Value;
                c6 = (int)numericUpDown6.Value;

                if (checkBox1.Checked)
                {
                    m1 = 0;

                }
                if (checkBox2.Checked)
                {
                    m2 = 0;
                }
                if (checkBox3.Checked)
                {
                    m3 = 0;
                }
                if (checkBox4.Checked)
                {
                    m4 = 0;
                }
                if (checkBox5.Checked)
                {
                    m5 = 0;
                }
                if (checkBox6.Checked)
                {
                    m6 = 0;
                }

                int GPA = m1 * c1 + m2 * c2 + m3 * c3 + m4 * c4 + m5 * c5 + m6 * c6;
                int to = c1 + c2 + c3 + c4 + c5 + c6;
                int CGPA = GPA / to;
                //MessageBox.Show(CGPA.ToString());

                label12.Text = grade(m1);
                label13.Text = grade(m2);
                label14.Text = grade(m3);
                label15.Text = grade(m4);
                label16.Text = grade(m5);
                label17.Text = grade(m6);
                label11.Text = CGPA.ToString();


                string grade(int marks)
                {
                    string p = "";

                    if (marks < 50)
                    {
                        p = "F";

                    }
                    else if (marks >= 50 && marks <= 59)
                    {
                        p = "D";
                    }
                    else if (marks >= 60 && marks <= 69)
                    {
                        p = "C";
                    }
                    else if (marks >= 70 && marks <= 79)
                    {
                        p = "B";
                    }
                    else if (marks >= 80 && marks <= 100)
                    {
                        p = "A";
                    }
                    return p;
                }

            }
        }
    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}