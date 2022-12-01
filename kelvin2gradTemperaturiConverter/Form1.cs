using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelvin2gradTemperaturiConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double k = 0;
        public double c = 0;
        public double f = 0;

        public double txtbox2double(TextBox t)
        {
            return double.Parse(t.Text);
        }

        public void double2txtbox(double x, TextBox t)
        {
            t.Text = x.ToString();
        }

        public double k2f(double x)
        {
            //textBox1
            return 0;
        }

        public double k2c(double x)
        {
            //textBox6
            return 0;
        }

        public double f2k(double x)
        {
            //textBox2
            return 0;
        }

        public double f2c(double x)
        {

            //textBox5
            return 0;
        }
        public double c2f(double x)
        {
            
            //textBox3
            return 0;
        }

        public double c2k(double x)
        {

            //textBox4
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kelvin 2 faranheit 2 celsius
            //x = textBox7
            k = txtbox2double(textBox7);
            double2txtbox(k2f(f), textBox1);
            double2txtbox(k2c(f), textBox6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //faranheit 2 kelvin 2  celsius
            //x = textBox8
            f = txtbox2double(textBox8);
           double2txtbox(f2k(f), textBox2);
           double2txtbox(f2k(f), textBox5);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //celsius 2 faranheit 2 kelvin 
            //x = textBox9
            c = txtbox2double(textBox9);
            double2txtbox(c2k(f), textBox3);
            double2txtbox(c2f(f), textBox4);
        }
    }
}
