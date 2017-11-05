namespace LIBARI_MANEGMENT_SYSTEM
{
    partial class Add_Members
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
            this.addButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.mIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contctNoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(362, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 37);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // mIDLabel
            // 
            this.mIDLabel.AutoSize = true;
            this.mIDLabel.Location = new System.Drawing.Point(7, 15);
            this.mIDLabel.Name = "mIDLabel";
            this.mIDLabel.Size = new System.Drawing.Size(68, 13);
            this.mIDLabel.TabIndex = 2;
            this.mIDLabel.Text = "MEMBER ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "NAME";
            // 
            // contctNoLabel
            // 
            this.contctNoLabel.AutoSize = true;
            this.contctNoLabel.Location = new System.Drawing.Point(7, 87);
            this.contctNoLabel.Name = "contctNoLabel";
            this.contctNoLabel.Size = new System.Drawing.Size(77, 13);
            this.contctNoLabel.TabIndex = 4;
            this.contctNoLabel.Text = "CONTACT NO";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 127);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "EMAIL";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(16, 159);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(59, 13);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "ADDRESS";
            // 
            // mIDTextBox
            // 
            this.mIDTextBox.Location = new System.Drawing.Point(99, 15);
            this.mIDTextBox.Name = "mIDTextBox";
            this.mIDTextBox.Size = new System.Drawing.Size(168, 20);
            this.mIDTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(99, 156);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(99, 120);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(99, 84);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(168, 20);
            this.contactNoTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.cancelButton);
            this.buttonGroupBox.Controls.Add(this.updateButton);
            this.buttonGroupBox.Controls.Add(this.deleteButton);
            this.buttonGroupBox.Controls.Add(this.BackButton);
            this.buttonGroupBox.Controls.Add(this.addButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(12, 244);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(447, 73);
            this.buttonGroupBox.TabIndex = 12;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "CLICK";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(269, 18);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 37);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(99, 18);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 37);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(184, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 37);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.nameTextBox);
            this.infoGroupBox.Controls.Add(this.contactNoTextBox);
            this.infoGroupBox.Controls.Add(this.emailTextBox);
            this.infoGroupBox.Controls.Add(this.addressTextBox);
            this.infoGroupBox.Controls.Add(this.mIDTextBox);
            this.infoGroupBox.Controls.Add(this.addressLabel);
            this.infoGroupBox.Controls.Add(this.emailLabel);
            this.infoGroupBox.Controls.Add(this.contctNoLabel);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Controls.Add(this.mIDLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(103, 53);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(298, 185);
            this.infoGroupBox.TabIndex = 13;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "FILL THE FIELD";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.memberDataGridView);
            this.dataGroupBox.Location = new System.Drawing.Point(465, 12);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(584, 332);
            this.dataGroupBox.TabIndex = 14;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "ALL DATA FROM TABLE";
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Location = new System.Drawing.Point(6, 17);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.Size = new System.Drawing.Size(572, 315);
            this.memberDataGridView.TabIndex = 0;
            
            this.memberDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.memberDataGridView_DataBindingComplete);
            this.memberDataGridView.SelectionChanged += new System.EventHandler(this.memberDataGridView_SelectionChanged);
            // 
            // Add_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 339);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.buttonGroupBox);
            this.Name = "Add_Members";
            this.Text = "Add_Members";
            this.buttonGroupBox.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label mIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label contctNoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox mIDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.DataGridView memberDataGridView;
    }
}