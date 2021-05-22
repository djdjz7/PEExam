using System;
using System.Threading;
using System.Windows.Forms;

namespace PEExam
{
    public partial class ExamTime : Form
    {

        public static int TotalScore = 0;

        public bool TestRopeSkipping()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "跳绳 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                for (int j = 1; j <= 30; j++)
                {
                    if (j % 4 == 0)
                        Status_Bar.Value += 1;
                    Thread.Sleep(1000);
                }
                if (gen <= Main.Player_Possibilities.RopeSkipping * 10)
                {
                    Status_Label.Text = "跳绳通过";
                    Status_Bar.Value += 7;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    return true;
                }
                else continue;

            }
            Status_Label.Text = "跳绳未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestPushUps()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "俯卧撑 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.PushUps * 10)
                {
                    Status_Label.Text = "俯卧撑通过";
                    Status_Bar.Value += 15;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    Status_Bar.Value += 7;
                    Application.DoEvents();
                    continue;
                }

            }
            Status_Label.Text = "俯卧撑未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestBasketball()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "篮球运球 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Basketball * 10)
                {
                    Status_Label.Text = "篮球运球通过";
                    Status_Bar.Value += 15;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    Status_Bar.Value += 7;
                    Application.DoEvents();
                    continue;
                }

            }
            Status_Label.Text = "篮球运球未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestFootball()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                MessageBox.Show(gen.ToString());
                MessageBox.Show((Main.Player_Possibilities.Football * 10).ToString());
                Status_Label.Text = "足球射门 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Football * 10)
                {
                    Status_Label.Text = "足球射门通过";
                    Status_Bar.Value += 15;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    Status_Bar.Value += 7;
                    Application.DoEvents();
                    continue;
                }

            }
            Status_Label.Text = "足球射门未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public ExamTime()
        {
            InitializeComponent();
        }

        private void StartExam_Button_Click(object sender, EventArgs e)
        {
            StartExam_Button.Text = "测试中";
            StartExam_Button.Enabled = false;

            switch (Main.FlexMainIndex)
            {
                case 1:
                    if (TestRopeSkipping())
                    {
                        TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 2:
                    if (TestPushUps())
                    {
                        TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 3:
                    if (TestBasketball())
                    {
                        TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 4:
                    if (TestFootball())
                    {
                        TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
            }

            if (Main.NeedToTestExtra)
            {
                switch (Main.FlexExtraIndex)
                {
                    case 1:
                        if (TestRopeSkipping())
                            TotalScore += 10;
                        else
                            TotalScore += 7;
                        break;
                    case 2:
                        if (TestPushUps())
                            TotalScore += 10;
                        else
                            TotalScore += 7;
                        break;
                    case 3:
                        if (TestBasketball())
                            TotalScore += 10;
                        else
                            TotalScore += 7;
                        break;
                    case 4:
                        if (TestFootball())
                            TotalScore += 10;
                        else
                            TotalScore += 7;
                        break;
                }
            }
        }
    }
}
