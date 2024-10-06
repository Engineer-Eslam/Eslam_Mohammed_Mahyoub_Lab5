using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
            int s = 0; bool f = false;
            textBox1.Text = null;
            if (checkBox1.Checked) {
                s += Convert.ToInt32(checkBox1.Text);
                f = true; 
            }
            if (checkBox2.Checked==true) {
                s += Convert.ToInt32(checkBox2.Text);
                f = true; 
            }
            if (checkBox3.Checked) { 
                s += Convert.ToInt32(checkBox3.Text); 
                f = true; 
            }
            if (checkBox4.Checked) { 
                s += Convert.ToInt32(checkBox4.Text); 
                f = true; 
            }
            if (checkBox5.Checked) { 
                s += Convert.ToInt32(checkBox5.Text); 
                f = true; 
            }

            if (f)
            {
                textBox1.Text = s.ToString();
            }
        }

        private void button_Applying_Click(object sender, EventArgs e)
        {
            if (red_background.Checked) 
                label1.BackColor = Color.Red;
            else if (Yellow_background.Checked) 
                label1.BackColor = Color.Yellow;
            else if (Green_background.Checked == true) 
                label1.BackColor = Color.Green;
            else if (Black_background.Checked) 
                label1.BackColor = Color.Black;

            if (Color_text_Red.Checked == true) 
                label1.ForeColor = Color.Red;
            else if (Color_text_Yellow.Checked) 
                label1.ForeColor = Color.Yellow;
            else if (Color_text_Green.Checked) 
                label1.ForeColor = Color.Green;
            else if (Color_text_Black.Checked) 
                label1.ForeColor = Color.Black;
        }

        private void Enabled_Click(object sender, EventArgs e)
        {
            //if(panel1.Enabled)
            //    panel1.Enabled = false;
            //else
            //    panel1.Enabled = true;
            panel1.Enabled = !panel1.Enabled;
        }

        private void Visible_Click(object sender, EventArgs e)
        {
            //panel1.Visible = !panel1.Visible;
            if (panel1.Visible)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

    }
}
