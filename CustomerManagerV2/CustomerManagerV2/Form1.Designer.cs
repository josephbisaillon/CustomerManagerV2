namespace CustomerManagerV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ServiceTextBox = new System.Windows.Forms.TextBox();
            this.ServiceCostTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Location = new System.Drawing.Point(245, 27);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(674, 269);
            this.MainGridView.TabIndex = 1;
            this.MainGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentRow);
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(10, 39);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(65, 13);
            this.custIDLabel.TabIndex = 3;
            this.custIDLabel.Text = "CustomerID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(26, 100);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(46, 13);
            this.serviceLabel.TabIndex = 5;
            this.serviceLabel.Text = "Service:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(2, 134);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(70, 13);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "Service Cost:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(13, 220);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(59, 13);
            this.commentLabel.TabIndex = 8;
            this.commentLabel.Text = "Comments:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(72, 36);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(165, 20);
            this.CustomerIDTextBox.TabIndex = 9;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(72, 67);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.CustomerNameTextBox.TabIndex = 10;
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.Location = new System.Drawing.Point(74, 97);
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.Size = new System.Drawing.Size(163, 20);
            this.ServiceTextBox.TabIndex = 11;
            // 
            // ServiceCostTextBox
            // 
            this.ServiceCostTextBox.Location = new System.Drawing.Point(74, 131);
            this.ServiceCostTextBox.Name = "ServiceCostTextBox";
            this.ServiceCostTextBox.Size = new System.Drawing.Size(163, 20);
            this.ServiceCostTextBox.TabIndex = 12;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(74, 189);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(165, 78);
            this.commentsTextBox.TabIndex = 14;
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.AutoSize = true;
            this.paidCheckBox.Location = new System.Drawing.Point(74, 166);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(94, 17);
            this.paidCheckBox.TabIndex = 15;
            this.paidCheckBox.Text = "Customer Paid";
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(72, 273);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(165, 23);
            this.addOrderButton.TabIndex = 16;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 300);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.paidCheckBox);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.ServiceCostTextBox);
            this.Controls.Add(this.ServiceTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.custIDLabel);
            this.Controls.Add(this.MainGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Customer Manager V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox ServiceTextBox;
        private System.Windows.Forms.TextBox ServiceCostTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button addOrderButton;
    }
}

