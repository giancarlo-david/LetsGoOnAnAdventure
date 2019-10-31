namespace LetsGoOnAnAdventure
{
    partial class FormDiningHall
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
            this.buttonGrill = new System.Windows.Forms.Button();
            this.buttonDeli = new System.Windows.Forms.Button();
            this.buttonBurger = new System.Windows.Forms.Button();
            this.buttonPasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStations = new System.Windows.Forms.GroupBox();
            this.richTextBoxOptionSelected = new System.Windows.Forms.RichTextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxStations.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrill
            // 
            this.buttonGrill.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.buttonGrill.Location = new System.Drawing.Point(86, 42);
            this.buttonGrill.Name = "buttonGrill";
            this.buttonGrill.Size = new System.Drawing.Size(188, 120);
            this.buttonGrill.TabIndex = 0;
            this.buttonGrill.Text = "West Side Grill";
            this.buttonGrill.UseVisualStyleBackColor = true;
            this.buttonGrill.Click += new System.EventHandler(this.buttonGrill_Click);
            // 
            // buttonDeli
            // 
            this.buttonDeli.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.buttonDeli.Location = new System.Drawing.Point(351, 42);
            this.buttonDeli.Name = "buttonDeli";
            this.buttonDeli.Size = new System.Drawing.Size(188, 120);
            this.buttonDeli.TabIndex = 1;
            this.buttonDeli.Text = "The Deli";
            this.buttonDeli.UseVisualStyleBackColor = true;
            this.buttonDeli.Click += new System.EventHandler(this.buttonDeli_Click);
            // 
            // buttonBurger
            // 
            this.buttonBurger.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.buttonBurger.Location = new System.Drawing.Point(86, 211);
            this.buttonBurger.Name = "buttonBurger";
            this.buttonBurger.Size = new System.Drawing.Size(188, 120);
            this.buttonBurger.TabIndex = 2;
            this.buttonBurger.Text = "Burger Station";
            this.buttonBurger.UseVisualStyleBackColor = true;
            this.buttonBurger.Click += new System.EventHandler(this.buttonBurger_Click);
            // 
            // buttonPasta
            // 
            this.buttonPasta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.buttonPasta.Location = new System.Drawing.Point(351, 211);
            this.buttonPasta.Name = "buttonPasta";
            this.buttonPasta.Size = new System.Drawing.Size(188, 120);
            this.buttonPasta.TabIndex = 3;
            this.buttonPasta.Text = "The Pasta Bar";
            this.buttonPasta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Dining Hall West";
            // 
            // groupBoxStations
            // 
            this.groupBoxStations.Controls.Add(this.buttonDeli);
            this.groupBoxStations.Controls.Add(this.buttonGrill);
            this.groupBoxStations.Controls.Add(this.buttonPasta);
            this.groupBoxStations.Controls.Add(this.buttonBurger);
            this.groupBoxStations.Controls.Add(this.richTextBoxOptionSelected);
            this.groupBoxStations.Location = new System.Drawing.Point(180, 107);
            this.groupBoxStations.Name = "groupBoxStations";
            this.groupBoxStations.Size = new System.Drawing.Size(616, 376);
            this.groupBoxStations.TabIndex = 5;
            this.groupBoxStations.TabStop = false;
            this.groupBoxStations.Text = "Stations";
            // 
            // richTextBoxOptionSelected
            // 
            this.richTextBoxOptionSelected.Location = new System.Drawing.Point(-7, -25);
            this.richTextBoxOptionSelected.Name = "richTextBoxOptionSelected";
            this.richTextBoxOptionSelected.ReadOnly = true;
            this.richTextBoxOptionSelected.Size = new System.Drawing.Size(657, 416);
            this.richTextBoxOptionSelected.TabIndex = 6;
            this.richTextBoxOptionSelected.Text = "";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.buttonContinue.Location = new System.Drawing.Point(387, 489);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(204, 50);
            this.buttonContinue.TabIndex = 7;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // FormDiningHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.groupBoxStations);
            this.Controls.Add(this.label1);
            this.Name = "FormDiningHall";
            this.Text = "FormDiningHall";
            this.groupBoxStations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGrill;
        private System.Windows.Forms.Button buttonDeli;
        private System.Windows.Forms.Button buttonBurger;
        private System.Windows.Forms.Button buttonPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStations;
        private System.Windows.Forms.RichTextBox richTextBoxOptionSelected;
        private System.Windows.Forms.Button buttonContinue;
    }
}