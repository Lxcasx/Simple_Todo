namespace Simple_Todo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.New_Button = new System.Windows.Forms.Button();
            this._CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Button
            // 
            this.New_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.New_Button.Location = new System.Drawing.Point(2, 392);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(150, 46);
            this.New_Button.TabIndex = 0;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // _CheckBox
            // 
            this._CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._CheckBox.FormattingEnabled = true;
            this._CheckBox.Location = new System.Drawing.Point(0, 0);
            this._CheckBox.Name = "_CheckBox";
            this._CheckBox.Size = new System.Drawing.Size(800, 364);
            this._CheckBox.TabIndex = 3;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear_Button.Location = new System.Drawing.Point(314, 392);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(150, 46);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Remove_Button.Location = new System.Drawing.Point(158, 392);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(150, 46);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this._CheckBox);
            this.Controls.Add(this.New_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Simple Todo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.CheckedListBox _CheckBox;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Remove_Button;
    }
}

