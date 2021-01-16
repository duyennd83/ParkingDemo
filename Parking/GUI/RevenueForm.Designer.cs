namespace GUI
{
    partial class RevenueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYear = new System.Windows.Forms.Button();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtgRevenue = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnRe = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu ngày tháng năm";
            // 
            // dtpDay
            // 
            this.dtpDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay.Location = new System.Drawing.Point(3, 3);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(158, 34);
            this.dtpDay.TabIndex = 1;
            this.dtpDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDay);
            this.panel1.Controls.Add(this.dtpDay);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 85);
            this.panel1.TabIndex = 2;
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.Location = new System.Drawing.Point(3, 43);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(158, 41);
            this.btnDay.TabIndex = 2;
            this.btnDay.Text = "Ngày";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(395, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 110);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnYear);
            this.panel4.Controls.Add(this.dtpYear);
            this.panel4.Location = new System.Drawing.Point(377, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 85);
            this.panel4.TabIndex = 4;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.Location = new System.Drawing.Point(3, 43);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(158, 41);
            this.btnYear.TabIndex = 2;
            this.btnYear.Text = "Năm";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // dtpYear
            // 
            this.dtpYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYear.Location = new System.Drawing.Point(3, 3);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(158, 34);
            this.dtpYear.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMonth);
            this.panel3.Controls.Add(this.dtpMonth);
            this.panel3.Location = new System.Drawing.Point(197, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 85);
            this.panel3.TabIndex = 3;
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.Location = new System.Drawing.Point(3, 43);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(158, 41);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = "Tháng";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMonth.Location = new System.Drawing.Point(3, 3);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(158, 34);
            this.dtpMonth.TabIndex = 1;
            // 
            // dtgRevenue
            // 
            this.dtgRevenue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtgRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRevenue.Location = new System.Drawing.Point(12, 235);
            this.dtgRevenue.Name = "dtgRevenue";
            this.dtgRevenue.RowHeadersWidth = 51;
            this.dtgRevenue.RowTemplate.Height = 24;
            this.dtgRevenue.Size = new System.Drawing.Size(930, 244);
            this.dtgRevenue.TabIndex = 4;
            this.dtgRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRevenue_CellContentClick);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(395, 137);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(167, 34);
            this.dtpFrom.TabIndex = 12;
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRe.Location = new System.Drawing.Point(595, 137);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(158, 36);
            this.btnRe.TabIndex = 13;
            this.btnRe.Text = "Thống Kê";
            this.btnRe.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(772, 137);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(164, 34);
            this.dtpTo.TabIndex = 14;
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(954, 500);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtgRevenue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DataGridView dtgRevenue;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}