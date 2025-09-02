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
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)complianceBindingSource).BeginInit();
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
            ReminderGridView.Location = new Point(0, 0);
            ReminderGridView.Name = "ReminderGridView";
            ReminderGridView.Size = new Size(800, 450);
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
            // DataEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReminderGridView);
            Name = "DataEntryForm";
            Text = "DataEntryForm";
            //Load += this.DataEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)complianceBindingSource).EndInit();
            ResumeLayout(false);
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
    }
}
