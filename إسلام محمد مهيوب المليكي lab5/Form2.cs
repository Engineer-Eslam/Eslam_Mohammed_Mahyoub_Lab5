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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //this.Width = this.Width + 100;
            //this.Height = this.Height + 100;
            //this.Size = new Size(this.Width + 100, this.Height + 100);
            //button_player.Top = button_player.Left = 20;

            // منع تكبير الشاشة
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // تثبيت حجم الشاشة
            this.MaximizeBox = false; // إخفاء زر التكبير
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button_player.Height += 5;
            button_player.Size = new Size(button_player.Width, button_player.Height + 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button_player.Size = new Size(button_player.Width + 5, button_player.Height);
            button_player.Width += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button_player.Size = new Size(button_player.Width, button_player.Height - 5);
            button_player.Height -= 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button_player.Width -= 5;
            button_player.Size = new Size(button_player.Width - 5, button_player.Height);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Top >= 5)
            {
                //panel1.Top -= 5;
                panel1.Location = new Point(panel1.Left, panel1.Top - 5);
                button7.Enabled = true;
            }
            else
                button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel1.Left + panel1.Width +15 < this.Width)
            {
                //panel1.Location = new Point(panel1.Left + 5, panel1.Top);
                panel1.Left += 5;
                button8.Enabled = true;
            }
            else
                button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel1.Top + panel1.Height + 35 < this.Height)
            {
                //panel1.Location = new Point(panel1.Left , panel1.Top +5 );
                panel1.Top += 5;
                button5.Enabled = true;
            }
            else
                button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel1.Left >= 5)
            {
                //panel1.Left -= 5;
                panel1.Location = new Point(panel1.Left -5, panel1.Top);
                button6.Enabled = true;
            }
            else
                button8.Enabled = false;
        }
    }
}
