
namespace Lab8
{
    partial class DateForm
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
            this.monthBtn = new System.Windows.Forms.Button();
            this.dayBtn = new System.Windows.Forms.Button();
            this.yearBtn = new System.Windows.Forms.Button();
            this.inputMonth = new System.Windows.Forms.TextBox();
            this.inputDay = new System.Windows.Forms.TextBox();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.monthLbl = new System.Windows.Forms.Label();
            this.dayLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthBtn
            // 
            this.monthBtn.Location = new System.Drawing.Point(310, 99);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(135, 33);
            this.monthBtn.TabIndex = 0;
            this.monthBtn.Text = "Update Month";
            this.monthBtn.UseVisualStyleBackColor = true;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.Location = new System.Drawing.Point(310, 157);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(135, 33);
            this.dayBtn.TabIndex = 1;
            this.dayBtn.Text = "Update Day";
            this.dayBtn.UseVisualStyleBackColor = true;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // yearBtn
            // 
            this.yearBtn.Location = new System.Drawing.Point(310, 215);
            this.yearBtn.Name = "yearBtn";
            this.yearBtn.Size = new System.Drawing.Size(135, 33);
            this.yearBtn.TabIndex = 2;
            this.yearBtn.Text = "Update Year";
            this.yearBtn.UseVisualStyleBackColor = true;
            this.yearBtn.Click += new System.EventHandler(this.yearBtn_Click);
            // 
            // inputMonth
            // 
            this.inputMonth.Location = new System.Drawing.Point(130, 102);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(150, 26);
            this.inputMonth.TabIndex = 3;
            // 
            // inputDay
            // 
            this.inputDay.Location = new System.Drawing.Point(130, 160);
            this.inputDay.Name = "inputDay";
            this.inputDay.Size = new System.Drawing.Size(150, 26);
            this.inputDay.TabIndex = 4;
            // 
            // inputYear
            // 
            this.inputYear.Location = new System.Drawing.Point(130, 218);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(150, 26);
            this.inputYear.TabIndex = 5;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Location = new System.Drawing.Point(44, 105);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(58, 20);
            this.monthLbl.TabIndex = 6;
            this.monthLbl.Text = "Month:";
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Location = new System.Drawing.Point(61, 163);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(41, 20);
            this.dayLbl.TabIndex = 7;
            this.dayLbl.Text = "Day:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(55, 221);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(47, 20);
            this.yearLbl.TabIndex = 8;
            this.yearLbl.Text = "Year:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(137, 44);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(48, 20);
            this.dateLbl.TabIndex = 9;
            this.dateLbl.Text = "Date:";
            // 
            // dateOutputLbl
            // 
            this.dateOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLbl.Location = new System.Drawing.Point(217, 43);
            this.dateOutputLbl.Name = "dateOutputLbl";
            this.dateOutputLbl.Size = new System.Drawing.Size(150, 26);
            this.dateOutputLbl.TabIndex = 10;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 343);
            this.Controls.Add(this.dateOutputLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.inputDay);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.yearBtn);
            this.Controls.Add(this.dayBtn);
            this.Controls.Add(this.monthBtn);
            this.Name = "DateForm";
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.Button yearBtn;
        private System.Windows.Forms.TextBox inputMonth;
        private System.Windows.Forms.TextBox inputDay;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label dateOutputLbl;
    }
}

