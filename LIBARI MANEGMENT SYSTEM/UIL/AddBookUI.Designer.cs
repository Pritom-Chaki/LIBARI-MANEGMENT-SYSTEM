namespace LIBARI_MANEGMENT_SYSTEM.UIL
{
    partial class AddBookUI
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
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.arthorTextBox = new System.Windows.Forms.TextBox();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.cIDTextBox = new System.Windows.Forms.TextBox();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.bIDTextBox = new System.Windows.Forms.TextBox();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.arthorLabel = new System.Windows.Forms.Label();
            this.editionLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.CIDLabel = new System.Windows.Forms.Label();
            this.titelLabel = new System.Windows.Forms.Label();
            this.bIDLabel = new System.Windows.Forms.Label();
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.bookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.cancelButton);
            this.buttonGroupBox.Controls.Add(this.updateButton);
            this.buttonGroupBox.Controls.Add(this.deleteButton);
            this.buttonGroupBox.Controls.Add(this.backButton);
            this.buttonGroupBox.Controls.Add(this.saveButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(29, 227);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(502, 80);
            this.buttonGroupBox.TabIndex = 0;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "CLICK";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(298, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 40);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(105, 20);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 40);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(203, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 40);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(393, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(8, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.copiesTextBox);
            this.infoGroupBox.Controls.Add(this.arthorTextBox);
            this.infoGroupBox.Controls.Add(this.editionTextBox);
            this.infoGroupBox.Controls.Add(this.isbnTextBox);
            this.infoGroupBox.Controls.Add(this.cIDTextBox);
            this.infoGroupBox.Controls.Add(this.titelTextBox);
            this.infoGroupBox.Controls.Add(this.publisherTextBox);
            this.infoGroupBox.Controls.Add(this.bIDTextBox);
            this.infoGroupBox.Controls.Add(this.copiesLabel);
            this.infoGroupBox.Controls.Add(this.arthorLabel);
            this.infoGroupBox.Controls.Add(this.editionLabel);
            this.infoGroupBox.Controls.Add(this.publisherLabel);
            this.infoGroupBox.Controls.Add(this.ISBNLabel);
            this.infoGroupBox.Controls.Add(this.CIDLabel);
            this.infoGroupBox.Controls.Add(this.titelLabel);
            this.infoGroupBox.Controls.Add(this.bIDLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(29, 11);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(502, 210);
            this.infoGroupBox.TabIndex = 1;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "FILL";
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(329, 149);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(144, 20);
            this.copiesTextBox.TabIndex = 15;
            // 
            // arthorTextBox
            // 
            this.arthorTextBox.Location = new System.Drawing.Point(329, 108);
            this.arthorTextBox.Name = "arthorTextBox";
            this.arthorTextBox.Size = new System.Drawing.Size(144, 20);
            this.arthorTextBox.TabIndex = 14;
            // 
            // editionTextBox
            // 
            this.editionTextBox.Location = new System.Drawing.Point(329, 67);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(144, 20);
            this.editionTextBox.TabIndex = 13;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(87, 149);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(144, 20);
            this.isbnTextBox.TabIndex = 12;
            // 
            // cIDTextBox
            // 
            this.cIDTextBox.Location = new System.Drawing.Point(87, 108);
            this.cIDTextBox.Name = "cIDTextBox";
            this.cIDTextBox.Size = new System.Drawing.Size(144, 20);
            this.cIDTextBox.TabIndex = 11;
            // 
            // titelTextBox
            // 
            this.titelTextBox.Location = new System.Drawing.Point(87, 67);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(144, 20);
            this.titelTextBox.TabIndex = 10;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(329, 20);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(144, 20);
            this.publisherTextBox.TabIndex = 9;
            // 
            // bIDTextBox
            // 
            this.bIDTextBox.Location = new System.Drawing.Point(87, 20);
            this.bIDTextBox.Name = "bIDTextBox";
            this.bIDTextBox.Size = new System.Drawing.Size(144, 20);
            this.bIDTextBox.TabIndex = 8;
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(271, 152);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(46, 13);
            this.copiesLabel.TabIndex = 7;
            this.copiesLabel.Text = "COPIES";
            // 
            // arthorLabel
            // 
            this.arthorLabel.AutoSize = true;
            this.arthorLabel.Location = new System.Drawing.Point(271, 111);
            this.arthorLabel.Name = "arthorLabel";
            this.arthorLabel.Size = new System.Drawing.Size(53, 13);
            this.arthorLabel.TabIndex = 6;
            this.arthorLabel.Text = "ARTHOR";
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Location = new System.Drawing.Point(271, 70);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(51, 13);
            this.editionLabel.TabIndex = 5;
            this.editionLabel.Text = "EDITION";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(254, 23);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(68, 13);
            this.publisherLabel.TabIndex = 4;
            this.publisherLabel.Text = "PUBLISHER";
            this.publisherLabel.Click += new System.EventHandler(this.publisherLabel_Click);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(30, 152);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(32, 13);
            this.ISBNLabel.TabIndex = 3;
            this.ISBNLabel.Text = "ISBN";
            // 
            // CIDLabel
            // 
            this.CIDLabel.AutoSize = true;
            this.CIDLabel.Location = new System.Drawing.Point(32, 111);
            this.CIDLabel.Name = "CIDLabel";
            this.CIDLabel.Size = new System.Drawing.Size(25, 13);
            this.CIDLabel.TabIndex = 2;
            this.CIDLabel.Text = "CID";
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(25, 70);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(37, 13);
            this.titelLabel.TabIndex = 1;
            this.titelLabel.Text = "TITEL";
            // 
            // bIDLabel
            // 
            this.bIDLabel.AutoSize = true;
            this.bIDLabel.Location = new System.Drawing.Point(25, 23);
            this.bIDLabel.Name = "bIDLabel";
            this.bIDLabel.Size = new System.Drawing.Size(51, 13);
            this.bIDLabel.TabIndex = 0;
            this.bIDLabel.Text = "BOOK ID";
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.bookDataGridView);
            this.bookGroupBox.Location = new System.Drawing.Point(537, 4);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(560, 336);
            this.bookGroupBox.TabIndex = 2;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "ALL DATA FROM TABLE";
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Location = new System.Drawing.Point(12, 16);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.Size = new System.Drawing.Size(542, 320);
            this.bookDataGridView.TabIndex = 0;
            this.bookDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bookDataGridView_DataBindingComplete);
            this.bookDataGridView.SelectionChanged += new System.EventHandler(this.bookDataGridView_SelectionChanged);
            // 
            // AddBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 341);
            this.Controls.Add(this.bookGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.buttonGroupBox);
            this.Name = "AddBookUI";
            this.Text = "ADD BOOK";
            this.buttonGroupBox.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.bookGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.TextBox arthorTextBox;
        private System.Windows.Forms.TextBox editionTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox cIDTextBox;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox bIDTextBox;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.Label arthorLabel;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label CIDLabel;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label bIDLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox bookGroupBox;
        private System.Windows.Forms.DataGridView bookDataGridView;
    }
}