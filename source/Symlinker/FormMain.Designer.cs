namespace Symlinker
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLocationTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.exploreButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkNameComboBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.exploreButton2 = new System.Windows.Forms.Button();
            this.destinationLocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filesBrowser = new System.Windows.Forms.OpenFileDialog();
            this.TypeSelector = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createLinkButton = new Inkore.UI.WinForms.Styler.Controls.AdvButton();
            this.advButton1 = new Inkore.UI.WinForms.Styler.Controls.AdvButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the place where you want your link:";
            // 
            // linkLocationTextBox
            // 
            this.linkLocationTextBox.AllowDrop = true;
            this.linkLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLocationTextBox.Location = new System.Drawing.Point(12, 39);
            this.linkLocationTextBox.Name = "linkLocationTextBox";
            this.linkLocationTextBox.Size = new System.Drawing.Size(338, 20);
            this.linkLocationTextBox.TabIndex = 1;
            this.linkLocationTextBox.WordWrap = false;
            this.linkLocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.linkLocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.linkLocationTextBox.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Please select a folder";
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // exploreButton1
            // 
            this.exploreButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exploreButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exploreButton1.Location = new System.Drawing.Point(356, 37);
            this.exploreButton1.Name = "exploreButton1";
            this.exploreButton1.Size = new System.Drawing.Size(79, 23);
            this.exploreButton1.TabIndex = 2;
            this.exploreButton1.Text = "Explore...";
            this.exploreButton1.UseVisualStyleBackColor = true;
            this.exploreButton1.Click += new System.EventHandler(this.ExploreButton1Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now give a name to the link:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkNameComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exploreButton1);
            this.groupBox1.Controls.Add(this.linkLocationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link Folder";
            // 
            // linkNameComboBox
            // 
            this.linkNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNameComboBox.Location = new System.Drawing.Point(176, 63);
            this.linkNameComboBox.Name = "linkNameComboBox";
            this.linkNameComboBox.Size = new System.Drawing.Size(174, 20);
            this.linkNameComboBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.linkTypeComboBox);
            this.groupBox2.Controls.Add(this.exploreButton2);
            this.groupBox2.Controls.Add(this.destinationLocationTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(25, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select the type of link:";
            // 
            // linkTypeComboBox
            // 
            this.linkTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.linkTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.linkTypeComboBox.FormattingEnabled = true;
            this.linkTypeComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.linkTypeComboBox.Items.AddRange(new object[] {
            "Symbolic Link",
            "Hard Link",
            "Directory Junction"});
            this.linkTypeComboBox.Location = new System.Drawing.Point(175, 64);
            this.linkTypeComboBox.Name = "linkTypeComboBox";
            this.linkTypeComboBox.Size = new System.Drawing.Size(175, 21);
            this.linkTypeComboBox.TabIndex = 3;
            this.linkTypeComboBox.MouseHover += new System.EventHandler(this.ComboBox1MouseHover);
            // 
            // exploreButton2
            // 
            this.exploreButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exploreButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exploreButton2.Location = new System.Drawing.Point(356, 35);
            this.exploreButton2.Name = "exploreButton2";
            this.exploreButton2.Size = new System.Drawing.Size(75, 23);
            this.exploreButton2.TabIndex = 2;
            this.exploreButton2.Text = "Explore...";
            this.exploreButton2.UseVisualStyleBackColor = true;
            this.exploreButton2.Click += new System.EventHandler(this.Explorebutton2Click);
            // 
            // destinationLocationTextBox
            // 
            this.destinationLocationTextBox.AllowDrop = true;
            this.destinationLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationLocationTextBox.Location = new System.Drawing.Point(11, 37);
            this.destinationLocationTextBox.Name = "destinationLocationTextBox";
            this.destinationLocationTextBox.Size = new System.Drawing.Size(339, 20);
            this.destinationLocationTextBox.TabIndex = 1;
            this.destinationLocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.destinationLocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.destinationLocationTextBox.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please select the path to the real folder you want to link:";
            // 
            // TypeSelector
            // 
            this.TypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TypeSelector.Items.AddRange(new object[] {
            "Folder symbolic link",
            "File symbolic link"});
            this.TypeSelector.Location = new System.Drawing.Point(25, 84);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(302, 21);
            this.TypeSelector.TabIndex = 1;
            this.TypeSelector.SelectedIndexChanged += new System.EventHandler(this.TypeSelectorSelectedIndexChanged);
            this.TypeSelector.MouseHover += new System.EventHandler(this.TypeSelectorMouseHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Create a new symlink on this computer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Which type of symlink that you want to create";
            // 
            // createLinkButton
            // 
            this.createLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.createLinkButton.Location = new System.Drawing.Point(335, 334);
            this.createLinkButton.Name = "createLinkButton";
            this.createLinkButton.ShowShield = true;
            this.createLinkButton.Size = new System.Drawing.Size(128, 32);
            this.createLinkButton.TabIndex = 14;
            this.createLinkButton.Text = "Create Symlink";
            this.createLinkButton.UseVisualStyleBackColor = true;
            this.createLinkButton.Click += new System.EventHandler(this.CreateLinkClick);
            // 
            // advButton1
            // 
            this.advButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.advButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.advButton1.Location = new System.Drawing.Point(298, 334);
            this.advButton1.Name = "advButton1";
            this.advButton1.Size = new System.Drawing.Size(33, 32);
            this.advButton1.TabIndex = 16;
            this.advButton1.Text = "?";
            this.advButton1.UseVisualStyleBackColor = true;
            this.advButton1.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.createLinkButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 378);
            this.Controls.Add(this.advButton1);
            this.Controls.Add(this.createLinkButton);
            this.Controls.Add(this.TypeSelector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symlinker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linkLocationTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button exploreButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox linkNameComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exploreButton2;
        private System.Windows.Forms.TextBox destinationLocationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox linkTypeComboBox;
        private System.Windows.Forms.OpenFileDialog filesBrowser;
        private System.Windows.Forms.ComboBox TypeSelector;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Inkore.UI.WinForms.Styler.Controls.AdvButton createLinkButton;
        private Inkore.UI.WinForms.Styler.Controls.AdvButton advButton1;
    }
}

