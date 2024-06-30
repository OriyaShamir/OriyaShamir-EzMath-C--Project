
namespace EZMath
{
    partial class TeacherMainForm
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
            this.createExam = new System.Windows.Forms.Button();
            this.AddEx = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StatsBtn = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewExams = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createExam
            // 
            this.createExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExam.Location = new System.Drawing.Point(324, 150);
            this.createExam.Name = "createExam";
            this.createExam.Size = new System.Drawing.Size(139, 44);
            this.createExam.TabIndex = 5;
            this.createExam.Text = "יצירת מבחן ";
            this.createExam.UseVisualStyleBackColor = true;
            this.createExam.Click += new System.EventHandler(this.createExam_Click);
            // 
            // AddEx
            // 
            this.AddEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEx.Location = new System.Drawing.Point(324, 200);
            this.AddEx.Name = "AddEx";
            this.AddEx.Size = new System.Drawing.Size(139, 44);
            this.AddEx.TabIndex = 6;
            this.AddEx.Text = "הוספת תרגיל";
            this.AddEx.UseVisualStyleBackColor = true;
            this.AddEx.Click += new System.EventHandler(this.AddEx_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "הזן ציונים";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatsBtn
            // 
            this.StatsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsBtn.Location = new System.Drawing.Point(324, 300);
            this.StatsBtn.Name = "StatsBtn";
            this.StatsBtn.Size = new System.Drawing.Size(139, 44);
            this.StatsBtn.TabIndex = 8;
            this.StatsBtn.Text = "סטטיסטיקה";
            this.StatsBtn.UseVisualStyleBackColor = true;
            this.StatsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(705, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helloLabel.Size = new System.Drawing.Size(0, 24);
            this.helloLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "מתמטיקה בקליל";
            // 
            // ViewExams
            // 
            this.ViewExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExams.Location = new System.Drawing.Point(612, 394);
            this.ViewExams.Name = "ViewExams";
            this.ViewExams.Size = new System.Drawing.Size(176, 44);
            this.ViewExams.TabIndex = 12;
            this.ViewExams.Text = "רשימת המבחנים שלי";
            this.ViewExams.UseVisualStyleBackColor = true;
            this.ViewExams.Click += new System.EventHandler(this.ViewExams_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.Red;
            this.LogOutButton.Location = new System.Drawing.Point(12, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(139, 44);
            this.LogOutButton.TabIndex = 13;
            this.LogOutButton.Text = "התנתק";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ViewExams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.StatsBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddEx);
            this.Controls.Add(this.createExam);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createExam;
        private System.Windows.Forms.Button AddEx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StatsBtn;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewExams;
        private System.Windows.Forms.Button LogOutButton;
    }
}