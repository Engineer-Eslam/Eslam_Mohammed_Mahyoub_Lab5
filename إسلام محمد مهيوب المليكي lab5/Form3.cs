using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Thread thread_button1 = null;  // تعريف الخيط للتحكم فيه
        Thread thread_button4 = null;  // تعريف الخيط للتحكم فيه
        bool StopMotion = false; // متغير لتتبع حالة التوقف
        bool MoveForward = true;  //button1 تحديد اتجاه حركة الزر
        bool MoveDown = true;  //button4 تحديد اتجاه الحركة الزر
        bool MovingButton1 = false;  //button1 متغير لتتبع حالة الحركة لزر
        bool MovingButton4 = false;  //button4 متغير لتتبع حالة الحركة لزر
        bool isPaused = false; // متغير لتتبع حالة التوقف المؤقت
        private void button2_Click(object sender, EventArgs e)
        {
            if (MovingButton1) // منع بدء حركة جديدة إذا كانت الحركة قائمة بالفعل
                return; 
            StopMotion = false;
            thread_button1 = new Thread(() =>
            {
                MovingButton1 = true;
                while (!StopMotion)
                {
                    Invoke((Action)(() =>
                    {
                        if (MoveForward)
                        {
                            button1.Left += 10;
                            if (button1.Left >= this.Width - button1.Width-20)
                                MoveForward = false; // تغيير الاتجاه إلى اليسار
                        }
                        else
                            button1.Left -= 10;
                    }));
                    Thread.Sleep(100);  // تأخير الحركة
                    Application.DoEvents();
                    if (button1.Left <= 0)  //للخروج من الحلقة عند عودة الزر إلى مكانة الرئيسي 
                    {
                        MoveForward = true;  // تغيير الاتجاه إلى اليمين
                        break;
                    }
                }
                MovingButton1 = false; // إعادة تعيين حالة الحركة بعد التوقف
            });
            thread_button1.Start();  //تشغيل الخيط لتحريك الزر  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MovingButton4) // منع بدء حركة جديدة إذا كانت الحركة قائمة بالفعل
                return; 
            StopMotion = false;
            thread_button4 = new Thread(() =>
            {
                MovingButton4 = true;
                while (!StopMotion)
                {
                    Invoke((Action)(() =>
                    {
                        if (MoveDown)
                        {
                            button4.Top += 10;
                            if (button4.Top >= this.Height - button4.Height - 50)
                                MoveDown = false; // تغيير الاتجاه إلى الأعلى
                        }
                        else
                            button4.Top -= 10;
                    }));
                    Thread.Sleep(100);  // تأخير الحركة
                    Application.DoEvents();
                    if (button4.Top <= 35)  //للخروج من الحلقة عند عودة الزر إلى مكانة الرئيسي
                    {
                        MoveDown = true;  // تغيير الاتجاه إلى الأسفل
                        break;
                    }
                }
                MovingButton4 = false; // إعادة تعيين حالة الحركة بعد التوقف
            });
            thread_button4.Start();  //تشغيل الخيط لتحريك الزر
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // إيقاف الخيوط عند إغلاق النموذج لتجنب أي مشاكل في الأداء
            if (thread_button1 != null && thread_button1.IsAlive)
                thread_button1.Abort();

            if (thread_button4 != null && thread_button4.IsAlive)
                thread_button4.Abort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(StopMotion)
            {
                if(button1.Left>0)  //استإناف تحريك الزر الأول في حالة لم يكتمل تحريكه ذهابا وايابا
                    button2.PerformClick();
                if (button4.Top > 35)  //استإناف تحريك الزر الثاني في حالة لم يكتمل تحريكه ذهابا وايابا
                    button3.PerformClick();
            }
            else
                StopMotion = true;   //إيقاف تحريك كلا من الزران 
        }

    }
}

