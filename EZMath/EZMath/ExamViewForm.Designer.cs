
namespace EZMath
{
    partial class ExamViewForm
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
            this.ShowExamBtn = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // examList
            // 
            this.examList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examList.FormattingEnabled = true;
            this.examList.Location = new System.Drawing.Point(166, 90);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(140, 21);
            this.examList.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(327, 87);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "מבחן:";
            // 
            // ShowExamBtn
            // 
            this.ShowExamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowExamBtn.Location = new System.Drawing.Point(216, 196);
            this.ShowExamBtn.Name = "ShowExamBtn";
            this.ShowExamBtn.Size = new System.Drawing.Size(140, 38);
            this.ShowExamBtn.TabIndex = 37;
            this.ShowExamBtn.Text = "הצג מבחן";
            this.ShowExamBtn.UseVisualStyleBackColor = true;
            this.ShowExamBtn.Click += new System.EventHandler(this.ShowExamBtn_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(491, 285);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(74, 44);
            this.GoBackButton.TabIndex = 38;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 341);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ShowExamBtn);
            this.Controls.Add(this.examList);
            this.Controls.Add(this.label1);
            this.Name = "ExamViewForm";
            this.Text = "ExamViewForm";
            this.Load += new System.EventHandler(this.ExamViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox examList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowExamBtn;
        private System.Windows.Forms.Button GoBackButton;
    }
}