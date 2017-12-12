namespace lab_4_exercise_2_Population
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.organismsTextBox = new System.Windows.Forms.TextBox();
            this.increaseTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.populationListBox = new System.Windows.Forms.ListBox();
            this.growthButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Number of Organisms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average daily increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Days to multiply:";
            // 
            // organismsTextBox
            // 
            this.organismsTextBox.Location = new System.Drawing.Point(182, 9);
            this.organismsTextBox.Name = "organismsTextBox";
            this.organismsTextBox.Size = new System.Drawing.Size(100, 20);
            this.organismsTextBox.TabIndex = 3;
            // 
            // increaseTextBox
            // 
            this.increaseTextBox.Location = new System.Drawing.Point(182, 38);
            this.increaseTextBox.Name = "increaseTextBox";
            this.increaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.increaseTextBox.TabIndex = 4;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(182, 68);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // populationListBox
            // 
            this.populationListBox.FormattingEnabled = true;
            this.populationListBox.Location = new System.Drawing.Point(48, 103);
            this.populationListBox.Name = "populationListBox";
            this.populationListBox.Size = new System.Drawing.Size(234, 121);
            this.populationListBox.TabIndex = 6;
            // 
            // growthButton
            // 
            this.growthButton.Location = new System.Drawing.Point(64, 240);
            this.growthButton.Name = "growthButton";
            this.growthButton.Size = new System.Drawing.Size(82, 56);
            this.growthButton.TabIndex = 7;
            this.growthButton.Text = "Display Population Growth";
            this.growthButton.UseVisualStyleBackColor = true;
            this.growthButton.Click += new System.EventHandler(this.growthButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 240);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 56);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 317);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.growthButton);
            this.Controls.Add(this.populationListBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.increaseTextBox);
            this.Controls.Add(this.organismsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox organismsTextBox;
        private System.Windows.Forms.TextBox increaseTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.ListBox populationListBox;
        private System.Windows.Forms.Button growthButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

