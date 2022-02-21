namespace CinemaSalesApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.GroupTickets = new System.Windows.Forms.GroupBox();
            this.Txtchild = new System.Windows.Forms.TextBox();
            this.Txtstudent = new System.Windows.Forms.TextBox();
            this.Txtadult = new System.Windows.Forms.TextBox();
            this.LblChild = new System.Windows.Forms.Label();
            this.LblStudent = new System.Windows.Forms.Label();
            this.LblAdult = new System.Windows.Forms.Label();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Summary = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.GroupSummary = new System.Windows.Forms.GroupBox();
            this.Lblavgvalue = new System.Windows.Forms.Label();
            this.Lbltreceipt = new System.Windows.Forms.Label();
            this.Lbltsold = new System.Windows.Forms.Label();
            this.Lblctotal = new System.Windows.Forms.Label();
            this.Lblcname = new System.Windows.Forms.Label();
            this.Lblcashname = new System.Windows.Forms.Label();
            this.LblTransValue = new System.Windows.Forms.Label();
            this.LblReceipts = new System.Windows.Forms.Label();
            this.LblSold = new System.Windows.Forms.Label();
            this.Lblcashiers = new System.Windows.Forms.Label();
            this.PictureTop = new System.Windows.Forms.PictureBox();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBottom = new System.Windows.Forms.PictureBox();
            this.GroupTickets.SuspendLayout();
            this.GroupSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTop)).BeginInit();
            this.PanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Enter.ForeColor = System.Drawing.Color.White;
            this.Btn_Enter.Location = new System.Drawing.Point(297, 279);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(188, 63);
            this.Btn_Enter.TabIndex = 1;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Visible = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(81, 113);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(234, 37);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Cashier Name";
            // 
            // Txtname
            // 
            this.Txtname.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtname.Location = new System.Drawing.Point(382, 113);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(339, 46);
            this.Txtname.TabIndex = 4;
            this.Txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupTickets
            // 
            this.GroupTickets.Controls.Add(this.Txtchild);
            this.GroupTickets.Controls.Add(this.Txtstudent);
            this.GroupTickets.Controls.Add(this.Txtadult);
            this.GroupTickets.Controls.Add(this.LblChild);
            this.GroupTickets.Controls.Add(this.LblStudent);
            this.GroupTickets.Controls.Add(this.LblAdult);
            this.GroupTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTickets.Location = new System.Drawing.Point(68, 248);
            this.GroupTickets.Name = "GroupTickets";
            this.GroupTickets.Size = new System.Drawing.Size(653, 263);
            this.GroupTickets.TabIndex = 5;
            this.GroupTickets.TabStop = false;
            this.GroupTickets.Text = "Tickets";
            // 
            // Txtchild
            // 
            this.Txtchild.Location = new System.Drawing.Point(336, 188);
            this.Txtchild.Name = "Txtchild";
            this.Txtchild.Size = new System.Drawing.Size(113, 40);
            this.Txtchild.TabIndex = 5;
            this.Txtchild.Text = "0";
            this.Txtchild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtstudent
            // 
            this.Txtstudent.Location = new System.Drawing.Point(336, 132);
            this.Txtstudent.Name = "Txtstudent";
            this.Txtstudent.Size = new System.Drawing.Size(113, 40);
            this.Txtstudent.TabIndex = 4;
            this.Txtstudent.Text = "0";
            this.Txtstudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtadult
            // 
            this.Txtadult.Location = new System.Drawing.Point(336, 74);
            this.Txtadult.Name = "Txtadult";
            this.Txtadult.Size = new System.Drawing.Size(113, 40);
            this.Txtadult.TabIndex = 3;
            this.Txtadult.Text = "0";
            this.Txtadult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblChild
            // 
            this.LblChild.AutoSize = true;
            this.LblChild.Location = new System.Drawing.Point(139, 188);
            this.LblChild.Name = "LblChild";
            this.LblChild.Size = new System.Drawing.Size(87, 33);
            this.LblChild.TabIndex = 2;
            this.LblChild.Text = "Child";
            // 
            // LblStudent
            // 
            this.LblStudent.AutoSize = true;
            this.LblStudent.Location = new System.Drawing.Point(139, 135);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(121, 33);
            this.LblStudent.TabIndex = 1;
            this.LblStudent.Text = "Student";
            // 
            // LblAdult
            // 
            this.LblAdult.AutoSize = true;
            this.LblAdult.Location = new System.Drawing.Point(139, 81);
            this.LblAdult.Name = "LblAdult";
            this.LblAdult.Size = new System.Drawing.Size(86, 33);
            this.LblAdult.TabIndex = 0;
            this.LblAdult.Text = "Adult";
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Calc.Location = new System.Drawing.Point(22, 12);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(140, 70);
            this.Btn_Calc.TabIndex = 6;
            this.Btn_Calc.Text = "Calculate";
            this.toolTip1.SetToolTip(this.Btn_Calc, "Press for the total calculation");
            this.Btn_Calc.UseVisualStyleBackColor = false;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Clear.Location = new System.Drawing.Point(200, 12);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(142, 70);
            this.Btn_Clear.TabIndex = 7;
            this.Btn_Clear.Text = "Clear";
            this.toolTip1.SetToolTip(this.Btn_Clear, "Press to clear the data");
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Summary
            // 
            this.Btn_Summary.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Summary.Location = new System.Drawing.Point(384, 12);
            this.Btn_Summary.Name = "Btn_Summary";
            this.Btn_Summary.Size = new System.Drawing.Size(140, 70);
            this.Btn_Summary.TabIndex = 8;
            this.Btn_Summary.Text = "Summary";
            this.toolTip1.SetToolTip(this.Btn_Summary, "Press for the summary details");
            this.Btn_Summary.UseVisualStyleBackColor = false;
            this.Btn_Summary.Click += new System.EventHandler(this.Btn_Summary_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Exit.Location = new System.Drawing.Point(567, 12);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(139, 70);
            this.Btn_Exit.TabIndex = 9;
            this.Btn_Exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.Btn_Exit, "Press to exit application");
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // GroupSummary
            // 
            this.GroupSummary.Controls.Add(this.Lblavgvalue);
            this.GroupSummary.Controls.Add(this.Lbltreceipt);
            this.GroupSummary.Controls.Add(this.Lbltsold);
            this.GroupSummary.Controls.Add(this.Lblctotal);
            this.GroupSummary.Controls.Add(this.Lblcname);
            this.GroupSummary.Controls.Add(this.Lblcashname);
            this.GroupSummary.Controls.Add(this.LblTransValue);
            this.GroupSummary.Controls.Add(this.LblReceipts);
            this.GroupSummary.Controls.Add(this.LblSold);
            this.GroupSummary.Controls.Add(this.Lblcashiers);
            this.GroupSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSummary.Location = new System.Drawing.Point(68, 740);
            this.GroupSummary.Name = "GroupSummary";
            this.GroupSummary.Size = new System.Drawing.Size(653, 310);
            this.GroupSummary.TabIndex = 13;
            this.GroupSummary.TabStop = false;
            this.GroupSummary.Text = "Cashier Summary Data";
            this.GroupSummary.Visible = false;
            // 
            // Lblavgvalue
            // 
            this.Lblavgvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblavgvalue.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblavgvalue.Location = new System.Drawing.Point(370, 248);
            this.Lblavgvalue.Name = "Lblavgvalue";
            this.Lblavgvalue.Size = new System.Drawing.Size(255, 44);
            this.Lblavgvalue.TabIndex = 23;
            this.Lblavgvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbltreceipt
            // 
            this.Lbltreceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbltreceipt.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltreceipt.Location = new System.Drawing.Point(370, 188);
            this.Lbltreceipt.Name = "Lbltreceipt";
            this.Lbltreceipt.Size = new System.Drawing.Size(255, 42);
            this.Lbltreceipt.TabIndex = 22;
            this.Lbltreceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbltsold
            // 
            this.Lbltsold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbltsold.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltsold.Location = new System.Drawing.Point(370, 130);
            this.Lbltsold.Name = "Lbltsold";
            this.Lbltsold.Size = new System.Drawing.Size(255, 42);
            this.Lbltsold.TabIndex = 21;
            this.Lbltsold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblctotal
            // 
            this.Lblctotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblctotal.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblctotal.Location = new System.Drawing.Point(370, 61);
            this.Lblctotal.Name = "Lblctotal";
            this.Lblctotal.Size = new System.Drawing.Size(255, 41);
            this.Lblctotal.TabIndex = 20;
            this.Lblctotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblcname
            // 
            this.Lblcname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblcname.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcname.Location = new System.Drawing.Point(370, 61);
            this.Lblcname.Name = "Lblcname";
            this.Lblcname.Size = new System.Drawing.Size(255, 41);
            this.Lblcname.TabIndex = 19;
            this.Lblcname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblcashname
            // 
            this.Lblcashname.AutoSize = true;
            this.Lblcashname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcashname.Location = new System.Drawing.Point(58, 74);
            this.Lblcashname.Name = "Lblcashname";
            this.Lblcashname.Size = new System.Drawing.Size(207, 31);
            this.Lblcashname.TabIndex = 8;
            this.Lblcashname.Text = "Cashier Name ";
            // 
            // LblTransValue
            // 
            this.LblTransValue.AutoSize = true;
            this.LblTransValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTransValue.Location = new System.Drawing.Point(58, 249);
            this.LblTransValue.Name = "LblTransValue";
            this.LblTransValue.Size = new System.Drawing.Size(229, 31);
            this.LblTransValue.TabIndex = 7;
            this.LblTransValue.Text = "Avg Trans Value";
            // 
            // LblReceipts
            // 
            this.LblReceipts.AutoSize = true;
            this.LblReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReceipts.Location = new System.Drawing.Point(58, 188);
            this.LblReceipts.Name = "LblReceipts";
            this.LblReceipts.Size = new System.Drawing.Size(203, 31);
            this.LblReceipts.TabIndex = 2;
            this.LblReceipts.Text = "Total Receipts";
            // 
            // LblSold
            // 
            this.LblSold.AutoSize = true;
            this.LblSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSold.Location = new System.Drawing.Point(58, 131);
            this.LblSold.Name = "LblSold";
            this.LblSold.Size = new System.Drawing.Size(249, 31);
            this.LblSold.TabIndex = 1;
            this.LblSold.Text = "Total Tickets Sold";
            // 
            // Lblcashiers
            // 
            this.Lblcashiers.AutoSize = true;
            this.Lblcashiers.Location = new System.Drawing.Point(58, 71);
            this.Lblcashiers.Name = "Lblcashiers";
            this.Lblcashiers.Size = new System.Drawing.Size(165, 25);
            this.Lblcashiers.TabIndex = 0;
            this.Lblcashiers.Text = "Total Cashiers";
            // 
            // PictureTop
            // 
            this.PictureTop.Image = ((System.Drawing.Image)(resources.GetObject("PictureTop.Image")));
            this.PictureTop.Location = new System.Drawing.Point(13, 12);
            this.PictureTop.Name = "PictureTop";
            this.PictureTop.Size = new System.Drawing.Size(804, 173);
            this.PictureTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureTop.TabIndex = 16;
            this.PictureTop.TabStop = false;
            this.PictureTop.Visible = false;
            // 
            // PanelButton
            // 
            this.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButton.Controls.Add(this.Btn_Calc);
            this.PanelButton.Controls.Add(this.Btn_Exit);
            this.PanelButton.Controls.Add(this.Btn_Clear);
            this.PanelButton.Controls.Add(this.Btn_Summary);
            this.PanelButton.ForeColor = System.Drawing.Color.White;
            this.PanelButton.Location = new System.Drawing.Point(32, 571);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(721, 100);
            this.PanelButton.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // PictureBottom
            // 
            this.PictureBottom.Image = ((System.Drawing.Image)(resources.GetObject("PictureBottom.Image")));
            this.PictureBottom.Location = new System.Drawing.Point(12, 1073);
            this.PictureBottom.Name = "PictureBottom";
            this.PictureBottom.Size = new System.Drawing.Size(804, 174);
            this.PictureBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBottom.TabIndex = 18;
            this.PictureBottom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 1259);
            this.Controls.Add(this.PictureBottom);
            this.Controls.Add(this.GroupTickets);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.GroupSummary);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.PictureTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome To Mega Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupTickets.ResumeLayout(false);
            this.GroupTickets.PerformLayout();
            this.GroupSummary.ResumeLayout(false);
            this.GroupSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTop)).EndInit();
            this.PanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.GroupBox GroupTickets;
        private System.Windows.Forms.Label LblChild;
        private System.Windows.Forms.Label LblStudent;
        private System.Windows.Forms.Label LblAdult;
        private System.Windows.Forms.TextBox Txtchild;
        private System.Windows.Forms.TextBox Txtstudent;
        private System.Windows.Forms.TextBox Txtadult;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Summary;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.GroupBox GroupSummary;
        private System.Windows.Forms.Label LblReceipts;
        private System.Windows.Forms.Label LblSold;
        private System.Windows.Forms.Label Lblcashiers;
        private System.Windows.Forms.Label LblTransValue;
        private System.Windows.Forms.PictureBox PictureTop;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Label Lblcashname;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PictureBottom;
        private System.Windows.Forms.Label Lblcname;
        private System.Windows.Forms.Label Lblctotal;
        private System.Windows.Forms.Label Lbltsold;
        private System.Windows.Forms.Label Lbltreceipt;
        private System.Windows.Forms.Label Lblavgvalue;
    }
}

