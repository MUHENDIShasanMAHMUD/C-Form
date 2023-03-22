using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater_2
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_n1.Text);//Convert the entered string(text) to a double and dive the value to "n1"
            n2 = Convert.ToDouble(txt_n2.Text);//Convert the entered string(text) to a double and dive the value to "n2"
            result = n1 - n2;//Perform the operation and give it to "result"
            lbl_result.Text = Convert.ToString(result);//convert the value from a double to string adf write it in the output

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_n1.Text);//Convert the entered string(text) to a double and dive the value to "n1"
            n2 = Convert.ToDouble(txt_n2.Text);//Convert the entered string(text) to a double and dive the value to "n2"
            result = n1 * n2;//Perform the operation and give it to "result"
            lbl_result.Text = Convert.ToString(result);//convert the value from a double to string adf write it in the output

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_n1.Text); //Convert the entered string(text) to a double and dive the value to "n1"
            n2 = Convert.ToDouble(txt_n2.Text); //Convert the entered string(text) to a double and dive the value to "n2"
            result = n1 + n2; //Perform the operation and give it to "result"
            lbl_result.Text = Convert.ToString(result); //convert the value from a double to string adf write it in the output

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_n1.Text);//Convert the entered string(text) to a double and dive the value to "n1"
            n2 = Convert.ToDouble(txt_n2.Text);//Convert the entered string(text) to a double and dive the value to "n2"
            result = n1 / n2;//Perform the operation and give it to "result"
            lbl_result.Text = Convert.ToString(result);//convert the value from a double to string adf write it in the output
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
