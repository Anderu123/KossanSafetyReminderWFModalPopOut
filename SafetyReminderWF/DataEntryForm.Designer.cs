namespace SafetyReminderWF
{
    partial class DataEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryForm));
            ReminderGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            assessmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            frequencyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            upComingDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reminderSentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            remarkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            complianceBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)complianceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ReminderGridView
            // 
            ReminderGridView.AutoGenerateColumns = false;
            ReminderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReminderGridView.BackgroundColor = SystemColors.ActiveCaptionText;
            ReminderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReminderGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, assessmentDataGridViewTextBoxColumn, frequencyDataGridViewTextBoxColumn, currentDTDataGridViewTextBoxColumn, upComingDTDataGridViewTextBoxColumn, feeDataGridViewTextBoxColumn, reminderSentDataGridViewCheckBoxColumn, remarkDataGridViewTextBoxColumn });
            ReminderGridView.DataSource = complianceBindingSource;
            ReminderGridView.Dock = DockStyle.Fill;
            ReminderGridView.Location = new Point(0, 25);
            ReminderGridView.Name = "ReminderGridView";
            ReminderGridView.Size = new Size(800, 425);
            ReminderGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // assessmentDataGridViewTextBoxColumn
            // 
            assessmentDataGridViewTextBoxColumn.DataPropertyName = "Assessment";
            assessmentDataGridViewTextBoxColumn.HeaderText = "Assessment";
            assessmentDataGridViewTextBoxColumn.Name = "assessmentDataGridViewTextBoxColumn";
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            // 
            // currentDTDataGridViewTextBoxColumn
            // 
            currentDTDataGridViewTextBoxColumn.DataPropertyName = "CurrentDT";
            currentDTDataGridViewTextBoxColumn.HeaderText = "CurrentDT";
            currentDTDataGridViewTextBoxColumn.Name = "currentDTDataGridViewTextBoxColumn";
            // 
            // upComingDTDataGridViewTextBoxColumn
            // 
            upComingDTDataGridViewTextBoxColumn.DataPropertyName = "UpComingDT";
            upComingDTDataGridViewTextBoxColumn.HeaderText = "UpComingDT";
            upComingDTDataGridViewTextBoxColumn.Name = "upComingDTDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            feeDataGridViewTextBoxColumn.HeaderText = "fee";
            feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // reminderSentDataGridViewCheckBoxColumn
            // 
            reminderSentDataGridViewCheckBoxColumn.DataPropertyName = "ReminderSent";
            reminderSentDataGridViewCheckBoxColumn.HeaderText = "ReminderSent";
            reminderSentDataGridViewCheckBoxColumn.Name = "reminderSentDataGridViewCheckBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // complianceBindingSource
            // 
            complianceBindingSource.DataSource = typeof(Compliance);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.AutoToolTip = false;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.AutoToolTip = false;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.AutoToolTip = false;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // DataEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReminderGridView);
            Controls.Add(toolStrip1);
            Name = "DataEntryForm";
            Text = "DataEntryForm";
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)complianceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReminderGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn assessmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn upComingDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn reminderSentDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private BindingSource complianceBindingSource;
        private BindingSource bindingSource1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
