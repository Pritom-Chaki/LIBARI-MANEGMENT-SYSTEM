namespace LIBARI_MANEGMENT_SYSTEM.UIL
{
    partial class BookCatagoryUI
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
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.cIDTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.cNameLabel = new System.Windows.Forms.Label();
            this.cIDLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.bookCatagoryDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCatagoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(278, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 23);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 30);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.cancelButton);
            this.buttonGroupBox.Controls.Add(this.backButton);
            this.buttonGroupBox.Controls.Add(this.saveButton);
            this.buttonGroupBox.Controls.Add(this.updateButton);
            this.buttonGroupBox.Controls.Add(this.deleteButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(12, 169);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(349, 80);
            this.buttonGroupBox.TabIndex = 1;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "CLICK";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.cNameTextBox);
            this.infoGroupBox.Controls.Add(this.detailsTextBox);
            this.infoGroupBox.Controls.Add(this.cIDTextBox);
            this.infoGroupBox.Controls.Add(this.detailsLabel);
            this.infoGroupBox.Controls.Add(this.cNameLabel);
            this.infoGroupBox.Controls.Add(this.cIDLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 29);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(349, 134);
            this.infoGroupBox.TabIndex = 14;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "**";
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(99, 47);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.cNameTextBox.TabIndex = 11;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(99, 84);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(168, 20);
            this.detailsTextBox.TabIndex = 10;
            // 
            // cIDTextBox
            // 
            this.cIDTextBox.Location = new System.Drawing.Point(99, 15);
            this.cIDTextBox.Name = "cIDTextBox";
            this.cIDTextBox.Size = new System.Drawing.Size(168, 20);
            this.cIDTextBox.TabIndex = 7;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(17, 87);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(52, 13);
            this.detailsLabel.TabIndex = 4;
            this.detailsLabel.Text = "DETAILS";
            // 
            // cNameLabel
            // 
            this.cNameLabel.AutoSize = true;
            this.cNameLabel.Location = new System.Drawing.Point(-3, 47);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(100, 13);
            this.cNameLabel.TabIndex = 3;
            this.cNameLabel.Text = "CATAGORY NAME";
            // 
            // cIDLabel
            // 
            this.cIDLabel.AutoSize = true;
            this.cIDLabel.Location = new System.Drawing.Point(6, 18);
            this.cIDLabel.Name = "cIDLabel";
            this.cIDLabel.Size = new System.Drawing.Size(80, 13);
            this.cIDLabel.TabIndex = 2;
            this.cIDLabel.Text = "CATAGORY ID";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(209, 23);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(75, 23);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(60, 30);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(141, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.bookCatagoryDataGridView);
            this.dataGroupBox.Location = new System.Drawing.Point(407, 2);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(306, 295);
            this.dataGroupBox.TabIndex = 15;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "ALL DATA FROM TABLE";
            // 
            // bookCatagoryDataGridView
            // 
            this.bookCatagoryDataGridView.AllowUserToAddRows = false;
            this.bookCatagoryDataGridView.AllowUserToDeleteRows = false;
            this.bookCatagoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookCatagoryDataGridView.Location = new System.Drawing.Point(6, 17);
            this.bookCatagoryDataGridView.Name = "bookCatagoryDataGridView";
            this.bookCatagoryDataGridView.ReadOnly = true;
            this.bookCatagoryDataGridView.Size = new System.Drawing.Size(300, 278);
            this.bookCatagoryDataGridView.TabIndex = 0;
            this.bookCatagoryDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bookCatagoryDataGridView_DataBindingComplete);
            this.bookCatagoryDataGridView.SelectionChanged += new System.EventHandler(this.bookCatagoryDataGridView_SelectionChanged);
            // 
            // BookCatagoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 295);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.buttonGroupBox);
            this.Name = "BookCatagoryUI";
            this.Text = "BOOK CATAGORY";
            this.buttonGroupBox.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookCatagoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox cIDTextBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label cNameLabel;
        private System.Windows.Forms.Label cIDLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.DataGridView bookCatagoryDataGridView;
    }
}