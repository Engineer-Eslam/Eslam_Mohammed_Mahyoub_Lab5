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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // ربط معالج واحد للحدث KeyPress لكل من textBox1 و textBox2
            textBox1.KeyPress += new KeyPressEventHandler(Handle_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(Handle_KeyPress);

            // ربط معالج واحد للحدث KeyUp لكل من textBox1 و textBox2
            textBox1.KeyUp += new KeyEventHandler(Handle_KeyUp);
            textBox2.KeyUp += new KeyEventHandler(Handle_KeyUp);

            // ربط معالج واحد للحدث MouseClick لكل من textBox1 و textBox2
            textBox1.MouseClick += new MouseEventHandler(Handle_MouseClick);
            textBox2.MouseClick += new MouseEventHandler(Handle_MouseClick);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Height = Add_Button.Height+80;
            this.Width = Div_Button.Left+Div_Button.Width + 40;
            txt_Result.ReadOnly = true;
            txt_Result.BackColor = Color.White;
            textBox1.Text = textBox2.Text = txt_Result.Text = "";
        }

        // معالج واحد للحدث KeyPress لكل من textBox1 و textBox2
        private void Handle_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox; // الحصول على مربع النص الذي أثار الحدث
            txt_Result.BackColor = Color.White;
            txt_Result.Text = "";

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 45))
            {
                e.Handled = true; // منع إدخال أي حرف غير رقمي
            }

            if (e.KeyChar == 45) // السماح بإدخال السالب فقط إذا لم يكن موجودًا وفي البداية
            {
                if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 46) // السماح بإدخال النقطة العشرية فقط لمرة واحدة
            {
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        // معالج واحد للحدث KeyUp لكل من textBox1 و textBox2
        private void Handle_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.StartsWith("-") && textBox.SelectionStart == 0)
            {
                textBox.SelectionStart = 1;
            }
        }

        // معالج واحد للحدث MouseClick لكل من textBox1 و textBox2
        private void Handle_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.StartsWith("-") && textBox.SelectionStart == 0)
            {
                textBox.SelectionStart = 1;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            label_process.Text = "+";
            panel1.Visible = true;
            Height = panel1.Height * 2;
            textBox1.Focus();
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            label_process.Text = "-";
            panel1.Visible = true;
            Height = panel1.Height * 2;
            textBox1.Focus();
        }

        private void Mul_Button_Click(object sender, EventArgs e)
        {
            label_process.Text = "*";
            panel1.Visible = true;
            Height = panel1.Height * 2;
            textBox1.Focus();
        }

        private void Div_Button_Click(object sender, EventArgs e)
        {
            label_process.Text = "/";
            panel1.Visible = true;
            Height = panel1.Height * 2;
            textBox1.Focus();
        }

        // زر حساب
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                txt_Result.BackColor = Color.LightBlue;
                switch (label_process.Text)
                {
                    case "+":
                        txt_Result.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    case "-":
                        txt_Result.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    case "*":
                        txt_Result.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    case "/":
                        if (Convert.ToDouble(textBox2.Text) != 0)
                        {
                            txt_Result.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("error dvided by zero", "Error");
                            txt_Result.BackColor = Color.White;
                            textBox2.Text="";
                            textBox2.Focus();
                            break;
                        }
                }
            }
            else
                MessageBox.Show("أدخل أرقاما لإجراء العملية", "Error");
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Form4_Load(null, null);
        }
    }
}
