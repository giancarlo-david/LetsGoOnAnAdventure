namespace LetsGoOnAnAdventure
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.richTextBoxNarration = new System.Windows.Forms.RichTextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(310, 129);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(566, 63);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Let\'s go on an adventure!";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(446, 352);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(279, 41);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Enter Your Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(453, 289);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(280, 55);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonBegin
            // 
            this.buttonBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBegin.Location = new System.Drawing.Point(508, 432);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(140, 57);
            this.buttonBegin.TabIndex = 4;
            this.buttonBegin.Text = "Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // richTextBoxNarration
            // 
            this.richTextBoxNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNarration.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxNarration.Location = new System.Drawing.Point(324, 129);
            this.richTextBoxNarration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxNarration.Name = "richTextBoxNarration";
            this.richTextBoxNarration.ReadOnly = true;
            this.richTextBoxNarration.Size = new System.Drawing.Size(552, 452);
            this.richTextBoxNarration.TabIndex = 6;
            this.richTextBoxNarration.TabStop = false;
            this.richTextBoxNarration.Text = "****************************************\n";
            this.richTextBoxNarration.Visible = false;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(508, 609);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(200, 58);
            this.buttonContinue.TabIndex = 7;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Visible = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.richTextBoxNarration);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s go on an adventure!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.RichTextBox richTextBoxNarration;
        private System.Windows.Forms.Button buttonContinue;
    }
}

