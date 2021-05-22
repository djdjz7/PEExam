
namespace PEExam
{
    partial class Select
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
            this.SelectFlexMain_Dropdown = new System.Windows.Forms.ComboBox();
            this.SelectFlexExtra_Dropdown = new System.Windows.Forms.ComboBox();
            this.SelectPower_Dropdown = new System.Windows.Forms.ComboBox();
            this.SelectSpeed_Dropdown = new System.Windows.Forms.ComboBox();
            this.SelectFlexMain_Label = new System.Windows.Forms.Label();
            this.SelectFlexExtra_Label = new System.Windows.Forms.Label();
            this.SelectPower_Label = new System.Windows.Forms.Label();
            this.SelectSpeed_Label = new System.Windows.Forms.Label();
            this.ConfigPageHeader_Label = new System.Windows.Forms.Label();
            this.ConfigApply_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFlexMain_Dropdown
            // 
            this.SelectFlexMain_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFlexMain_Dropdown.FormattingEnabled = true;
            this.SelectFlexMain_Dropdown.Items.AddRange(new object[] {
            "跳绳",
            "俯卧撑",
            "篮球运球",
            "足球射门"});
            this.SelectFlexMain_Dropdown.Location = new System.Drawing.Point(24, 109);
            this.SelectFlexMain_Dropdown.Name = "SelectFlexMain_Dropdown";
            this.SelectFlexMain_Dropdown.Size = new System.Drawing.Size(121, 25);
            this.SelectFlexMain_Dropdown.TabIndex = 0;
            // 
            // SelectFlexExtra_Dropdown
            // 
            this.SelectFlexExtra_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFlexExtra_Dropdown.FormattingEnabled = true;
            this.SelectFlexExtra_Dropdown.Items.AddRange(new object[] {
            "跳绳",
            "俯卧撑",
            "篮球运球",
            "足球射门"});
            this.SelectFlexExtra_Dropdown.Location = new System.Drawing.Point(151, 109);
            this.SelectFlexExtra_Dropdown.Name = "SelectFlexExtra_Dropdown";
            this.SelectFlexExtra_Dropdown.Size = new System.Drawing.Size(121, 25);
            this.SelectFlexExtra_Dropdown.TabIndex = 1;
            // 
            // SelectPower_Dropdown
            // 
            this.SelectPower_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectPower_Dropdown.FormattingEnabled = true;
            this.SelectPower_Dropdown.Items.AddRange(new object[] {
            "引体向上",
            "掷实心球"});
            this.SelectPower_Dropdown.Location = new System.Drawing.Point(278, 109);
            this.SelectPower_Dropdown.Name = "SelectPower_Dropdown";
            this.SelectPower_Dropdown.Size = new System.Drawing.Size(121, 25);
            this.SelectPower_Dropdown.TabIndex = 2;
            // 
            // SelectSpeed_Dropdown
            // 
            this.SelectSpeed_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSpeed_Dropdown.FormattingEnabled = true;
            this.SelectSpeed_Dropdown.Items.AddRange(new object[] {
            "1000m跑步",
            "800m跑步",
            "50m游泳"});
            this.SelectSpeed_Dropdown.Location = new System.Drawing.Point(405, 109);
            this.SelectSpeed_Dropdown.Name = "SelectSpeed_Dropdown";
            this.SelectSpeed_Dropdown.Size = new System.Drawing.Size(121, 25);
            this.SelectSpeed_Dropdown.TabIndex = 3;
            // 
            // SelectFlexMain_Label
            // 
            this.SelectFlexMain_Label.AutoSize = true;
            this.SelectFlexMain_Label.Location = new System.Drawing.Point(24, 72);
            this.SelectFlexMain_Label.Name = "SelectFlexMain_Label";
            this.SelectFlexMain_Label.Size = new System.Drawing.Size(44, 34);
            this.SelectFlexMain_Label.TabIndex = 4;
            this.SelectFlexMain_Label.Text = "灵巧类\r\n主项";
            // 
            // SelectFlexExtra_Label
            // 
            this.SelectFlexExtra_Label.AutoSize = true;
            this.SelectFlexExtra_Label.Location = new System.Drawing.Point(151, 72);
            this.SelectFlexExtra_Label.Name = "SelectFlexExtra_Label";
            this.SelectFlexExtra_Label.Size = new System.Drawing.Size(44, 34);
            this.SelectFlexExtra_Label.TabIndex = 5;
            this.SelectFlexExtra_Label.Text = "灵巧类\r\n副项";
            // 
            // SelectPower_Label
            // 
            this.SelectPower_Label.AutoSize = true;
            this.SelectPower_Label.Location = new System.Drawing.Point(278, 89);
            this.SelectPower_Label.Name = "SelectPower_Label";
            this.SelectPower_Label.Size = new System.Drawing.Size(44, 17);
            this.SelectPower_Label.TabIndex = 6;
            this.SelectPower_Label.Text = "力量类";
            // 
            // SelectSpeed_Label
            // 
            this.SelectSpeed_Label.AutoSize = true;
            this.SelectSpeed_Label.Location = new System.Drawing.Point(405, 89);
            this.SelectSpeed_Label.Name = "SelectSpeed_Label";
            this.SelectSpeed_Label.Size = new System.Drawing.Size(68, 17);
            this.SelectSpeed_Label.TabIndex = 7;
            this.SelectSpeed_Label.Text = "速度耐力类";
            // 
            // ConfigPageHeader_Label
            // 
            this.ConfigPageHeader_Label.AutoSize = true;
            this.ConfigPageHeader_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfigPageHeader_Label.Location = new System.Drawing.Point(12, 9);
            this.ConfigPageHeader_Label.Name = "ConfigPageHeader_Label";
            this.ConfigPageHeader_Label.Size = new System.Drawing.Size(335, 46);
            this.ConfigPageHeader_Label.TabIndex = 8;
            this.ConfigPageHeader_Label.Text = "配置训练或考试项目";
            // 
            // ConfigApply_Button
            // 
            this.ConfigApply_Button.Location = new System.Drawing.Point(451, 165);
            this.ConfigApply_Button.Name = "ConfigApply_Button";
            this.ConfigApply_Button.Size = new System.Drawing.Size(75, 23);
            this.ConfigApply_Button.TabIndex = 9;
            this.ConfigApply_Button.Text = "应用";
            this.ConfigApply_Button.UseVisualStyleBackColor = true;
            this.ConfigApply_Button.Click += new System.EventHandler(this.ConfigApply_Button_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 200);
            this.ControlBox = false;
            this.Controls.Add(this.ConfigApply_Button);
            this.Controls.Add(this.ConfigPageHeader_Label);
            this.Controls.Add(this.SelectSpeed_Label);
            this.Controls.Add(this.SelectPower_Label);
            this.Controls.Add(this.SelectFlexExtra_Label);
            this.Controls.Add(this.SelectFlexMain_Label);
            this.Controls.Add(this.SelectSpeed_Dropdown);
            this.Controls.Add(this.SelectPower_Dropdown);
            this.Controls.Add(this.SelectFlexExtra_Dropdown);
            this.Controls.Add(this.SelectFlexMain_Dropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectFlexMain_Dropdown;
        private System.Windows.Forms.ComboBox SelectFlexExtra_Dropdown;
        private System.Windows.Forms.ComboBox SelectPower_Dropdown;
        private System.Windows.Forms.ComboBox SelectSpeed_Dropdown;
        private System.Windows.Forms.Label SelectFlexMain_Label;
        private System.Windows.Forms.Label SelectFlexExtra_Label;
        private System.Windows.Forms.Label SelectPower_Label;
        private System.Windows.Forms.Label SelectSpeed_Label;
        private System.Windows.Forms.Label ConfigPageHeader_Label;
        private System.Windows.Forms.Button ConfigApply_Button;
    }
}