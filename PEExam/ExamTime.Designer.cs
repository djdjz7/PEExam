
namespace PEExam
{
    partial class ExamTime
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
            this.ExamTimePageTitile = new System.Windows.Forms.Label();
            this.Status_Bar = new System.Windows.Forms.ProgressBar();
            this.Status_Label = new System.Windows.Forms.Label();
            this.StartExam_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExamTimePageTitile
            // 
            this.ExamTimePageTitile.AutoSize = true;
            this.ExamTimePageTitile.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExamTimePageTitile.Location = new System.Drawing.Point(12, 9);
            this.ExamTimePageTitile.Name = "ExamTimePageTitile";
            this.ExamTimePageTitile.Size = new System.Drawing.Size(440, 46);
            this.ExamTimePageTitile.TabIndex = 0;
            this.ExamTimePageTitile.Text = "不知道哪里的体育中考测试\r\n";
            // 
            // Status_Bar
            // 
            this.Status_Bar.Location = new System.Drawing.Point(12, 126);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.Size = new System.Drawing.Size(440, 23);
            this.Status_Bar.TabIndex = 1;
            // 
            // Status_Label
            // 
            this.Status_Label.BackColor = System.Drawing.Color.Transparent;
            this.Status_Label.Location = new System.Drawing.Point(0, 96);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(470, 23);
            this.Status_Label.TabIndex = 2;
            this.Status_Label.Text = "请考生做好测试准备";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartExam_Button
            // 
            this.StartExam_Button.Location = new System.Drawing.Point(194, 178);
            this.StartExam_Button.Name = "StartExam_Button";
            this.StartExam_Button.Size = new System.Drawing.Size(75, 23);
            this.StartExam_Button.TabIndex = 3;
            this.StartExam_Button.Text = "开始测试";
            this.StartExam_Button.UseVisualStyleBackColor = true;
            this.StartExam_Button.Click += new System.EventHandler(this.StartExam_Button_Click);
            // 
            // ExamTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 213);
            this.Controls.Add(this.StartExam_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.ExamTimePageTitile);
            this.Name = "ExamTime";
            this.Text = "ExamTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExamTimePageTitile;
        private System.Windows.Forms.ProgressBar Status_Bar;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button StartExam_Button;
    }
}