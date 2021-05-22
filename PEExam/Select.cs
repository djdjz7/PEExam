using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PEExam
{
    public partial class Select : Form
    {
        public bool CanClose = false;

        protected override void OnClosing(CancelEventArgs e)
        {
            if(!CanClose)
            e.Cancel = true; //取消关闭操作
        }

        public Select()
        {
            InitializeComponent();
        }

        private void ConfigApply_Button_Click(object sender, EventArgs e)
        {
            if (SelectFlexMain_Dropdown.SelectedItem == null || SelectFlexExtra_Dropdown.SelectedItem == null || SelectPower_Dropdown.SelectedItem == null || SelectSpeed_Dropdown.SelectedItem == null)
            {
                MessageBox.Show(null, "不可有任何一项为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectFlexMain_Dropdown.SelectedItem == SelectFlexExtra_Dropdown.SelectedItem)
            {
                MessageBox.Show(null, "灵巧类主项与辅项不可一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Main.FlexMainIndex = SelectFlexMain_Dropdown.SelectedIndex + 1;
            Main.FlexExtraIndex = SelectFlexExtra_Dropdown.SelectedIndex + 1;
            Main.PowerIndex = SelectPower_Dropdown.SelectedIndex + 1;
            Main.SpeedIndex = SelectSpeed_Dropdown.SelectedIndex + 1;
            CanClose = true;
            this.Close();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }
    }
}
