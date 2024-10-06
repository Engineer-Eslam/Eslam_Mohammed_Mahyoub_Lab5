namespace إسلام_محمد_مهيوب_المليكي_lab5
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Button = new System.Windows.Forms.Button();
            this.Sub_Button = new System.Windows.Forms.Button();
            this.Mul_Button = new System.Windows.Forms.Button();
            this.Div_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_process = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Button.Location = new System.Drawing.Point(26, 23);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(94, 35);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "جمع";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Sub_Button
            // 
            this.Sub_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sub_Button.Location = new System.Drawing.Point(143, 23);
            this.Sub_Button.Name = "Sub_Button";
            this.Sub_Button.Size = new System.Drawing.Size(94, 35);
            this.Sub_Button.TabIndex = 1;
            this.Sub_Button.Text = "طرح";
            this.Sub_Button.UseVisualStyleBackColor = true;
            this.Sub_Button.Click += new System.EventHandler(this.Sub_Button_Click);
            // 
            // Mul_Button
            // 
            this.Mul_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mul_Button.Location = new System.Drawing.Point(264, 23);
            this.Mul_Button.Name = "Mul_Button";
            this.Mul_Button.Size = new System.Drawing.Size(94, 35);
            this.Mul_Button.TabIndex = 2;
            this.Mul_Button.Text = "ضرب";
            this.Mul_Button.UseVisualStyleBackColor = true;
            this.Mul_Button.Click += new System.EventHandler(this.Mul_Button_Click);
            // 
            // Div_Button
            // 
            this.Div_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Div_Button.Location = new System.Drawing.Point(385, 23);
            this.Div_Button.Name = "Div_Button";
            this.Div_Button.Size = new System.Drawing.Size(94, 35);
            this.Div_Button.TabIndex = 3;
            this.Div_Button.Text = "قسمة";
            this.Div_Button.UseVisualStyleBackColor = true;
            this.Div_Button.Click += new System.EventHandler(this.Div_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Red;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_Button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.Location = new System.Drawing.Point(27, 102);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(94, 35);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "إغلاق";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Calculate_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculate_Button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Button.Location = new System.Drawing.Point(335, 102);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(94, 35);
            this.Calculate_Button.TabIndex = 5;
            this.Calculate_Button.Text = "حساب";
            this.Calculate_Button.UseVisualStyleBackColor = false;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "العدد الأول";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Result);
            this.panel1.Controls.Add(this.Calculate_Button);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label_process);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 152);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "العدد الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 14);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "الناتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 55);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // label_process
            // 
            this.label_process.AutoSize = true;
            this.label_process.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_process.Location = new System.Drawing.Point(295, 55);
            this.label_process.Name = "label_process";
            this.label_process.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_process.Size = new System.Drawing.Size(0, 25);
            this.label_process.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 30);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 30);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(16, 50);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(122, 30);
            this.txt_Result.TabIndex = 13;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Div_Button);
            this.Controls.Add(this.Mul_Button);
            this.Controls.Add(this.Sub_Button);
            this.Controls.Add(this.Add_Button);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Sub_Button;
        private System.Windows.Forms.Button Mul_Button;
        private System.Windows.Forms.Button Div_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_process;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.TextBox textBox2;
    }
}