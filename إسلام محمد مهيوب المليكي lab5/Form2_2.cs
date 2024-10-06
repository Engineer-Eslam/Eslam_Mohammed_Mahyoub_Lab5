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
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();
        }

        private void Form2_2_Load(object sender, EventArgs e)
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

        private void MoveButtons(int dx, int dy)
        {
            // هذه الدالة ستقوم بتحريك جميع الأزرار باستثناء button_player
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Name != "button_player")
                {
                    ctrl.Location = new Point(ctrl.Location.X + dx, ctrl.Location.Y + dy);
                }
            }
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
            if (button5.Top > 0)
            {
                MoveButtons(0, -5);
                button7.Enabled = true;
            }
            else
                button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Left + button6.Width + 15 < this.Width)
            {
                MoveButtons(+5, 0);
                button8.Enabled = true;
            }
            else
                button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Top + button7.Height + 40 < this.Height)
            {
                MoveButtons(0, +5);
                button5.Enabled = true;
            }
            else
                button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Left >= 5)
            {
                MoveButtons(-5, 0);
                button6.Enabled = true;
            }
            else
                button8.Enabled = false;
        }
    }
}
