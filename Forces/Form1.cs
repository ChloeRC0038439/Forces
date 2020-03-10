using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));

        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));

        }

        double Acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declare variables for Force and Angle.
            double Force, Angle;

            //Read values from textbox, Parse-Makes the numbers be read as numbers not individual figures.
            try
            {
               Force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the Force box!");
                Force = 0.0;
            
            }
            try
            {
              Angle = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the Angle box!");
                Angle = 0.0;

            }
            

            //Calculate Fx and Fy
            double Fy = Force * cos(Angle);
            double Fx = Force * sin(Angle);

            //Put values for Fx and Fy in labels
            label2.Text = "Fx = " + Fx + "N";
            label1.Text = "Fy = " + Fy + "N";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
