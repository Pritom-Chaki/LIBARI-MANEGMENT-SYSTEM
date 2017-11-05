namespace LIBARI_MANEGMENT_SYSTEM.UIL
{
    partial class IssueBookUI
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
            this.iIDLabel = new System.Windows.Forms.Label();
            this.mIDabel = new System.Windows.Forms.Label();
            this.discriptionLabel = new System.Windows.Forms.Label();
            this.bIDLabel = new System.Windows.Forms.Label();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.issueIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issueLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // iIDLabel
            // 
            this.iIDLabel.AutoSize = true;
            this.iIDLabel.Location = new System.Drawing.Point(26, 33);
            this.iIDLabel.Name = "iIDLabel";
            this.iIDLabel.Size = new System.Drawing.Size(53, 13);
            this.iIDLabel.TabIndex = 0;
            this.iIDLabel.Text = "ISSUE ID";
            // 
            // mIDabel
            // 
            this.mIDabel.AutoSize = true;
            this.mIDabel.Location = new System.Drawing.Point(26, 64);
            this.mIDabel.Name = "mIDabel";
            this.mIDabel.Size = new System.Drawing.Size(68, 13);
            this.mIDabel.TabIndex = 1;
            this.mIDabel.Text = "MEMBER ID";
            // 
            // discriptionLabel
            // 
            this.discriptionLabel.AutoSize = true;
            this.discriptionLabel.Location = new System.Drawing.Point(12, 132);
            this.discriptionLabel.Name = "discriptionLabel";
            this.discriptionLabel.Size = new System.Drawing.Size(76, 13);
            this.discriptionLabel.TabIndex = 2;
            this.discriptionLabel.Text = "DISCRIPTION";
            // 
            // bIDLabel
            // 
            this.bIDLabel.AutoSize = true;
            this.bIDLabel.Location = new System.Drawing.Point(28, 98);
            this.bIDLabel.Name = "bIDLabel";
            this.bIDLabel.Size = new System.Drawing.Size(51, 13);
            this.bIDLabel.TabIndex = 3;
            this.bIDLabel.Text = "BOOK ID";
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(33, 165);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(46, 13);
            this.copiesLabel.TabIndex = 4;
            this.copiesLabel.Text = "COPIES";
            // 
            // issueIDTextBox
            // 
            this.issueIDTextBox.Location = new System.Drawing.Point(110, 30);
            this.issueIDTextBox.Name = "issueIDTextBox";
            this.issueIDTextBox.Size = new System.Drawing.Size(159, 20);
            this.issueIDTextBox.TabIndex = 5;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(110, 61);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(159, 20);
            this.memberIDTextBox.TabIndex = 6;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(110, 95);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(159, 20);
            this.bookIDTextBox.TabIndex = 7;
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.Location = new System.Drawing.Point(110, 129);
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(159, 20);
            this.discriptionTextBox.TabIndex = 8;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(110, 162);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(159, 20);
            this.copiesTextBox.TabIndex = 9;
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.cancelButton);
            this.buttonGroupBox.Controls.Add(this.updateButton);
            this.buttonGroupBox.Controls.Add(this.deleteButton);
            this.buttonGroupBox.Controls.Add(this.backButton);
            this.buttonGroupBox.Controls.Add(this.saveButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(22, 252);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(436, 62);
            this.buttonGroupBox.TabIndex = 10;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "CLICK";
            this.buttonGroupBox.Enter += new System.EventHandler(this.buttonGroupBox_Enter);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(348, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // issueDateTimePicker
            // 
            this.issueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issueDateTimePicker.Location = new System.Drawing.Point(110, 200);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.issueDateTimePicker.TabIndex = 11;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDateTimePicker.Location = new System.Drawing.Point(110, 226);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.returnDateTimePicker.TabIndex = 12;
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(26, 200);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(71, 13);
            this.issueLabel.TabIndex = 13;
            this.issueLabel.Text = "ISSUE DATE";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Location = new System.Drawing.Point(19, 226);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(85, 13);
            this.returnLabel.TabIndex = 14;
            this.returnLabel.Text = "RETURN DATE";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 19);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 40);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(92, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 40);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(176, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 40);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Location = new System.Drawing.Point(0, 17);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.Size = new System.Drawing.Size(515, 219);
            this.memberDataGridView.TabIndex = 0;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.memberDataGridView);
            this.dataGroupBox.Location = new System.Drawing.Point(310, 4);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(527, 242);
            this.dataGroupBox.TabIndex = 15;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "ALL DATA FROM TABLE";
            // 
            // IssueBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 348);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.issueLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.issueIDTextBox);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.bIDLabel);
            this.Controls.Add(this.discriptionLabel);
            this.Controls.Add(this.mIDabel);
            this.Controls.Add(this.iIDLabel);
            this.Name = "IssueBookUI";
            this.Text = "Fiil The Gap";
            this.buttonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.dataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iIDLabel;
        private System.Windows.Forms.Label mIDabel;
        private System.Windows.Forms.Label discriptionLabel;
        private System.Windows.Forms.Label bIDLabel;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.TextBox issueIDTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker issueDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.GroupBox dataGroupBox;
    }
}