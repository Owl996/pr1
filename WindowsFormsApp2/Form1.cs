using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            // label7.Text = dateTimePicker1.Value.ToString("dd-MM-2087"); 

            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                DateTime newValue = dateTimePicker1.Value;
                dateTimePicker1.Value = newValue.AddYears(65);
                label7.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");


            }
            else if (radioButton1.Checked == false && radioButton2.Checked == true)
            {
                DateTime newValue = dateTimePicker1.Value;
                dateTimePicker1.Value = newValue.AddYears(60);
                label7.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            }
            dateTimePicker1.ResetText();
        }
    }
}
        
        
    

