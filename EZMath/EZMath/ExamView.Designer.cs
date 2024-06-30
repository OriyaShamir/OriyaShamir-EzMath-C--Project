namespace EZMath
{
    partial class ExamView
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ShowExamPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.basad = new System.Windows.Forms.Label();
            this.ExamDateLabel = new System.Windows.Forms.Label();
            this.ExamNameLabel = new System.Windows.Forms.Label();
            this.ExamNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(866, 11);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(53, 31);
            this.GoBackButton.TabIndex = 39;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ShowExamPanel
            // 
            this.ShowExamPanel.AutoScroll = true;
            this.ShowExamPanel.Location = new System.Drawing.Point(12, 206);
            this.ShowExamPanel.Name = "ShowExamPanel";
            this.ShowExamPanel.Size = new System.Drawing.Size(817, 454);
            this.ShowExamPanel.TabIndex = 40;
            // 
            // basad
            // 
            this.basad.AutoSize = true;
            this.basad.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basad.Location = new System.Drawing.Point(787, 22);
            this.basad.Name = "basad";
            this.basad.Size = new System.Drawing.Size(50, 26);
            this.basad.TabIndex = 41;
            this.basad.Text = "בס\"ד";
            // 
            // ExamDateLabel
            // 
            this.ExamDateLabel.AutoSize = true;
            this.ExamDateLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamDateLabel.Location = new System.Drawing.Point(103, 19);
            this.ExamDateLabel.Name = "ExamDateLabel";
            this.ExamDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExamDateLabel.Size = new System.Drawing.Size(121, 26);
            this.ExamDateLabel.TabIndex = 42;
            this.ExamDateLabel.Text = "תאריך המבחן:";
            // 
            // ExamNameLabel
            // 
            this.ExamNameLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamNameLabel.Location = new System.Drawing.Point(267, 20);
            this.ExamNameLabel.Name = "ExamNameLabel";
            this.ExamNameLabel.Size = new System.Drawing.Size(301, 23);
            this.ExamNameLabel.TabIndex = 43;
            this.ExamNameLabel.Text = "מבחן חדש";
            this.ExamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExamNotes
            // 
            this.ExamNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamNotes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamNotes.Location = new System.Drawing.Point(12, 89);
            this.ExamNotes.Name = "ExamNotes";
            this.ExamNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExamNotes.Size = new System.Drawing.Size(817, 96);
            this.ExamNotes.TabIndex = 44;
            this.ExamNotes.Text = "";
            // 
            // ExamView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(920, 672);
            this.Controls.Add(this.ExamNotes);
            this.Controls.Add(this.ExamNameLabel);
            this.Controls.Add(this.ExamDateLabel);
            this.Controls.Add(this.basad);
            this.Controls.Add(this.ShowExamPanel);
            this.Controls.Add(this.GoBackButton);
            this.Name = "ExamView";
            this.Text = "ExamView";
            this.Load += new System.EventHandler(this.ExamView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.FlowLayoutPanel ShowExamPanel;
        private System.Windows.Forms.Label basad;
        private System.Windows.Forms.Label ExamDateLabel;
        private System.Windows.Forms.Label ExamNameLabel;
        private System.Windows.Forms.RichTextBox ExamNotes;
    }
}