using System;
using System.Threading;
using System.Windows.Forms;

namespace PEExam
{
    public partial class ExamTime : Form
    {
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

        public bool TestPullUps()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "引体向上 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.PullUps * 10)
                {
                    Status_Label.Text = "引体向上通过";
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
            Status_Label.Text = "引体向上未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestSolidBall()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "实心球 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Football * 10)
                {
                    Status_Label.Text = "实心球通过";
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
            Status_Label.Text = "实心球未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestRun1000m()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "1000m跑步 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Run1000m * 10)
                {
                    Status_Label.Text = "1000m跑步通过";
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
            Status_Label.Text = "1000m跑步未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestRun800m()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "800m跑步 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Run800m * 10)
                {
                    Status_Label.Text = "800m跑步通过";
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
            Status_Label.Text = "800m跑步未通过";
            Application.DoEvents();
            Thread.Sleep(1000);
            return false;
        }

        public bool TestSwim50m()
        {
            int gen = -1;
            for (int i = 1; i <= 2; i++)
            {
                gen = Main.random.Next(0, 1000);
                Status_Label.Text = "50m游泳 第 " + i.ToString() + " 次尝试";
                Application.DoEvents();
                Thread.Sleep(10000);
                if (gen <= Main.Player_Possibilities.Swim50m * 10)
                {
                    Status_Label.Text = "50m游泳通过";
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
            Status_Label.Text = "50m游泳未通过";
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
            Main.TotalScore = 0;

            StartExam_Button.Text = "测试中";
            StartExam_Button.Enabled = false;

            switch (Main.FlexMainIndex)
            {
                case 1:
                    if (TestRopeSkipping())
                    {
                        Main.TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 2:
                    if (TestPushUps())
                    {
                        Main.TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 3:
                    if (TestBasketball())
                    {
                        Main.TotalScore += 10;
                        Main.NeedToTestExtra = false;
                    }
                    else
                        Main.NeedToTestExtra = true;
                    break;
                case 4:
                    if (TestFootball())
                    {
                        Main.TotalScore += 10;
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
                            Main.TotalScore += 10;
                        else
                            Main.TotalScore += 7;
                        break;
                    case 2:
                        if (TestPushUps())
                            Main.TotalScore += 10;
                        else
                            Main.TotalScore += 7;
                        break;
                    case 3:
                        if (TestBasketball())
                            Main.TotalScore += 10;
                        else
                            Main.TotalScore += 7;
                        break;
                    case 4:
                        if (TestFootball())
                            Main.TotalScore += 10;
                        else
                            Main.TotalScore += 7;
                        break;
                }
            }

            switch (Main.PowerIndex)
            {
                case 1:
                    if (TestPullUps())
                        Main.TotalScore += 10;
                    else
                        Main.TotalScore += 7;
                    break;
                case 2:
                    if (TestSolidBall())
                        Main.TotalScore += 10;
                    else
                        Main.TotalScore += 7;
                    break;
            }

            switch (Main.SpeedIndex)
            {
                case 1:
                    if (TestRun1000m())
                        Main.TotalScore += 10;
                    else
                        Main.TotalScore += 7;
                    break;
                case 2:
                    if (TestRun800m())
                        Main.TotalScore += 10;
                    else
                        Main.TotalScore += 7;
                    break;
                case 3:
                    if (TestSwim50m())
                        Main.TotalScore += 10;
                    else
                        Main.TotalScore += 7;
                    break;
            }

            MessageBox.Show(Main.TotalScore.ToString());
            this.Close();
        }
    }
}
