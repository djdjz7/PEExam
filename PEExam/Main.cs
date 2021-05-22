using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace PEExam
{


    public partial class Main : Form
    {

        public int PointsAvaiLabel = 10, DaysAvailable = 50, TiringPointsAvaiLabel = 0;

        public static int FlexMainIndex = 0, FlexExtraIndex = 0, PowerIndex = 0, SpeedIndex = 0, TotalScore = 0;

        public struct Possibilities
        {
            //灵巧类
            public float RopeSkipping;
            public float PushUps;
            public float Basketball;
            public float Football;
            //力量类
            public float PullUps;
            public float SolidBall;
            //速度耐力类
            public float Run1000m;
            public float Run800m;
            public float Swim50m;
        };

        public static Possibilities Player_Possibilities;

        string PossibilitiesInitResultString;

        public static Random random = new Random();

        public static bool NeedToTestExtra = false;

        Select select = new Select();
        ExamTime examTime = new ExamTime();

        public void SyncAllNums()
        {
            PointsAvaiLabel_Num.Text = PointsAvaiLabel.ToString();
            DaysAvailable_Num.Text = DaysAvailable.ToString();
            TiringPointsAvaiLabel_Num.Text = TiringPointsAvaiLabel.ToString();
        }

        public void PossibilitiesInit()
        {
            Player_Possibilities.RopeSkipping = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.PushUps = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.Basketball = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.Football = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.PullUps = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.SolidBall = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.Run1000m = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.Run800m = random.Next(100, 300) / 10f;
            Thread.Sleep(10);
            Player_Possibilities.Swim50m = random.Next(100, 300) / 10f;
            Thread.Sleep(10);

        }

        public bool CheckTotalPoints()
        {
            if (FlexMainPoints_Updown.Value + FlexExtraPoints_Updown.Value + PowerPoints_Updown.Value + SpeedPoints_Updown.Value > PointsAvaiLabel)
                return true;
            else return false;
        }

        public void ShowPossibilities()
        {
            PossibilitiesInitResultString = string.Format("考生体育当前天赋：（满分成功率）\n" +
                "灵巧类：\n跳绳：{0}%\n俯卧撑：{1}%\n篮球运球：{2}%\n足球射门：{3}%\n\n" +
                "力量类：\n引体向上：{4}%\n掷实心球：{5}%\n\n" +
                "速度耐力类：\n1000m跑：{6}%\n800m跑：{7}%\n50m游泳：{8}%\n", Player_Possibilities.RopeSkipping, Player_Possibilities.PushUps, Player_Possibilities.Basketball, Player_Possibilities.Football,
                Player_Possibilities.PullUps, Player_Possibilities.SolidBall, Player_Possibilities.Run1000m, Player_Possibilities.Run800m, Player_Possibilities.Swim50m);
            MessageBox.Show(PossibilitiesInitResultString);
        }

        public void ChangeItemName()    // <----- Index值查询
        {
            switch (FlexMainIndex)
            {
                case 1:
                    FlexMainItemName.Text = "跳绳";
                    break;
                case 2:
                    FlexMainItemName.Text = "俯卧撑";
                    break;
                case 3:
                    FlexMainItemName.Text = "篮球运球";
                    break;
                case 4:
                    FlexMainItemName.Text = "足球射门";
                    break;
            }
            switch (FlexExtraIndex)
            {
                case 1:
                    FlexExtraItemName.Text = "跳绳";
                    break;
                case 2:
                    FlexExtraItemName.Text = "俯卧撑";
                    break;
                case 3:
                    FlexExtraItemName.Text = "篮球运球";
                    break;
                case 4:
                    FlexExtraItemName.Text = "足球射门";
                    break;
            }
            switch (PowerIndex)
            {
                case 1:
                    PowerItemName.Text = "引体向上";
                    break;
                case 2:
                    PowerItemName.Text = "掷实心球";
                    break;
            }
            switch (SpeedIndex)
            {
                case 1:
                    SpeedItemName.Text = "1000m跑步";
                    break;
                case 2:
                    SpeedItemName.Text = "800m跑步";
                    break;
                case 3:
                    SpeedItemName.Text = "50m游泳";
                    break;
            }
        }

        public float PossibilitiesAdd(float InputPossibilities)
        {
            if (InputPossibilities <= 50)
            {
                InputPossibilities += 1f;
                return InputPossibilities;
            }
            if (InputPossibilities > 50 && InputPossibilities <= 75)
            {
                InputPossibilities += 0.5f;
                return InputPossibilities;
            }
            if (InputPossibilities > 75 && InputPossibilities < 100)
            {
                InputPossibilities += 0.3f;
            }
            if (InputPossibilities >= 100)
            {
                InputPossibilities = 100f;
            }
            return InputPossibilities;
        }

        public Main()
        {
            InitializeComponent();
            PossibilitiesInit();
            ShowPossibilities();
            SyncAllNums();
            select.ShowDialog();
            ChangeItemName();
        }

        private void Train_Button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= FlexMainPoints_Updown.Value; i++)
            {
                switch (FlexMainIndex)
                {
                    case 1:
                        Player_Possibilities.RopeSkipping = PossibilitiesAdd(Player_Possibilities.RopeSkipping);
                        break;
                    case 2:
                        Player_Possibilities.PushUps = PossibilitiesAdd(Player_Possibilities.PushUps);
                        break;
                    case 3:
                        Player_Possibilities.Basketball = PossibilitiesAdd(Player_Possibilities.Basketball);
                        break;
                    case 4:
                        Player_Possibilities.Football = PossibilitiesAdd(Player_Possibilities.Football);
                        break;
                }
            }
            for (int i = 1; i <= FlexExtraPoints_Updown.Value; i++)
            {
                switch (FlexExtraIndex)
                {
                    case 1:
                        Player_Possibilities.RopeSkipping = PossibilitiesAdd(Player_Possibilities.RopeSkipping);
                        break;
                    case 2:
                        Player_Possibilities.PushUps = PossibilitiesAdd(Player_Possibilities.PushUps);
                        break;
                    case 3:
                        Player_Possibilities.Basketball = PossibilitiesAdd(Player_Possibilities.Basketball);
                        break;
                    case 4:
                        Player_Possibilities.Football = PossibilitiesAdd(Player_Possibilities.Football);
                        break;
                }
            }
            for (int i = 1; i <= PowerPoints_Updown.Value; i++)
            {
                switch (PowerIndex)
                {
                    case 1:
                        Player_Possibilities.PullUps = PossibilitiesAdd(Player_Possibilities.PullUps);
                        break;
                    case 2:
                        Player_Possibilities.SolidBall = PossibilitiesAdd(Player_Possibilities.SolidBall);
                        break;
                }
            }
            for (int i = 1; i <= SpeedPoints_Updown.Value; i++)
            {
                switch (SpeedIndex)
                {
                    case 1:
                        Player_Possibilities.Run1000m = PossibilitiesAdd(Player_Possibilities.Run1000m);
                        break;
                    case 2:
                        Player_Possibilities.Run800m = PossibilitiesAdd(Player_Possibilities.Run800m);
                        break;
                    case 3:
                        Player_Possibilities.Swim50m = PossibilitiesAdd(Player_Possibilities.Swim50m);
                        break;
                }
            }
            DaysAvailable--;
            SyncAllNums();
            if(DaysAvailable==0)
            {
                examTime = new ExamTime();
                examTime.ShowDialog();
                if(TotalScore<30)
                    MessageBox.Show("混账东西，居然只考了" + TotalScore.ToString() + "分\n滚去签字！", "CP来了", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("很好，你得了30分","CP来了", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        private void ShowPossibilities_Button_Click(object sender, EventArgs e)
        {
            ShowPossibilities();
        }

        private void ConfigExam_Button_Click(object sender, EventArgs e)
        {
            select.ShowDialog();
            ChangeItemName();

        }

        private void FlexMainPoints_Updown_ValueChanged(object sender, EventArgs e)
        {
            if (CheckTotalPoints())
                FlexMainPoints_Updown.Value--;
        }

        private void FlexExtraPoints_Updown_ValueChanged(object sender, EventArgs e)
        {
            if (CheckTotalPoints())
                FlexExtraPoints_Updown.Value--;
        }

        private void PowerPoints_Updown_ValueChanged(object sender, EventArgs e)
        {
            if (CheckTotalPoints())
                PowerPoints_Updown.Value--;
        }

        private void SpeedPoints_Updown_ValueChanged(object sender, EventArgs e)
        {
            if (CheckTotalPoints())
                SpeedPoints_Updown.Value--;
        }
    }
}
