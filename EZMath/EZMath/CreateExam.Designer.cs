
namespace EZMath
{
    partial class CreateExam
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.examName = new System.Windows.Forms.TextBox();
            this.SubjectCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.examRules = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateT = new System.Windows.Forms.DateTimePicker();
            this.exPreview = new System.Windows.Forms.PictureBox();
            this.leftEx = new System.Windows.Forms.Button();
            this.rightEx = new System.Windows.Forms.Button();
            this.addEx = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.currentLoc = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.viewAllEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "נושא:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(968, 112);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "שם המבחן:";
            // 
            // examName
            // 
            this.examName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examName.Location = new System.Drawing.Point(736, 110);
            this.examName.Name = "examName";
            this.examName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.examName.Size = new System.Drawing.Size(199, 26);
            this.examName.TabIndex = 4;
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubjectCombo.FormattingEnabled = true;
            this.SubjectCombo.Location = new System.Drawing.Point(220, 70);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubjectCombo.Size = new System.Drawing.Size(199, 28);
            this.SubjectCombo.TabIndex = 8;
            this.SubjectCombo.SelectedIndexChanged += new System.EventHandler(this.subjects_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(968, 156);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "הוראות:";
            // 
            // examRules
            // 
            this.examRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examRules.Location = new System.Drawing.Point(736, 156);
            this.examRules.Multiline = true;
            this.examRules.Name = "examRules";
            this.examRules.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.examRules.Size = new System.Drawing.Size(199, 155);
            this.examRules.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(968, 354);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "תאריך:";
            // 
            // dateT
            // 
            this.dateT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateT.Location = new System.Drawing.Point(740, 354);
            this.dateT.Name = "dateT";
            this.dateT.Size = new System.Drawing.Size(200, 20);
            this.dateT.TabIndex = 12;
            // 
            // exPreview
            // 
            this.exPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exPreview.Location = new System.Drawing.Point(40, 156);
            this.exPreview.Name = "exPreview";
            this.exPreview.Size = new System.Drawing.Size(625, 316);
            this.exPreview.TabIndex = 13;
            this.exPreview.TabStop = false;
            // 
            // leftEx
            // 
            this.leftEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.leftEx.Location = new System.Drawing.Point(40, 521);
            this.leftEx.Name = "leftEx";
            this.leftEx.Size = new System.Drawing.Size(75, 30);
            this.leftEx.TabIndex = 14;
            this.leftEx.Text = "<--";
            this.leftEx.UseVisualStyleBackColor = true;
            this.leftEx.Click += new System.EventHandler(this.leftEx_Click);
            // 
            // rightEx
            // 
            this.rightEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rightEx.Location = new System.Drawing.Point(583, 521);
            this.rightEx.Name = "rightEx";
            this.rightEx.Size = new System.Drawing.Size(82, 30);
            this.rightEx.TabIndex = 15;
            this.rightEx.Text = "-->";
            this.rightEx.UseVisualStyleBackColor = true;
            this.rightEx.Click += new System.EventHandler(this.rightEx_Click);
            // 
            // addEx
            // 
            this.addEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addEx.Location = new System.Drawing.Point(258, 521);
            this.addEx.Name = "addEx";
            this.addEx.Size = new System.Drawing.Size(161, 30);
            this.addEx.TabIndex = 16;
            this.addEx.Text = "הוסף תרגיל";
            this.addEx.UseVisualStyleBackColor = true;
            this.addEx.Click += new System.EventHandler(this.addEx_Click);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(736, 507);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(199, 44);
            this.create.TabIndex = 17;
            this.create.Text = "יצירת מבחן ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // currentLoc
            // 
            this.currentLoc.AutoSize = true;
            this.currentLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.currentLoc.Location = new System.Drawing.Point(338, 486);
            this.currentLoc.Name = "currentLoc";
            this.currentLoc.Size = new System.Drawing.Size(0, 24);
            this.currentLoc.TabIndex = 18;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(1054, 513);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(67, 38);
            this.GoBackButton.TabIndex = 19;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "יצירת מבחן";
            // 
            // viewAllEx
            // 
            this.viewAllEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewAllEx.Location = new System.Drawing.Point(40, 110);
            this.viewAllEx.Name = "viewAllEx";
            this.viewAllEx.Size = new System.Drawing.Size(625, 30);
            this.viewAllEx.TabIndex = 21;
            this.viewAllEx.Text = "הצג את כל התרגילים";
            this.viewAllEx.UseVisualStyleBackColor = true;
            this.viewAllEx.Click += new System.EventHandler(this.viewAllEx_Click);
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 563);
            this.Controls.Add(this.viewAllEx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.currentLoc);
            this.Controls.Add(this.create);
            this.Controls.Add(this.addEx);
            this.Controls.Add(this.rightEx);
            this.Controls.Add(this.leftEx);
            this.Controls.Add(this.exPreview);
            this.Controls.Add(this.dateT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.examRules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjectCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examName);
            this.Name = "CreateExam";
            this.Text = "CreateExam";
            this.Load += new System.EventHandler(this.CreateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox examName;
        private System.Windows.Forms.ComboBox SubjectCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox examRules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateT;
        private System.Windows.Forms.PictureBox exPreview;
        private System.Windows.Forms.Button leftEx;
        private System.Windows.Forms.Button rightEx;
        private System.Windows.Forms.Button addEx;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label currentLoc;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button viewAllEx;
    }
}