using System.Drawing;
using System.Windows.Forms;


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
            labelAssess = new Label();
            txtAssess = new TextBox();
            labelCurrent = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelUpcoming = new Label();
            dateTimePicker2 = new DateTimePicker();
            labelFee = new Label();
            labelReminder = new Label();
            labelRemark = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            OKButton = new Button();
            CancelButton = new Button();
            txtRemark = new TextBox();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // labeFreq
            // 
            labeFreq.AutoSize = true;
            labeFreq.Location = new Point(4, 57);
            labeFreq.Name = "labeFreq";
            labeFreq.Size = new Size(62, 15);
            labeFreq.TabIndex = 1;
            labeFreq.Text = "Frequency";
            labeFreq.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(96, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
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
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(panel1, 3, 6);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 4);
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
            tableLayoutPanel1.Size = new Size(747, 394);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // labelAssess
            // 
            labelAssess.AutoSize = true;
            labelAssess.Dock = DockStyle.Fill;
            labelAssess.Location = new Point(4, 1);
            labelAssess.Name = "labelAssess";
            labelAssess.Size = new Size(85, 55);
            labelAssess.TabIndex = 0;
            labelAssess.Text = "Assessment";
            labelAssess.UseWaitCursor = true;
            // 
            // txtAssess
            // 
            txtAssess.Location = new Point(96, 4);
            txtAssess.Name = "txtAssess";
            txtAssess.Size = new Size(213, 23);
            txtAssess.TabIndex = 2;
            txtAssess.UseWaitCursor = true;
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(4, 113);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(74, 15);
            labelCurrent.TabIndex = 5;
            labelCurrent.Text = "Current Date";
            labelCurrent.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(96, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // labelUpcoming
            // 
            labelUpcoming.AutoSize = true;
            labelUpcoming.Location = new Point(4, 169);
            labelUpcoming.Name = "labelUpcoming";
            labelUpcoming.Size = new Size(66, 30);
            labelUpcoming.TabIndex = 7;
            labelUpcoming.Text = "Upcoming Date";
            labelUpcoming.UseWaitCursor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Location = new Point(96, 172);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // labelFee
            // 
            labelFee.AutoSize = true;
            labelFee.Location = new Point(4, 225);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(25, 15);
            labelFee.TabIndex = 9;
            labelFee.Text = "Fee";
            labelFee.UseWaitCursor = true;
            // 
            // labelReminder
            // 
            labelReminder.AutoSize = true;
            labelReminder.Location = new Point(4, 281);
            labelReminder.Name = "labelReminder";
            labelReminder.Size = new Size(58, 30);
            labelReminder.TabIndex = 10;
            labelReminder.Text = "Check Reminder";
            labelReminder.UseWaitCursor = true;
            // 
            // labelRemark
            // 
            labelRemark.AutoSize = true;
            labelRemark.Location = new Point(4, 337);
            labelRemark.Name = "labelRemark";
            labelRemark.Size = new Size(47, 15);
            labelRemark.TabIndex = 12;
            labelRemark.Text = "Remark";
            labelRemark.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(96, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Reminder Sent";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(OKButton);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(txtRemark);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(96, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 50);
            panel1.TabIndex = 16;
            panel1.UseWaitCursor = true;
            // 
            // OKButton
            // 
            OKButton.Dock = DockStyle.Right;
            OKButton.Location = new Point(497, 0);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 50);
            OKButton.TabIndex = 15;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.UseWaitCursor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AccessibleRole = AccessibleRole.None;
            CancelButton.Dock = DockStyle.Right;
            CancelButton.ImageAlign = ContentAlignment.MiddleRight;
            CancelButton.Location = new Point(572, 0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 50);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.UseWaitCursor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(3, 3);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(213, 23);
            txtRemark.TabIndex = 14;
            txtRemark.UseWaitCursor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(96, 228);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.UseWaitCursor = true;
            // 
            // DataEntryEditorForm
            // 
            AcceptButton = OKButton;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button CancelButton;
        private Panel panel1;
        private Button OKButton;
    }
}