
namespace PEExam
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Train_Button = new System.Windows.Forms.Button();
            this.PointsAvaiLabel_Label = new System.Windows.Forms.Label();
            this.PointsAvaiLabel_Num = new System.Windows.Forms.Label();
            this.DaysAvailable_Num = new System.Windows.Forms.Label();
            this.DaysAvailable_Label = new System.Windows.Forms.Label();
            this.TiringPointsAvaiLabel_Num = new System.Windows.Forms.Label();
            this.TiringPointsAvaiLabel_Label = new System.Windows.Forms.Label();
            this.ConfigExam_Button = new System.Windows.Forms.Button();
            this.FlexMainItemName = new System.Windows.Forms.Label();
            this.FlexExtraItemName = new System.Windows.Forms.Label();
            this.PowerItemName = new System.Windows.Forms.Label();
            this.SpeedItemName = new System.Windows.Forms.Label();
            this.FlexMainPoints_Updown = new System.Windows.Forms.NumericUpDown();
            this.FlexExtraPoints_Updown = new System.Windows.Forms.NumericUpDown();
            this.PowerPoints_Updown = new System.Windows.Forms.NumericUpDown();
            this.SpeedPoints_Updown = new System.Windows.Forms.NumericUpDown();
            this.ShowPossibilities_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlexMainPoints_Updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexExtraPoints_Updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPoints_Updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPoints_Updown)).BeginInit();
            this.SuspendLayout();
            // 
            // Train_Button
            // 
            this.Train_Button.Location = new System.Drawing.Point(365, 106);
            this.Train_Button.Name = "Train_Button";
            this.Train_Button.Size = new System.Drawing.Size(75, 23);
            this.Train_Button.TabIndex = 0;
            this.Train_Button.Text = "训练！";
            this.Train_Button.UseVisualStyleBackColor = true;
            this.Train_Button.Click += new System.EventHandler(this.Train_Button_Click);
            // 
            // PointsAvaiLabel_Label
            // 
            this.PointsAvaiLabel_Label.AutoSize = true;
            this.PointsAvaiLabel_Label.Location = new System.Drawing.Point(23, 62);
            this.PointsAvaiLabel_Label.Name = "PointsAvaiLabel_Label";
            this.PointsAvaiLabel_Label.Size = new System.Drawing.Size(80, 17);
            this.PointsAvaiLabel_Label.TabIndex = 1;
            this.PointsAvaiLabel_Label.Text = "每日可用点数";
            // 
            // PointsAvaiLabel_Num
            // 
            this.PointsAvaiLabel_Num.AutoSize = true;
            this.PointsAvaiLabel_Num.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PointsAvaiLabel_Num.Location = new System.Drawing.Point(23, 16);
            this.PointsAvaiLabel_Num.Name = "PointsAvaiLabel_Num";
            this.PointsAvaiLabel_Num.Size = new System.Drawing.Size(42, 46);
            this.PointsAvaiLabel_Num.TabIndex = 2;
            this.PointsAvaiLabel_Num.Text = "0";
            // 
            // DaysAvailable_Num
            // 
            this.DaysAvailable_Num.AutoSize = true;
            this.DaysAvailable_Num.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DaysAvailable_Num.Location = new System.Drawing.Point(127, 16);
            this.DaysAvailable_Num.Name = "DaysAvailable_Num";
            this.DaysAvailable_Num.Size = new System.Drawing.Size(86, 46);
            this.DaysAvailable_Num.TabIndex = 3;
            this.DaysAvailable_Num.Text = "100";
            // 
            // DaysAvailable_Label
            // 
            this.DaysAvailable_Label.AutoSize = true;
            this.DaysAvailable_Label.Location = new System.Drawing.Point(127, 62);
            this.DaysAvailable_Label.Name = "DaysAvailable_Label";
            this.DaysAvailable_Label.Size = new System.Drawing.Size(80, 17);
            this.DaysAvailable_Label.TabIndex = 4;
            this.DaysAvailable_Label.Text = "剩余可用天数";
            // 
            // TiringPointsAvaiLabel_Num
            // 
            this.TiringPointsAvaiLabel_Num.AutoSize = true;
            this.TiringPointsAvaiLabel_Num.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TiringPointsAvaiLabel_Num.Location = new System.Drawing.Point(240, 16);
            this.TiringPointsAvaiLabel_Num.Name = "TiringPointsAvaiLabel_Num";
            this.TiringPointsAvaiLabel_Num.Size = new System.Drawing.Size(42, 46);
            this.TiringPointsAvaiLabel_Num.TabIndex = 5;
            this.TiringPointsAvaiLabel_Num.Text = "0";
            this.TiringPointsAvaiLabel_Num.Visible = false;
            // 
            // TiringPointsAvaiLabel_Label
            // 
            this.TiringPointsAvaiLabel_Label.AutoSize = true;
            this.TiringPointsAvaiLabel_Label.Location = new System.Drawing.Point(240, 62);
            this.TiringPointsAvaiLabel_Label.Name = "TiringPointsAvaiLabel_Label";
            this.TiringPointsAvaiLabel_Label.Size = new System.Drawing.Size(92, 17);
            this.TiringPointsAvaiLabel_Label.TabIndex = 6;
            this.TiringPointsAvaiLabel_Label.Text = "累计可用疲劳度";
            this.TiringPointsAvaiLabel_Label.Visible = false;
            // 
            // ConfigExam_Button
            // 
            this.ConfigExam_Button.Location = new System.Drawing.Point(365, 135);
            this.ConfigExam_Button.Name = "ConfigExam_Button";
            this.ConfigExam_Button.Size = new System.Drawing.Size(75, 23);
            this.ConfigExam_Button.TabIndex = 7;
            this.ConfigExam_Button.Text = "配置训练";
            this.ConfigExam_Button.UseVisualStyleBackColor = true;
            this.ConfigExam_Button.Click += new System.EventHandler(this.ConfigExam_Button_Click);
            // 
            // FlexMainItemName
            // 
            this.FlexMainItemName.AutoSize = true;
            this.FlexMainItemName.Location = new System.Drawing.Point(23, 112);
            this.FlexMainItemName.Name = "FlexMainItemName";
            this.FlexMainItemName.Size = new System.Drawing.Size(56, 17);
            this.FlexMainItemName.TabIndex = 8;
            this.FlexMainItemName.Text = "flexmain";
            // 
            // FlexExtraItemName
            // 
            this.FlexExtraItemName.AutoSize = true;
            this.FlexExtraItemName.Location = new System.Drawing.Point(23, 148);
            this.FlexExtraItemName.Name = "FlexExtraItemName";
            this.FlexExtraItemName.Size = new System.Drawing.Size(57, 17);
            this.FlexExtraItemName.TabIndex = 9;
            this.FlexExtraItemName.Text = "flexextra";
            // 
            // PowerItemName
            // 
            this.PowerItemName.AutoSize = true;
            this.PowerItemName.Location = new System.Drawing.Point(23, 178);
            this.PowerItemName.Name = "PowerItemName";
            this.PowerItemName.Size = new System.Drawing.Size(45, 17);
            this.PowerItemName.TabIndex = 10;
            this.PowerItemName.Text = "power";
            // 
            // SpeedItemName
            // 
            this.SpeedItemName.AutoSize = true;
            this.SpeedItemName.Location = new System.Drawing.Point(23, 214);
            this.SpeedItemName.Name = "SpeedItemName";
            this.SpeedItemName.Size = new System.Drawing.Size(44, 17);
            this.SpeedItemName.TabIndex = 11;
            this.SpeedItemName.Text = "speed";
            // 
            // FlexMainPoints_Updown
            // 
            this.FlexMainPoints_Updown.Location = new System.Drawing.Point(164, 112);
            this.FlexMainPoints_Updown.Name = "FlexMainPoints_Updown";
            this.FlexMainPoints_Updown.ReadOnly = true;
            this.FlexMainPoints_Updown.Size = new System.Drawing.Size(120, 23);
            this.FlexMainPoints_Updown.TabIndex = 12;
            this.FlexMainPoints_Updown.ValueChanged += new System.EventHandler(this.FlexMainPoints_Updown_ValueChanged);
            // 
            // FlexExtraPoints_Updown
            // 
            this.FlexExtraPoints_Updown.Location = new System.Drawing.Point(164, 148);
            this.FlexExtraPoints_Updown.Name = "FlexExtraPoints_Updown";
            this.FlexExtraPoints_Updown.ReadOnly = true;
            this.FlexExtraPoints_Updown.Size = new System.Drawing.Size(120, 23);
            this.FlexExtraPoints_Updown.TabIndex = 13;
            this.FlexExtraPoints_Updown.ValueChanged += new System.EventHandler(this.FlexExtraPoints_Updown_ValueChanged);
            // 
            // PowerPoints_Updown
            // 
            this.PowerPoints_Updown.Location = new System.Drawing.Point(164, 178);
            this.PowerPoints_Updown.Name = "PowerPoints_Updown";
            this.PowerPoints_Updown.ReadOnly = true;
            this.PowerPoints_Updown.Size = new System.Drawing.Size(120, 23);
            this.PowerPoints_Updown.TabIndex = 14;
            this.PowerPoints_Updown.ValueChanged += new System.EventHandler(this.PowerPoints_Updown_ValueChanged);
            // 
            // SpeedPoints_Updown
            // 
            this.SpeedPoints_Updown.Location = new System.Drawing.Point(164, 214);
            this.SpeedPoints_Updown.Name = "SpeedPoints_Updown";
            this.SpeedPoints_Updown.ReadOnly = true;
            this.SpeedPoints_Updown.Size = new System.Drawing.Size(120, 23);
            this.SpeedPoints_Updown.TabIndex = 15;
            this.SpeedPoints_Updown.ValueChanged += new System.EventHandler(this.SpeedPoints_Updown_ValueChanged);
            // 
            // ShowPossibilities_Button
            // 
            this.ShowPossibilities_Button.Location = new System.Drawing.Point(365, 164);
            this.ShowPossibilities_Button.Name = "ShowPossibilities_Button";
            this.ShowPossibilities_Button.Size = new System.Drawing.Size(75, 23);
            this.ShowPossibilities_Button.TabIndex = 16;
            this.ShowPossibilities_Button.Text = "当前天赋";
            this.ShowPossibilities_Button.UseVisualStyleBackColor = true;
            this.ShowPossibilities_Button.Click += new System.EventHandler(this.ShowPossibilities_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.ShowPossibilities_Button);
            this.Controls.Add(this.SpeedPoints_Updown);
            this.Controls.Add(this.PowerPoints_Updown);
            this.Controls.Add(this.FlexExtraPoints_Updown);
            this.Controls.Add(this.FlexMainPoints_Updown);
            this.Controls.Add(this.SpeedItemName);
            this.Controls.Add(this.PowerItemName);
            this.Controls.Add(this.FlexExtraItemName);
            this.Controls.Add(this.FlexMainItemName);
            this.Controls.Add(this.ConfigExam_Button);
            this.Controls.Add(this.TiringPointsAvaiLabel_Label);
            this.Controls.Add(this.TiringPointsAvaiLabel_Num);
            this.Controls.Add(this.DaysAvailable_Label);
            this.Controls.Add(this.DaysAvailable_Num);
            this.Controls.Add(this.PointsAvaiLabel_Num);
            this.Controls.Add(this.PointsAvaiLabel_Label);
            this.Controls.Add(this.Train_Button);
            this.Name = "Main";
            this.Text = "PEExams";
            ((System.ComponentModel.ISupportInitialize)(this.FlexMainPoints_Updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexExtraPoints_Updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPoints_Updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPoints_Updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Train_Button;
        private System.Windows.Forms.Label PointsAvaiLabel_Label;
        private System.Windows.Forms.Label PointsAvaiLabel_Num;
        private System.Windows.Forms.Label DaysAvailable_Num;
        private System.Windows.Forms.Label DaysAvailable_Label;
        private System.Windows.Forms.Label TiringPointsAvaiLabel_Num;
        private System.Windows.Forms.Label TiringPointsAvaiLabel_Label;
        private System.Windows.Forms.Button ConfigExam_Button;
        private System.Windows.Forms.Label FlexMainItemName;
        private System.Windows.Forms.Label FlexExtraItemName;
        private System.Windows.Forms.Label PowerItemName;
        private System.Windows.Forms.Label SpeedItemName;
        private System.Windows.Forms.NumericUpDown FlexMainPoints_Updown;
        private System.Windows.Forms.NumericUpDown FlexExtraPoints_Updown;
        private System.Windows.Forms.NumericUpDown PowerPoints_Updown;
        private System.Windows.Forms.NumericUpDown SpeedPoints_Updown;
        private System.Windows.Forms.Button ShowPossibilities_Button;
    }
}

