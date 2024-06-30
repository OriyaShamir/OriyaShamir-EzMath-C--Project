namespace EZMath
{
    partial class AddExForm
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
            this.ExSubLabel = new System.Windows.Forms.Label();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.Coteret = new System.Windows.Forms.Label();
            this.exPreview = new System.Windows.Forms.PictureBox();
            this.BrowseFolder = new System.Windows.Forms.Button();
            this.AddExButton = new System.Windows.Forms.Button();
            this.ExDifflabel = new System.Windows.Forms.Label();
            this.DiffList = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.BrowseFolderFinalAns = new System.Windows.Forms.Button();
            this.FinalAns = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalAns)).BeginInit();
            this.SuspendLayout();
            // 
            // ExSubLabel
            // 
            this.ExSubLabel.AutoSize = true;
            this.ExSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExSubLabel.Location = new System.Drawing.Point(946, 123);
            this.ExSubLabel.Name = "ExSubLabel";
            this.ExSubLabel.Size = new System.Drawing.Size(51, 24);
            this.ExSubLabel.TabIndex = 0;
            this.ExSubLabel.Text = "נושא:";
            // 
            // SubjectList
            // 
            this.SubjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(719, 126);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(153, 21);
            this.SubjectList.TabIndex = 1;
            // 
            // Coteret
            // 
            this.Coteret.AutoSize = true;
            this.Coteret.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coteret.Location = new System.Drawing.Point(407, 38);
            this.Coteret.Name = "Coteret";
            this.Coteret.Size = new System.Drawing.Size(219, 29);
            this.Coteret.TabIndex = 2;
            this.Coteret.Text = "הוספת תרגיל למערכת";
            // 
            // exPreview
            // 
            this.exPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exPreview.Location = new System.Drawing.Point(516, 237);
            this.exPreview.Name = "exPreview";
            this.exPreview.Size = new System.Drawing.Size(481, 242);
            this.exPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exPreview.TabIndex = 14;
            this.exPreview.TabStop = false;
            // 
            // BrowseFolder
            // 
            this.BrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFolder.Location = new System.Drawing.Point(880, 484);
            this.BrowseFolder.Name = "BrowseFolder";
            this.BrowseFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BrowseFolder.Size = new System.Drawing.Size(117, 34);
            this.BrowseFolder.TabIndex = 15;
            this.BrowseFolder.Text = "בחר קובץ...";
            this.BrowseFolder.UseVisualStyleBackColor = true;
            this.BrowseFolder.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // AddExButton
            // 
            this.AddExButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExButton.Location = new System.Drawing.Point(16, 534);
            this.AddExButton.Name = "AddExButton";
            this.AddExButton.Size = new System.Drawing.Size(133, 34);
            this.AddExButton.TabIndex = 16;
            this.AddExButton.Text = "הוסף תרגיל למערכת";
            this.AddExButton.UseVisualStyleBackColor = true;
            this.AddExButton.Click += new System.EventHandler(this.AddExButton_Click);
            // 
            // ExDifflabel
            // 
            this.ExDifflabel.AutoSize = true;
            this.ExDifflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExDifflabel.Location = new System.Drawing.Point(911, 156);
            this.ExDifflabel.Name = "ExDifflabel";
            this.ExDifflabel.Size = new System.Drawing.Size(86, 24);
            this.ExDifflabel.TabIndex = 17;
            this.ExDifflabel.Text = ":רמת קושי";
            // 
            // DiffList
            // 
            this.DiffList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiffList.FormattingEnabled = true;
            this.DiffList.Location = new System.Drawing.Point(719, 161);
            this.DiffList.Name = "DiffList";
            this.DiffList.Size = new System.Drawing.Size(153, 21);
            this.DiffList.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(376, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = ":תשובות סופיות";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(916, 524);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(81, 44);
            this.GoBackButton.TabIndex = 21;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // BrowseFolderFinalAns
            // 
            this.BrowseFolderFinalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFolderFinalAns.Location = new System.Drawing.Point(380, 484);
            this.BrowseFolderFinalAns.Name = "BrowseFolderFinalAns";
            this.BrowseFolderFinalAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BrowseFolderFinalAns.Size = new System.Drawing.Size(117, 34);
            this.BrowseFolderFinalAns.TabIndex = 23;
            this.BrowseFolderFinalAns.Text = "בחר קובץ...";
            this.BrowseFolderFinalAns.UseVisualStyleBackColor = true;
            this.BrowseFolderFinalAns.Click += new System.EventHandler(this.BrowseFolderFinalAns_Click);
            // 
            // FinalAns
            // 
            this.FinalAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalAns.Location = new System.Drawing.Point(16, 236);
            this.FinalAns.Name = "FinalAns";
            this.FinalAns.Size = new System.Drawing.Size(481, 242);
            this.FinalAns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FinalAns.TabIndex = 22;
            this.FinalAns.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(940, 195);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "תרגיל:";
            // 
            // AddExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowseFolderFinalAns);
            this.Controls.Add(this.FinalAns);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiffList);
            this.Controls.Add(this.ExDifflabel);
            this.Controls.Add(this.AddExButton);
            this.Controls.Add(this.BrowseFolder);
            this.Controls.Add(this.exPreview);
            this.Controls.Add(this.Coteret);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.ExSubLabel);
            this.Name = "AddExForm";
            this.Text = "AddExForm";
            this.Load += new System.EventHandler(this.AddExForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExSubLabel;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label Coteret;
        private System.Windows.Forms.PictureBox exPreview;
        private System.Windows.Forms.Button BrowseFolder;
        private System.Windows.Forms.Button AddExButton;
        private System.Windows.Forms.Label ExDifflabel;
        private System.Windows.Forms.ComboBox DiffList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button BrowseFolderFinalAns;
        private System.Windows.Forms.PictureBox FinalAns;
        private System.Windows.Forms.Label label2;
    }
}