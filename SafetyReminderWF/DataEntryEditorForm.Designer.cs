namespace SafetyReminderWF
{
    partial class DataEntryEditorForm
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
            labeFreq = new Label();
            numericUpDown1 = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAssess = new TextBox();
            labelAssess = new Label();
            labelCurrent = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelUpcoming = new Label();
            dateTimePicker2 = new DateTimePicker();
            labelFee = new Label();
            labelReminder = new Label();
            labelRemark = new Label();
            numericUpDown2 = new NumericUpDown();
            txtRemark = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // labeFreq
            // 
            labeFreq.AutoSize = true;
            labeFreq.Location = new Point(3, 64);
            labeFreq.Name = "labeFreq";
            labeFreq.Size = new Size(62, 15);
            labeFreq.TabIndex = 1;
            labeFreq.Text = "Frequency";
            labeFreq.Click += this.label2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(101, 67);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.2807016F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.7193F));
            tableLayoutPanel1.Controls.Add(labelAssess, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 1);
            tableLayoutPanel1.Controls.Add(txtAssess, 1, 0);
            tableLayoutPanel1.Controls.Add(labeFreq, 0, 1);
            tableLayoutPanel1.Controls.Add(labelCurrent, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(labelUpcoming, 0, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 3);
            tableLayoutPanel1.Controls.Add(labelFee, 0, 4);
            tableLayoutPanel1.Controls.Add(labelReminder, 0, 5);
            tableLayoutPanel1.Controls.Add(labelRemark, 0, 6);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 4);
            tableLayoutPanel1.Controls.Add(txtRemark, 1, 6);
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853031F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881651F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += this.tableLayoutPanel1_Paint;
            // 
            // txtAssess
            // 
            txtAssess.Location = new Point(101, 3);
            txtAssess.Name = "txtAssess";
            txtAssess.Size = new Size(213, 23);
            txtAssess.TabIndex = 2;
            // 
            // labelAssess
            // 
            labelAssess.AutoSize = true;
            labelAssess.Dock = DockStyle.Fill;
            labelAssess.Location = new Point(3, 0);
            labelAssess.Name = "labelAssess";
            labelAssess.Size = new Size(92, 64);
            labelAssess.TabIndex = 0;
            labelAssess.Text = "Assessment";
            labelAssess.Click += this.label1_Click;
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(3, 128);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(74, 15);
            labelCurrent.TabIndex = 5;
            labelCurrent.Text = "Current Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(101, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // labelUpcoming
            // 
            labelUpcoming.AutoSize = true;
            labelUpcoming.Location = new Point(3, 192);
            labelUpcoming.Name = "labelUpcoming";
            labelUpcoming.Size = new Size(90, 15);
            labelUpcoming.TabIndex = 7;
            labelUpcoming.Text = "Upcoming Date";
            labelUpcoming.Click += this.label1_Click_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Location = new Point(101, 195);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += this.dateTimePicker2_ValueChanged;
            // 
            // labelFee
            // 
            labelFee.AutoSize = true;
            labelFee.Location = new Point(3, 256);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(25, 15);
            labelFee.TabIndex = 9;
            labelFee.Text = "Fee";
            labelFee.Click += this.label1_Click_2;
            // 
            // labelReminder
            // 
            labelReminder.AutoSize = true;
            labelReminder.Location = new Point(3, 320);
            labelReminder.Name = "labelReminder";
            labelReminder.Size = new Size(58, 30);
            labelReminder.TabIndex = 10;
            labelReminder.Text = "Check Reminder";
            labelReminder.Click += this.label1_Click_3;
            // 
            // labelRemark
            // 
            labelRemark.AutoSize = true;
            labelRemark.Location = new Point(3, 384);
            labelRemark.Name = "labelRemark";
            labelRemark.Size = new Size(47, 15);
            labelRemark.TabIndex = 12;
            labelRemark.Text = "Remark";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(101, 259);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 13;
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(101, 387);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(213, 23);
            txtRemark.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(101, 323);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Reminder Sent";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // DataEntryEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DataEntryEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            UseWaitCursor = true;
            Load += this.DataEntryEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labeFreq;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelAssess;
        private TextBox txtAssess;
        private Label labelCurrent;
        private DateTimePicker dateTimePicker1;
        private Label labelUpcoming;
        private DateTimePicker dateTimePicker2;
        private Label labelFee;
        private Label labelReminder;
        private Label labelRemark;
        private NumericUpDown numericUpDown2;
        private TextBox txtRemark;
        private CheckBox checkBox1;
    }
}