
namespace EZMath
{
    partial class StatsForm
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
            this.examList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionList = new System.Windows.Forms.ComboBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.exPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExamAvg = new System.Windows.Forms.Label();
            this.ExAvg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExTeacherAvg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExExamAvg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.cotaratStats = new System.Windows.Forms.Label();
            this.ClassCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassStat = new System.Windows.Forms.Label();
            this.Recommendations = new System.Windows.Forms.Button();
            this.RecommandHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // examList
            // 
            this.examList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examList.FormattingEnabled = true;
            this.examList.Location = new System.Drawing.Point(556, 118);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(140, 21);
            this.examList.TabIndex = 26;
            this.examList.SelectedIndexChanged += new System.EventHandler(this.examList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(734, 115);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "מבחן:";
            // 
            // QuestionList
            // 
            this.QuestionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(556, 153);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(140, 21);
            this.QuestionList.TabIndex = 24;
            this.QuestionList.SelectedIndexChanged += new System.EventHandler(this.QuestionList_SelectedIndexChanged);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.QuestionLabel.Location = new System.Drawing.Point(734, 150);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuestionLabel.Size = new System.Drawing.Size(60, 24);
            this.QuestionLabel.TabIndex = 23;
            this.QuestionLabel.Text = "שאלה:";
            // 
            // exPreview
            // 
            this.exPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exPreview.Location = new System.Drawing.Point(12, 81);
            this.exPreview.Name = "exPreview";
            this.exPreview.Size = new System.Drawing.Size(481, 242);
            this.exPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exPreview.TabIndex = 27;
            this.exPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(673, 197);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "ממוצע המבחן:";
            // 
            // ExamAvg
            // 
            this.ExamAvg.AutoSize = true;
            this.ExamAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExamAvg.Location = new System.Drawing.Point(540, 197);
            this.ExamAvg.Name = "ExamAvg";
            this.ExamAvg.Size = new System.Drawing.Size(0, 24);
            this.ExamAvg.TabIndex = 29;
            // 
            // ExAvg
            // 
            this.ExAvg.AutoSize = true;
            this.ExAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExAvg.Location = new System.Drawing.Point(544, 245);
            this.ExAvg.Name = "ExAvg";
            this.ExAvg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExAvg.Size = new System.Drawing.Size(0, 24);
            this.ExAvg.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(670, 245);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "ממוצע התרגיל:";
            // 
            // ExTeacherAvg
            // 
            this.ExTeacherAvg.AutoSize = true;
            this.ExTeacherAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExTeacherAvg.Location = new System.Drawing.Point(540, 269);
            this.ExTeacherAvg.Name = "ExTeacherAvg";
            this.ExTeacherAvg.Size = new System.Drawing.Size(0, 24);
            this.ExTeacherAvg.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(616, 269);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "ממצוע התרגיל למורה:";
            // 
            // ExExamAvg
            // 
            this.ExExamAvg.AutoSize = true;
            this.ExExamAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExExamAvg.Location = new System.Drawing.Point(540, 221);
            this.ExExamAvg.Name = "ExExamAvg";
            this.ExExamAvg.Size = new System.Drawing.Size(0, 24);
            this.ExExamAvg.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(616, 221);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "ממוצע התרגיל במבחן:";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(708, 400);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(67, 38);
            this.GoBackButton.TabIndex = 36;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // cotaratStats
            // 
            this.cotaratStats.AutoSize = true;
            this.cotaratStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cotaratStats.Location = new System.Drawing.Point(274, 22);
            this.cotaratStats.Name = "cotaratStats";
            this.cotaratStats.Size = new System.Drawing.Size(253, 29);
            this.cotaratStats.TabIndex = 37;
            this.cotaratStats.Text = "חישוב נתונים וסטיסטיקות";
            // 
            // ClassCombobox
            // 
            this.ClassCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombobox.FormattingEnabled = true;
            this.ClassCombobox.Location = new System.Drawing.Point(556, 84);
            this.ClassCombobox.Name = "ClassCombobox";
            this.ClassCombobox.Size = new System.Drawing.Size(140, 21);
            this.ClassCombobox.TabIndex = 39;
            this.ClassCombobox.SelectedIndexChanged += new System.EventHandler(this.ClassCombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(734, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "כיתה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(615, 293);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "ממוצע התרגיל בכיתה:";
            // 
            // ClassStat
            // 
            this.ClassStat.AutoSize = true;
            this.ClassStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClassStat.Location = new System.Drawing.Point(540, 293);
            this.ClassStat.Name = "ClassStat";
            this.ClassStat.Size = new System.Drawing.Size(0, 24);
            this.ClassStat.TabIndex = 35;
            // 
            // Recommendations
            // 
            this.Recommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recommendations.Location = new System.Drawing.Point(646, 336);
            this.Recommendations.Name = "Recommendations";
            this.Recommendations.Size = new System.Drawing.Size(142, 38);
            this.Recommendations.TabIndex = 41;
            this.Recommendations.Text = "קבל המלצות";
            this.Recommendations.UseVisualStyleBackColor = true;
            this.Recommendations.Click += new System.EventHandler(this.Recommendations_Click);
            // 
            // RecommandHelp
            // 
            this.RecommandHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommandHelp.Location = new System.Drawing.Point(23, 391);
            this.RecommandHelp.Name = "RecommandHelp";
            this.RecommandHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RecommandHelp.Size = new System.Drawing.Size(230, 47);
            this.RecommandHelp.TabIndex = 42;
            this.RecommandHelp.Text = "לפי מה אני מקבל המלצות?";
            this.RecommandHelp.UseVisualStyleBackColor = true;
            this.RecommandHelp.Click += new System.EventHandler(this.RecommandHelp_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecommandHelp);
            this.Controls.Add(this.Recommendations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cotaratStats);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ClassStat);
            this.Controls.Add(this.ExTeacherAvg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExExamAvg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExAvg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExamAvg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exPreview);
            this.Controls.Add(this.examList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox examList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QuestionList;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.PictureBox exPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExamAvg;
        private System.Windows.Forms.Label ExAvg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ExTeacherAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ExExamAvg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label cotaratStats;
        private System.Windows.Forms.ComboBox ClassCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClassStat;
        private System.Windows.Forms.Button Recommendations;
        private System.Windows.Forms.Button RecommandHelp;
    }
}