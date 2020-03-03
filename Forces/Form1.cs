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
            //Read values from textbox, Parse-Makes the numbers be read as numbers not individual figures.
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            //Calculate Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //Put values for Fx and Fy in labels
            label1.Text = "Fx = " + Fx + "N";
            label2.Text = "Fy = " + Fy + "N";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
