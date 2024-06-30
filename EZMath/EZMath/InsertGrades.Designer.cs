
namespace EZMath
{
    partial class InsertGrades
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
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.ExSubLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionList = new System.Windows.Forms.ComboBox();
            this.Students = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.examList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassList
            // 
            this.ClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(536, 116);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(140, 21);
            this.ClassList.TabIndex = 3;
            this.ClassList.SelectedIndexChanged += new System.EventHandler(this.SubjectList_SelectedIndexChanged);
            // 
            // ExSubLabel
            // 
            this.ExSubLabel.AutoSize = true;
            this.ExSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExSubLabel.Location = new System.Drawing.Point(714, 116);
            this.ExSubLabel.Name = "ExSubLabel";
            this.ExSubLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExSubLabel.Size = new System.Drawing.Size(54, 24);
            this.ExSubLabel.TabIndex = 2;
            this.ExSubLabel.Text = "כיתה:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.QuestionLabel.Location = new System.Drawing.Point(714, 218);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuestionLabel.Size = new System.Drawing.Size(60, 24);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "שאלה:";
            // 
            // QuestionList
            // 
            this.QuestionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(536, 218);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(140, 21);
            this.QuestionList.TabIndex = 5;
            this.QuestionList.SelectedIndexChanged += new System.EventHandler(this.QuestionList_SelectedIndexChanged);
            // 
            // Students
            // 
            this.Students.AllowUserToAddRows = false;
            this.Students.AllowUserToDeleteRows = false;
            this.Students.AllowUserToResizeColumns = false;
            this.Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Location = new System.Drawing.Point(2, 12);
            this.Students.Name = "Students";
            this.Students.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Students.Size = new System.Drawing.Size(476, 359);
            this.Students.TabIndex = 6;
            this.Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_CellClick);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(714, 394);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(74, 44);
            this.GoBackButton.TabIndex = 20;
            this.GoBackButton.Text = "חזור";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // examList
            // 
            this.examList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examList.FormattingEnabled = true;
            this.examList.Location = new System.Drawing.Point(536, 165);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(140, 21);
            this.examList.TabIndex = 22;
            this.examList.SelectedIndexChanged += new System.EventHandler(this.examList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(714, 165);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "מבחן:";
            // 
            // UpdateAll
            // 
            this.UpdateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateAll.Location = new System.Drawing.Point(156, 377);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(104, 34);
            this.UpdateAll.TabIndex = 23;
            this.UpdateAll.Text = "עדכן הכל";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(577, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "הזנת ציונים";
            // 
            // InsertGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateAll);
            this.Controls.Add(this.examList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.ExSubLabel);
            this.Name = "InsertGrades";
            this.Text = "InsertGrades";
            this.Load += new System.EventHandler(this.InsertGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassList;
        private System.Windows.Forms.Label ExSubLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.ComboBox QuestionList;
        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.ComboBox examList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateAll;
        private System.Windows.Forms.Label label2;
    }
}